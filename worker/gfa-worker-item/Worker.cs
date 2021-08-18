using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using gfa_worker_common;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace gfa_worker_item
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
                string args = "/PR1:3" + CommonHelper.tab + CredsHelper.GetCreds();
                ProcessHelper processHelper = new ProcessHelper(gfa_worker_common.Worker.ItemWorker, args);
                BaseItem baseItem =  ParseHelper.BaseItemParser(processHelper.Run());
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}