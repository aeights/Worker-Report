using Quartz;
using Worker_Report.Services.Report;

namespace Worker_Report.Jobs
{
    internal class DailyReportJob : IJob
    {
        private readonly IReportService _reportService;
        private readonly ILogger _logger;
        public DailyReportJob(IReportService reportService, ILogger<DailyReportJob> logger)
        {
            _logger = logger;
            _reportService = reportService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var start = DateTime.Today;
            var end = start.AddDays(1);

            _logger.LogInformation("Running daily report job at {Time}", DateTime.UtcNow);

            await _reportService.GetMasterData(start, end);
            await _reportService.GetMasterDataPribadi(start, end);
            await _reportService.GetAccount(start, end);
            await _reportService.GetCustomer(start, end);

            _logger.LogInformation("Daily report job completed.");
        }
    }
}
