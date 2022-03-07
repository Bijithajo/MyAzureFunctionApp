using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MyAzureFunctionApp
{
    public static class TimerTrigger
    {
        [FunctionName("TimerTriggerFunction")]
        public static void Run([TimerTrigger("*/10 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"TimerTriggerFunction executed at: {DateTime.Now}");
        }
    }
}
