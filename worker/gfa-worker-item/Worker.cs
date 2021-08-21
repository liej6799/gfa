using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using gfa_worker_common;
using gfa_worker_common.Network;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace gfa_worker_item
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ItemNetwork _itemNetwork;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _itemNetwork = new ItemNetwork();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Test();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }

        private void Normal()
        {
            string args = "/PR1:3" + CommonHelper.tab + CredsHelper.GetCreds();
            ProcessHelper processHelper = new ProcessHelper(gfa_worker_common.Worker.ItemWorker, args);
            BaseItem baseItem =  ParseHelper.BaseItemParser(processHelper.Run());
        }

        private void Test()
        {
            BaseItem baseItem = ParseHelper.TestBaseItemParser();
            _itemNetwork.Run(baseItem);
        }
        
        
    }
}