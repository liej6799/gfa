using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using gfa_worker_common;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace gfa_worker_purchase
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                string args = "/TGL:20210718" + CommonHelper.tab + 
                              "/TGL2:20210718" + CommonHelper.tab + 
                              CredsHelper.GetCreds();
                ProcessHelper processHelper = new ProcessHelper(gfa_worker_common.Worker.PurchaseWorkerExe, args);
                BasePurchase basePurchase =  ParseHelper.BasePurchaseParser(processHelper.Run());
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}