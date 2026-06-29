using Quartz;

namespace Worker_Report
{
    public class GlobalJobListener : IJobListener
    {
        private readonly ILogger<GlobalJobListener> _logger;

        public GlobalJobListener(ILogger<GlobalJobListener> logger)
        {
            _logger = logger;
        }

        public string Name => "GlobalJobListener";

        public Task JobToBeExecuted(
            IJobExecutionContext context,
            CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        public Task JobExecutionVetoed(
            IJobExecutionContext context,
            CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        public Task JobWasExecuted(
            IJobExecutionContext context,
            JobExecutionException? jobException,
            CancellationToken cancellationToken = default)
        {
            if (jobException != null)
            {
                _logger.LogError(jobException,
                    "Job {JobKey} gagal",
                    context.JobDetail.Key);
            }

            return Task.CompletedTask;
        }
    }
}
