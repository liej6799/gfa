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

namespace gfa_worker_sales
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ConfigNetwork _configNetwork;
        private readonly SalesNetwork _salesNetwork;
        private GfaWebConfigsConfigDto _gfaWebConfigsConfigDto;

        public Worker(ILogger<Worker> logger)
        {
            CredsHelper.GetCreds();
            _logger = logger;
            _configNetwork = new ConfigNetwork();
            _salesNetwork = new SalesNetwork();

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _gfaWebConfigsConfigDto = _configNetwork.Run(gfa_worker_common.Worker.SalesWorker);
                if (_gfaWebConfigsConfigDto == null) return;

                Normal();
                //Test();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(_gfaWebConfigsConfigDto.TimerInMs, stoppingToken);
            }
        }

        private void Normal()
        {
            if (!_gfaWebConfigsConfigDto.IsAll)
            {
                return;
            }
            string args = String.Empty;
            args = "/TGL:" + DateTime.Now.AddYears(-10).ToString("yyyyMMdd") + CommonHelper.tab +
                      "/TGL2:" + DateTime.Now.ToString("yyyyMMdd");
            args += CommonHelper.tab + CredsHelper.GetCreds();

            ProcessHelper processHelper = new ProcessHelper(gfa_worker_common.Worker.SalesWorkerExe, args);
            BaseSales baseSales = ParseHelper.BaseSalesParser(processHelper.Run());
            _salesNetwork.Run(baseSales);

            // PEMBEL_ID
            // TOT_HARGA
            // TANGGAL + JAM_INPUT
            // LUNAS

        }
    }
}
