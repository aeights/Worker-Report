namespace Worker_Report.Helper
{
    public enum SourceSystem
    {
        MASTER_DATA,
        MASTERDATA_PRIBADI,
        CC_ACCOUNT,
        CUSTOMERS,
        ENTRY_HMIN1,
        ENTRY_HMIN20,
        DECISION_HMIN1
    }

    internal static class S3KeyBuilder
    {
        public static string BuildKey(SourceSystem source, string fileName)
        {
            return $"REPORT/{source}/{fileName}";
        }
    }
}
