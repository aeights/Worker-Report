using ClosedXML.Excel;
using Worker_Report.Helper;
using Worker_Report.Repositories.Report;
using Worker_Report.services.AWSServices;

namespace Worker_Report.Services.Report
{
    internal class ReportService : IReportService
    {
        private readonly ILogger<ReportService> _logger;
        private readonly IReportRepository _reportRepository;
        private readonly IAWSServices _awsService;
        private readonly string bucketName;
        private readonly IConfiguration _configuration;
        public ReportService(ILogger<ReportService> logger, IReportRepository reportRepository, IAWSServices awsServices, IConfiguration configuration)
        {
            _logger = logger;
            _reportRepository = reportRepository;
            _awsService = awsServices;
            _configuration = configuration;
            bucketName = _configuration.GetValue<string>("AWS:BucketName:Main")!;
        }

        public async Task<(int, Stream, string)> GetMasterData(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetMasterData(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada master data di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var excel = GenerateExcel(data);
            var stream = new MemoryStream(excel);
            var fileName = $"MasterData_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            await UploadToStorage(stream, SourceSystem.MASTER_DATA, fileName);

            return (data.Count(), new MemoryStream(excel), fileName);
        }

        public async Task<(int, Stream, string)> GetMasterDataPribadi(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetMasterDataPribadi(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada master data pribadi di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var excel = GenerateExcel(data);
            var stream = new MemoryStream(excel);
            var fileName = $"MasterDataPribadi_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            await UploadToStorage(stream, SourceSystem.MASTERDATA_PRIBADI, fileName);

            return (data.Count(), new MemoryStream(excel), fileName);
        }

        public async Task<(int, Stream, string)> GetAccount(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetAccount(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada data account di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var excel = GenerateExcel(data);
            var stream = new MemoryStream(excel);
            var fileName = $"CCAccount_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            await UploadToStorage(stream, SourceSystem.CC_ACCOUNT, fileName);

            return (data.Count(), new MemoryStream(excel), fileName);
        }

        public async Task<(int, Stream, string)> GetCustomer(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetCustomer(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada data customer di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var excel = GenerateExcel(data);
            var stream = new MemoryStream(excel);
            var fileName = $"Customer_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            await UploadToStorage(stream, SourceSystem.CUSTOMERS, fileName);

            return (data.Count(), new MemoryStream(excel), fileName);
        }

        private byte[] GenerateExcel<T>(IEnumerable<T> data)
        {
            var properties = typeof(T).GetProperties();

            using var wb = new XLWorkbook();
            var ws = wb.AddWorksheet(typeof(T).Name);

            // Header
            for (int col = 0; col < properties.Length; col++)
            {
                ws.Cell(1, col + 1).Value = properties[col].Name;
            }

            var headerRow = ws.Row(1);
            headerRow.Style.Font.Bold = true;
            headerRow.Style.Fill.BackgroundColor = XLColor.LightBlue;

            var dataList = data.ToList();

            for (int row = 0; row < dataList.Count; row++)
            {
                for (int col = 0; col < properties.Length; col++)
                {
                    var value = properties[col].GetValue(dataList[row]);

                    ws.Cell(row + 2, col + 1).Value = value switch
                    {
                        null => "",
                        DateTime dt => dt.ToString("yyyy-MM-dd HH:mm:ss"),
                        DateTimeOffset dto => dto.ToString("yyyy-MM-dd HH:mm:ss"),
                        bool b => b,
                        _ => XLCellValue.FromObject(value)
                    };
                }
            }

            ws.Columns().AdjustToContents();

            var stream = new MemoryStream();
            wb.SaveAs(stream);

            return stream.ToArray();
        }

        private byte[] GenerateFlattenExcel<T>(IEnumerable<T> data)
        {
            using var wb = new XLWorkbook();
            var ws = wb.AddWorksheet(typeof(T).Name);

            var dataList = data.ToList();

            if (!dataList.Any())
                return Array.Empty<byte>();

            var rows = dataList
                .Select(x => FlattenObject(x!))
                .ToList();

            var headers = rows
                .SelectMany(x => x.Keys)
                .Distinct()
                .ToList();

            for (int col = 0; col < headers.Count; col++)
            {
                ws.Cell(1, col + 1).Value = headers[col];
            }

            var headerRow = ws.Row(1);
            headerRow.Style.Font.Bold = true;
            headerRow.Style.Fill.BackgroundColor = XLColor.LightBlue;

            for (int row = 0; row < rows.Count; row++)
            {
                for (int col = 0; col < headers.Count; col++)
                {
                    rows[row].TryGetValue(headers[col], out var value);

                    ws.Cell(row + 2, col + 1).Value = value switch
                    {
                        null => "",
                        DateTime dt => dt.ToString("yyyy-MM-dd HH:mm:ss"),
                        DateTimeOffset dto => dto.ToString("yyyy-MM-dd HH:mm:ss"),
                        bool b => b,
                        _ => XLCellValue.FromObject(value)
                    };
                }
            }

            ws.Columns().AdjustToContents();

            var stream = new MemoryStream();
            wb.SaveAs(stream);

            return stream.ToArray();
        }

        private async Task UploadToStorage(Stream stream, SourceSystem source, string fileName, string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            var key = S3KeyBuilder.BuildKey(source, fileName);
            await _awsService.UploadStreamAsync(stream, bucketName, key, contentType);
        }

        private static Dictionary<string, object?> FlattenObject(object obj)
        {
            var result = new Dictionary<string, object?>();

            Flatten(obj, "", result);

            return result;
        }

        private static void Flatten(object? obj, string prefix, Dictionary<string, object?> result)
        {
            if (obj == null)
                return;

            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                if (prop.GetIndexParameters().Length > 0)
                    continue;

                var value = prop.GetValue(obj);

                var name = string.IsNullOrEmpty(prefix)
                    ? prop.Name
                    : $"{prefix}.{prop.Name}";

                if (value == null)
                {
                    result[name] = null;
                    continue;
                }

                var propType = prop.PropertyType;
                var underlyingType = Nullable.GetUnderlyingType(propType) ?? propType;

                if (underlyingType.IsPrimitive
                    || underlyingType == typeof(string)
                    || underlyingType == typeof(decimal)
                    || underlyingType == typeof(DateTime)
                    || underlyingType == typeof(DateTimeOffset)
                    || underlyingType == typeof(Guid)
                    || underlyingType == typeof(TimeSpan)
                    || underlyingType.IsEnum)
                {
                    result[name] = value;
                }
                else if (value is System.Collections.IEnumerable enumerable)
                {
                    var items = enumerable.Cast<object>().ToList();
                    result[name] = string.Join(", ", items.Select(i => i?.ToString() ?? ""));
                }
                else
                {
                    Flatten(value, name, result);
                }
            }
        }

        public async Task<(int, Stream, string)> GetEntryHMin1(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetEntryHMin1(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada data account di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var excel = GenerateFlattenExcel(data);
            var stream = new MemoryStream(excel);
            var fileName = $"EntryHMin1_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            await UploadToStorage(stream, SourceSystem.ENTRY_HMIN1, fileName);

            return (data.Count(), new MemoryStream(excel), fileName);
        }

        public async Task<(int, Stream, string)> GetEntryHMin20(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetEntryHMin20(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada data account di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var excel = GenerateFlattenExcel(data);
            var stream = new MemoryStream(excel);
            var fileName = $"EntryHMin20_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            await UploadToStorage(stream, SourceSystem.ENTRY_HMIN20, fileName);

            return (data.Count(), new MemoryStream(excel), fileName);
        }

        public async Task<(int, Stream, string)> GetDecisionHMin1(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetDecisioinHMin1(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada data account di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var excel = GenerateFlattenExcel(data);
            var stream = new MemoryStream(excel);
            var fileName = $"DecisionHMin1{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            await UploadToStorage(stream, SourceSystem.DECISION_HMIN1, fileName);

            return (data.Count(), new MemoryStream(excel), fileName);
        }
    }
}
