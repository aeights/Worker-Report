
using Microsoft.EntityFrameworkCore;
using Worker_Report.Data;
using Worker_Report.Data.Models;
using Worker_Report.Models.Report;

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

        public async Task<IEnumerable<CDRViewModel>> GetEntryHMin1(DateTime start, DateTime end)
        {
            return await (from m in _context.MASTER_DATA
                        join p in _context.MASTERDATA_PRIBADI
                            on m.MASTERDATA_ID equals p.MASTERDATA_FK
                        join j in _context.MASTERDATA_PEKERJAAN
                            on m.MASTERDATA_ID equals j.MASTERDATA_FK
                        join s in _context.MASTERDATA_SYSTEM
                            on m.MASTERDATA_ID equals s.MASTERDATA_FK
                        join d in _context.MASTERDATA_DARURAT
                            on m.MASTERDATA_ID equals d.MASTERDATA_FK
                        join o in _context.MASTERDATA_OPERATOR
                            on m.MASTERDATA_ID equals o.MASTERDATA_FK
                        join misc in _context.MASTERDATA_MISC
                            on m.MASTERDATA_ID equals misc.MASTERDATA_FK
                        where o.WAKTUDE >= start
                            && o.WAKTUDE <= end
                        select new CDRViewModel
                        {
                            MasterData = m,
                            MasterDataPribadi = p,
                            MasterDataPekerjaan = j,
                            MasterDataSystem = s,
                            MasterDataDarurat = d,
                            MasterDataOperator = o,
                            MasterDataMisc = misc
                        })
                        .ToListAsync();
        }

        public async Task<IEnumerable<CDRViewModel>> GetEntryHMin20(DateTime start, DateTime end)
        {
            return await(from m in _context.MASTER_DATA
                        join p in _context.MASTERDATA_PRIBADI
                            on m.MASTERDATA_ID equals p.MASTERDATA_FK
                        join j in _context.MASTERDATA_PEKERJAAN
                            on m.MASTERDATA_ID equals j.MASTERDATA_FK
                        join s in _context.MASTERDATA_SYSTEM
                            on m.MASTERDATA_ID equals s.MASTERDATA_FK
                        join d in _context.MASTERDATA_DARURAT
                            on m.MASTERDATA_ID equals d.MASTERDATA_FK
                        join o in _context.MASTERDATA_OPERATOR
                            on m.MASTERDATA_ID equals o.MASTERDATA_FK
                        join misc in _context.MASTERDATA_MISC
                            on m.MASTERDATA_ID equals misc.MASTERDATA_FK
                        where o.WAKTUDE >= start
                            && o.WAKTUDE <= end
                        select new CDRViewModel
                        {
                            MasterData = m,
                            MasterDataPribadi = p,
                            MasterDataPekerjaan = j,
                            MasterDataSystem = s,
                            MasterDataDarurat = d,
                            MasterDataOperator = o,
                            MasterDataMisc = misc
                        })
                    .ToListAsync();
        }

        public async Task<IEnumerable<CDRViewModel>> GetDecisioinHMin1(DateTime start, DateTime end)
        {
            return await(from m in _context.MASTER_DATA
                        join p in _context.MASTERDATA_PRIBADI
                            on m.MASTERDATA_ID equals p.MASTERDATA_FK
                        join j in _context.MASTERDATA_PEKERJAAN
                            on m.MASTERDATA_ID equals j.MASTERDATA_FK
                        join s in _context.MASTERDATA_SYSTEM
                            on m.MASTERDATA_ID equals s.MASTERDATA_FK
                        join d in _context.MASTERDATA_DARURAT
                            on m.MASTERDATA_ID equals d.MASTERDATA_FK
                        join o in _context.MASTERDATA_OPERATOR
                            on m.MASTERDATA_ID equals o.MASTERDATA_FK
                        join misc in _context.MASTERDATA_MISC
                            on m.MASTERDATA_ID equals misc.MASTERDATA_FK
                        where o.WAKTUDECISION >= start
                            && o.WAKTUDECISION <= end
                        select new CDRViewModel
                        {
                            MasterData = m,
                            MasterDataPribadi = p,
                            MasterDataPekerjaan = j,
                            MasterDataSystem = s,
                            MasterDataDarurat = d,
                            MasterDataOperator = o,
                            MasterDataMisc = misc
                        })
                    .ToListAsync();
        }
    }
}
