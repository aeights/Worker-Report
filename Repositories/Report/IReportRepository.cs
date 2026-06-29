
using Worker_Report.Data.Models;

namespace Worker_Report.Repositories.Report
{
    internal interface IReportRepository
    {
        public Task<IEnumerable<MASTER_DATA>> GetMasterData(DateTime start, DateTime end);
        public Task<IEnumerable<MASTERDATA_PRIBADI>> GetMasterDataPribadi(DateTime start, DateTime end);
        public Task<IEnumerable<CUSTOMERS>> GetCustomer(DateTime start, DateTime end);
        public Task<IEnumerable<CC_ACCOUNT>> GetAccount(DateTime start, DateTime end);
    }
}
