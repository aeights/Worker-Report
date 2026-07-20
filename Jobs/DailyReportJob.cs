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

            var startHMin1 = start.AddDays(-1);
            var endHMin1 = start;

            var startHMin20 = start.AddDays(-20);
            var endHMin20 = startHMin20.AddDays(1);

            _logger.LogInformation("Running daily report job at {Time}", DateTime.UtcNow);

            await _reportService.GetMasterData(start, end);
            await _reportService.GetMasterDataPribadi(start, end);
            await _reportService.GetAccount(start, end);
            await _reportService.GetCustomer(start, end);
            await _reportService.GetEntryHMin1(startHMin1, endHMin1);
            await _reportService.GetEntryHMin20(startHMin20, endHMin20);
            await _reportService.GetDecisionHMin1(startHMin1, endHMin1);

            _logger.LogInformation("Daily report job completed.");
        }
    }
}
