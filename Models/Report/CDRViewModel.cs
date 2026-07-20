using Worker_Report.Data.Models;

namespace Worker_Report.Models.Report
{
    public class CDRViewModel
    {
        public MASTER_DATA? MasterData { get; set; }
        public MASTERDATA_PRIBADI? MasterDataPribadi { get; set; }
        public MASTERDATA_PEKERJAAN? MasterDataPekerjaan { get; set; }
        public MASTERDATA_SYSTEM? MasterDataSystem { get; set; }
        public MASTERDATA_DARURAT? MasterDataDarurat { get; set; }
        public MASTERDATA_OPERATOR? MasterDataOperator { get; set; }
        public MASTERDATA_MISC? MasterDataMisc { get; set; }
    }
}
