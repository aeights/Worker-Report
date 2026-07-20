namespace Worker_Report.Services.Report
{
    public interface IReportService
    {
        public Task<(int, Stream, string)> GetMasterData(DateTime start, DateTime end);
        public Task<(int, Stream, string)> GetMasterDataPribadi(DateTime start, DateTime end);
        public Task<(int, Stream, string)> GetCustomer(DateTime start, DateTime end);
        public Task<(int, Stream, string)> GetAccount(DateTime start, DateTime end);
        public Task<(int, Stream, string)> GetEntryHMin1(DateTime start, DateTime end);
        public Task<(int, Stream, string)> GetEntryHMin20(DateTime start, DateTime end);
        public Task<(int, Stream, string)> GetDecisionHMin1(DateTime start, DateTime end);
    }
}
