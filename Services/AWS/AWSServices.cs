using Amazon.S3;
using Amazon.S3.Model;
using Worker_Report.Models;

namespace Worker_Report.services.AWSServices
{
    public class AWSServices : IAWSServices
    {
        private readonly IAmazonS3 _s3Client;
        private readonly string _serviceUrl;
        private readonly string _checkSum;
        private readonly ILogger<AWSServices> _logger;

        public AWSServices(IAmazonS3 s3Client, IConfiguration config, ILogger<AWSServices> logger)
        {
            _s3Client = s3Client;
            _serviceUrl = config.GetValue<string>("AWS:Host")!;
            _checkSum = config.GetValue<string>("AWS:CheckSumSHA256")!;
            _logger = logger;
        }

        public async Task<ResponseBase<List<string>>> TestConnectionAsync()
        {
            var response = await _s3Client.ListBucketsAsync();

            var bucketNames = response.Buckets
                .Select(b => b.BucketName)
                .ToList();

            return new ResponseBase<List<string>>
            {
                Status = "200",
                Message = "Connection successful",
                Data = bucketNames
            };
        }

        // public async Task<ResponseBase<object>> UploadFileAsync(IFormFile file, string bucketName, string fileName)
        // {
        //     if (string.IsNullOrEmpty(bucketName))
        //     {
        //         return new ResponseBase<object>
        //         {
        //             Status = "400",
        //             Message = "Bucket name cannot be empty!",
        //         };
        //     }

        //     if (string.IsNullOrEmpty(fileName))
        //     {
        //         return new ResponseBase<object>
        //         {
        //             Status = "400",
        //             Message = "File name cannot be empty!",
        //         };
        //     }

        //     if (file == null || file.Length == 0)
        //     {
        //         return new ResponseBase<object>
        //         {
        //             Status = "400",
        //             Message = "File cannot be empty!"
        //         };
        //     }

        //     if (string.IsNullOrEmpty(fileName))
        //     {
        //         fileName = file.FileName;
        //     }

        //     using var stream = file.OpenReadStream();

        //     var request = new PutObjectRequest
        //     {
        //         BucketName = bucketName,
        //         Key = fileName,
        //         InputStream = stream,
        //         ContentType = file.ContentType,
        //         DisablePayloadSigning = true,
        //         UseChunkEncoding = false,
        //         ChecksumSHA256 = _checkSum
        //     };

        //     var response = await _s3Client.PutObjectAsync(request);

        //     return new ResponseBase<object>
        //     {
        //         Status = "200",
        //         Message = "Upload successfully!",
        //         Data = new
        //         {
        //             fileName,
        //             response.ETag
        //         }
        //     };
        // }

        public async Task<AWSResponse<S3ObjectResponse>> UploadStreamAsync(Stream stream, string bucketName, string key, string contentType, string? tagKey = null, string? tagValue = null)
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                InputStream = stream,
                ContentType = contentType,
                ChecksumSHA256 = _checkSum
            };

            if (!string.IsNullOrWhiteSpace(tagKey) && !string.IsNullOrWhiteSpace(tagValue))
                {
                    request.TagSet = new List<Tag>
                    {
                        new Tag
                        {
                            Key = tagKey,
                            Value = tagValue
                        }
                    };
                }

            var response = await _s3Client.PutObjectAsync(request);

            return new AWSResponse<S3ObjectResponse>
            {
                Success = true,
                StatusCode = 200,
                Message = "Upload successfully!",
                Data = new S3ObjectResponse
                {
                    Key = key,
                    ETag = response.ETag,
                    BucketName = bucketName
                }
            };
        }

        public async Task<ResponseBase<object>> GetFileListAsync(string bucketName, string? prefix = null)
        {
            if (string.IsNullOrEmpty(bucketName))
            {
                return new ResponseBase<object>
                {
                    Status = "400",
                    Message = "Bucket name cannot be empty!",
                };
            }

            var request = new ListObjectsV2Request
            {
                BucketName = bucketName,
                Prefix = prefix,
                MaxKeys = 1000
            };

            var response = await _s3Client.ListObjectsV2Async(request);

            var files = (response.S3Objects ?? new List<S3Object>())
                .Select(x => new
                {
                    x.Key,
                    x.Size,
                    x.LastModified,
                    Url = $"{_serviceUrl}/{bucketName}/{x.Key}"
                })
                .ToList();

            return new ResponseBase<object>
            {
                Status = "200",
                Message = "Get file list successfully!",
                Data = files
            };
        }

        public async Task<(Stream stream, string contentType, string fileName)> DownloadFileAsync(string fileName, string bucketName)
        {
            var request = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = fileName
            };

            var response = await _s3Client.GetObjectAsync(request);

            return (response.ResponseStream, response.Headers.ContentType, fileName);
        }

        public async Task<ResponseBase<object>> DeleteFileAsync(string fileName, string bucketName)
        {
            if (string.IsNullOrEmpty(bucketName))
            {
                return new ResponseBase<object>
                {
                    Status = "400",
                    Message = "Bucket name cannot be empty!",
                };
            }

            if (string.IsNullOrEmpty(fileName))
            {
                return new ResponseBase<object>
                {
                    Status = "400",
                    Message = "File name cannot be empty!",
                };
            }

            var request = new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = fileName
            };

            await _s3Client.DeleteObjectAsync(request);

            return new ResponseBase<object>
            {
                Status = "200",
                Message = "Delete file successfully!"
            };
        }

        public ResponseBase<object> GeneratePresignedUrl(string fileName, string bucketName, int expiryMinutes = 60)
        {
            if (string.IsNullOrEmpty(bucketName))
            {
                return new ResponseBase<object>
                {
                    Status = "400",
                    Message = "Bucket name cannot be empty!",
                };
            }

            if (string.IsNullOrEmpty(fileName))
            {
                return new ResponseBase<object>
                {
                    Status = "400",
                    Message = "File name cannot be empty!",
                };
            }

            var request = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = fileName,
                Expires = DateTime.UtcNow.AddMinutes(expiryMinutes)
            };

            var url = _s3Client.GetPreSignedURL(request);

            return new ResponseBase<object>
            {
                Status = "200",
                Message = "Generate URL successfully!",
                Data = new
                {
                    FileName = fileName,
                    Url = url,
                    ExpiredInMinutes = expiryMinutes
                }
            };
        }

        public async Task<(Stream stream, string contentType, string fileName)?>DownloadFileByTagAsync(string bucketName, string prefix, string tagKey, string tagValue)
        {
            string? matchedKey = null;

            var listRequest = new ListObjectsV2Request
            {
                BucketName = bucketName,
                Prefix = prefix
            };

            var listResponse = await _s3Client.ListObjectsV2Async(listRequest);

            foreach (var obj in listResponse.S3Objects)
            {
                var tagResponse = await _s3Client.GetObjectTaggingAsync(
                    new GetObjectTaggingRequest
                    {
                        BucketName = bucketName,
                        Key = obj.Key
                    });

                var hasTag = tagResponse.Tagging != null &&
                     tagResponse.Tagging.Any(x =>
                         x.Key == tagKey &&
                         x.Value == tagValue);

                if (hasTag)
                {
                    matchedKey = obj.Key;
                    break;
                }
            }

            if (string.IsNullOrEmpty(matchedKey))
                return null;

            var response = await _s3Client.GetObjectAsync(
                new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = matchedKey
                });

            return (
                response.ResponseStream,
                response.Headers.ContentType,
                Path.GetFileName(matchedKey)
            );
        }
    }
}
