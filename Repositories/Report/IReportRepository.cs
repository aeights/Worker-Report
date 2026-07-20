
using Worker_Report.Data.Models;
using Worker_Report.Models.Report;

namespace Worker_Report.Repositories.Report
{
    internal interface IReportRepository
    {
        public Task<IEnumerable<MASTER_DATA>> GetMasterData(DateTime start, DateTime end);
        public Task<IEnumerable<MASTERDATA_PRIBADI>> GetMasterDataPribadi(DateTime start, DateTime end);
        public Task<IEnumerable<CUSTOMERS>> GetCustomer(DateTime start, DateTime end);
        public Task<IEnumerable<CC_ACCOUNT>> GetAccount(DateTime start, DateTime end);
        public Task<IEnumerable<CDRViewModel>> GetEntryHMin1(DateTime start, DateTime end);
        public Task<IEnumerable<CDRViewModel>> GetEntryHMin20(DateTime start, DateTime end);
        public Task<IEnumerable<CDRViewModel>> GetDecisioinHMin1(DateTime start, DateTime end);
    }
}
