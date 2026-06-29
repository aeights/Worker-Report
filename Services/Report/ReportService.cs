using ClosedXML.Excel;
using Worker_Report.Data.Models;
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

            var stream = GenerateExcel(data);
            var fileName = $"MasterData_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            UploadToStorage(stream, SourceSystem.MASTER_DATA, fileName);

            return (data.Count(), stream, fileName);
        }

        public async Task<(int, Stream, string)> GetMasterDataPribadi(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetMasterDataPribadi(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada master data pribadi di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var stream = GenerateExcel(data);
            var fileName = $"MasterDataPribadi_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            UploadToStorage(stream, SourceSystem.MASTERDATA_PRIBADI, fileName);

            return (data.Count(), stream, fileName);
        }

        public async Task<(int, Stream, string)> GetAccount(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetAccount(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada data account di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var stream = GenerateExcel(data);
            var fileName = $"CCAccount_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            UploadToStorage(stream, SourceSystem.CC_ACCOUNT, fileName);

            return (data.Count(), stream, fileName);
        }

        public async Task<(int, Stream, string)> GetCustomer(DateTime start, DateTime end)
        {
            var data = await _reportRepository.GetCustomer(start, end);
            if (data.Count() == 0)
            {
                _logger.LogInformation($"Tidak ada data customer di rentang waktu {start} sampai {end}");
                return (0, new MemoryStream(), string.Empty);
            }

            var stream = GenerateExcel(data);
            var fileName = $"Customer_{start:yyyyMMdd}_{end:yyyyMMdd}.xlsx";
            UploadToStorage(stream, SourceSystem.CUSTOMERS, fileName);

            return (data.Count(), stream, fileName);
        }

        private MemoryStream GenerateExcel<T>(IEnumerable<T> data)
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
            stream.Position = 0;

            return stream;
        }

        private async void UploadToStorage(Stream stream, SourceSystem source, string fileName, string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            var key = S3KeyBuilder.BuildKey(source, fileName);
            await _awsService.UploadStreamAsync(stream, bucketName, key, contentType);
        }
    }
}
