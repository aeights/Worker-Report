using Amazon.Runtime;

namespace Worker_Report
{
    public class CustomHttpClientFactory : HttpClientFactory
    {
        public override HttpClient CreateHttpClient(IClientConfig clientConfig)
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            return new HttpClient(handler)
            {
                Timeout = TimeSpan.FromMinutes(5)
            };
        }

        public override bool UseSDKHttpClientCaching(IClientConfig clientConfig)
        {
            return false;
        }
    }
}
