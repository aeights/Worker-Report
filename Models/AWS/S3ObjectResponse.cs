namespace Worker_Report.Models
{
    public class S3ObjectResponse
    {
        public string? ETag { get; set; }
        public string? Key { get; set; }
        public string? BucketName { get; set; }
    }
}
