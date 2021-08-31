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

namespace gfa_worker_vendor
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ConfigNetwork _configNetwork;
        private readonly VendorNetwork _vendorNetwork;
        private GfaWebConfigsConfigDto _gfaWebConfigsConfigDto;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _configNetwork = new ConfigNetwork();
            _vendorNetwork = new VendorNetwork();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _gfaWebConfigsConfigDto = _configNetwork.Run(gfa_worker_common.Worker.VendorWorker);
                if (_gfaWebConfigsConfigDto == null) return;
                
                //Normal();
                Test();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(_gfaWebConfigsConfigDto.TimerInMs, stoppingToken);
            }
        }

        private void Test()
        {
            BaseVendor baseVendor =  ParseHelper.TestBaseVendorParser();
            _vendorNetwork.Run(baseVendor);
        }

        private void Normal()
        {
            if (!_gfaWebConfigsConfigDto.IsAll)
            {
                return;
            }
            string args = CredsHelper.GetCreds();
            
            ProcessHelper processHelper = new ProcessHelper(gfa_worker_common.Worker.VendorWorkerExe, args);
            BaseVendor baseVendor =  ParseHelper.BaseVendorParser(processHelper.Run());
            _vendorNetwork.Run(baseVendor);
        }
    }
}