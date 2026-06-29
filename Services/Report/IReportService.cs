using Worker_Report.Data.Models;

namespace Worker_Report.Services.Report
{
    internal interface IReportService
    {
        public Task<(int, Stream, string)> GetMasterData(DateTime start, DateTime end);
        public Task<(int, Stream, string)> GetMasterDataPribadi(DateTime start, DateTime end);
        public Task<(int, Stream, string)> GetCustomer(DateTime start, DateTime end);
        public Task<(int, Stream, string)> GetAccount(DateTime start, DateTime end);
    }
}
