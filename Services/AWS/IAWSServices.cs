using Worker_Report.Models;

namespace Worker_Report.services.AWSServices
{
    public interface IAWSServices
    {
        public Task<ResponseBase<List<string>>> TestConnectionAsync();
        // public Task<ResponseBase<object>> UploadFileAsync(IFormFile file, string bucketName, string fileName);
        public Task<AWSResponse<S3ObjectResponse>> UploadStreamAsync(Stream stream, string bucketName, string key, string contentType, string? tagKey = null, string? tagValue = null);
        public Task<ResponseBase<object>> GetFileListAsync(string bucketName, string? prefix = null);
        public Task<(Stream stream, string contentType, string fileName)> DownloadFileAsync(string fileName, string bucketName);
        public Task<ResponseBase<object>> DeleteFileAsync(string fileName, string bucketName);
        public ResponseBase<object> GeneratePresignedUrl(string fileName, string bucketName, int expiryMinutes = 60);
        public Task<(Stream stream, string contentType, string fileName)?> DownloadFileByTagAsync(string bucketName, string prefix, string tagKey, string tagValue);
    }
}
