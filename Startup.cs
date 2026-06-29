using Amazon.Runtime;
using Amazon.S3;
using Worker_Report.Data;
using Microsoft.EntityFrameworkCore;
using Quartz;
using Worker_Report.Jobs;
using Worker_Report.services.AWSServices;
using Worker_Report.Repositories.Report;
using Worker_Report.Services.Report;

namespace Worker_Report
{
    public static class Startup
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            // Connection
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (request, cert, chain, errors) => true
            };

            var httpClient = new HttpClient(handler);

            var s3Config = new AmazonS3Config
            {
                ServiceURL = configuration.GetValue<string>("AWS:Host"),
                ForcePathStyle = true,
                HttpClientFactory = new CustomHttpClientFactory(),
            };

            var s3Credentials = new BasicAWSCredentials(
                configuration.GetValue<string>("AWS:AccessKey"),
                configuration.GetValue<string>("AWS:SecretKey")
            );

            services.AddSingleton<IAmazonS3>(
                new AmazonS3Client(s3Credentials, s3Config)
            );

            services.AddScoped<IAWSServices, AWSServices>();
            // End AWS S3 Client Configuration

            services.AddDbContext<DBContext>((sp, options) =>
            {
                options.UseOracle(configuration.GetConnectionString("CCOS"));
            });

            // Application services
            services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<IReportService, ReportService>();

            // Worker
            services.AddHostedService<Worker>();

            var schedule = environment.IsDevelopment()
                ? configuration.GetValue<string>("Report:CronDevSchedule")
                : configuration.GetValue<string>("Report:CronSchedule");

            var customTimeZone = TimeZoneInfo.CreateCustomTimeZone(
                id: "WIB",
                baseUtcOffset: TimeSpan.FromHours(configuration.GetValue<double>("Report:UtcOffset")),
                displayName: "WIB",
                standardDisplayName: "WIB"
            );

            services.AddQuartz(q =>
            {
                q.AddJobListener<GlobalJobListener>();

                q.AddJob<DailyReportJob>(opts => opts
                    .WithIdentity("DailyReportJob")
                    .DisallowConcurrentExecution()
                );

                q.AddTrigger(opts => opts
                    .ForJob("DailyReportJob")
                    .WithIdentity("DailyReportTrigger")
                    .WithCronSchedule(schedule!, x => x
                        .InTimeZone(customTimeZone)
                    )
                );
            });

            services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);

            return services;
        }
    }
}
