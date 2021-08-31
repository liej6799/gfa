using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using gfa_worker_common;
using gfa_worker_common.Network;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Model;

namespace gfa_worker_item
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ItemNetwork _itemNetwork;
        private readonly ConfigNetwork _configNetwork;
        private GfaWebConfigsConfigDto _gfaWebConfigsConfigDto;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _itemNetwork = new ItemNetwork();
            _configNetwork = new ConfigNetwork();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _gfaWebConfigsConfigDto = _configNetwork.Run(gfa_worker_common.Worker.ItemWorker);
                if (_gfaWebConfigsConfigDto == null) return;

                Normal();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(_gfaWebConfigsConfigDto.TimerInMs, stoppingToken);
            }
        }

        private void Normal()
        {
            string args = String.Empty;
            if (_gfaWebConfigsConfigDto.IsAll)
            {
                args = "/PR1:3";
            }
            else
            {
                return;
            }
            
            args += CommonHelper.tab + CredsHelper.GetCreds();
            ProcessHelper processHelper = new ProcessHelper(gfa_worker_common.Worker.ItemWorkerExe, args);
            BaseItem baseItem =  ParseHelper.BaseItemParser(processHelper.Run());
            _itemNetwork.Run(baseItem);
        }

        private void Test()
        {
            BaseItem baseItem = ParseHelper.TestBaseItemParser();
            _itemNetwork.Run(baseItem);
        }
    }
}