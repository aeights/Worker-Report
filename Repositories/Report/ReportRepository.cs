
using Microsoft.EntityFrameworkCore;
using Worker_Report.Data;
using Worker_Report.Data.Models;

namespace Worker_Report.Repositories.Report
{
    internal class ReportRepository : IReportRepository
    {
        private readonly DBContext _context;
        public ReportRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MASTER_DATA>> GetMasterData(DateTime start, DateTime end)
        {
            return await (from m in _context.MASTER_DATA
                            join o in _context.MASTERDATA_OPERATOR
                                on m.MASTERDATA_ID equals o.MASTERDATA_FK
                            where o.WAKTUDEMULAI >= start
                                && o.WAKTUDEMULAI <= end
                            select m)
                            .ToListAsync();
        }

        public async Task<IEnumerable<MASTERDATA_PRIBADI>> GetMasterDataPribadi(DateTime start, DateTime end)
        {
            return await (from p in _context.MASTERDATA_PRIBADI
                            join o in _context.MASTERDATA_OPERATOR
                                on p.MASTERDATA_FK equals o.MASTERDATA_FK
                            where o.WAKTUDEMULAI >= start
                                && o.WAKTUDEMULAI <= end
                            select p)
                            .ToListAsync();
        }

        public async Task<IEnumerable<CC_ACCOUNT>> GetAccount(DateTime start, DateTime end)
        {
            return await (from c in _context.CC_ACCOUNT
                            where c.OPENDATE >= start
                                &&  c.OPENDATE <= end
                            select c)
                            .ToListAsync();
        }

        public async Task<IEnumerable<CUSTOMERS>> GetCustomer(DateTime start, DateTime end)
        {
            return await (from c in _context.CUSTOMERS
                            where c.WAKTUCUSTOMER >= start
                                && c.WAKTUCUSTOMER <= end
                            select c)
                            .ToListAsync();
        }
    }
}
