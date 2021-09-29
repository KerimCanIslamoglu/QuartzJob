using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuartzJob.Job
{
    [DisallowConcurrentExecution]
    public class HelloWorldJob:IJob
    {
        private readonly ILogger<HelloWorldJob> _logger;
        public HelloWorldJob(ILogger<HelloWorldJob> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("Hello world!");
            return Task.CompletedTask;
        }




        // For Scoped Registered Services

        //private readonly IServiceProvider _provider;
        //public HelloWorldJob(IServiceProvider provider)
        //{
        //    _provider = provider;
        //}

        //public Task Execute(IJobExecutionContext context)
        //{
        //    // Create a new scope
        //    using (var scope = _provider.CreateScope())
        //    {
        //        // Resolve the Scoped service
        //        var service = scope.ServiceProvider.GetService<IScopedService>();
        //        _logger.LogInformation("Hello world!");
        //    }

        //    return Task.CompletedTask;
        //}
    }
}
