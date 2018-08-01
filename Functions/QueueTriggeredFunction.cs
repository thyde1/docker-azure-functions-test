namespace Functions
{
    using System.Threading.Tasks;

    using Microsoft.Azure.WebJobs;

    public static class QueueTriggeredFunction
    {
        [FunctionName("QueueTriggeredFunction")]
        public static Task Run(
            [QueueTrigger("myfunctionsqueue")] string message)
        {
            return Task.CompletedTask;
        }
    }
}
