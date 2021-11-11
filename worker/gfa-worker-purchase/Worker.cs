using System;
using System.Threading;
using System.Threading.Tasks;
using gfa_worker_common;
using gfa_worker_common.Network;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Model;

namespace gfa_worker_purchase
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ConfigNetwork _configNetwork;
        private readonly PurchaseNetwork _purchaseNetwork;
        private GfaWebConfigsConfigDto _gfaWebConfigsConfigDto;

        public Worker(ILogger<Worker> logger)
        {
            CredsHelper.GetCreds();
            _logger = logger;
            _configNetwork = new ConfigNetwork();
            _purchaseNetwork = new PurchaseNetwork();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _gfaWebConfigsConfigDto = _configNetwork.Run(gfa_worker_common.Worker.PurchaseWorker);
                if (_gfaWebConfigsConfigDto == null) return;
                
                Normal();
                //Test();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(_gfaWebConfigsConfigDto.TimerInMs, stoppingToken);
            }
        }

        private void Test()
        {
            BasePurchase basePurchase =  ParseHelper.TestBasePurchaseParser();
            _purchaseNetwork.Run(basePurchase, DateTime.Now, DateTime.Now);
        }

        private void Normal()
        {
            string args = String.Empty;
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            if (_gfaWebConfigsConfigDto.IsAll)
            {
                startDate = DateTime.Now.AddYears(-10);
                endDate = DateTime.Now;
                args = "/TGL:" + startDate.ToString("yyyyMMdd") + CommonHelper.tab +
                       "/TGL2:" + endDate.ToString("yyyyMMdd");
            }
            else if (_gfaWebConfigsConfigDto.IsDaily)
            {
                startDate = DateTime.Now;
                endDate = DateTime.Now;
                args = "/TGL:" + startDate.ToString("yyyyMMdd") + CommonHelper.tab +
                       "/TGL2:" + endDate.ToString("yyyyMMdd");
            }
            else if (_gfaWebConfigsConfigDto.IsMonthly)
            {
                startDate = DateTime.Now.AddMonths(-1);
                endDate = DateTime.Now;
                args = "/TGL:" + startDate.ToString("yyyyMMdd") + CommonHelper.tab +
                       "/TGL2:" + endDate.ToString("yyyyMMdd");
            }
            else if (_gfaWebConfigsConfigDto.IsYearly)
            {
                startDate = DateTime.Now.AddYears(-1);
                endDate = DateTime.Now;
                args = "/TGL:" + startDate.ToString("yyyyMMdd") + CommonHelper.tab +
                       "/TGL2:" + endDate.ToString("yyyyMMdd");
            }
            else
            {
                return;
            }
            args += CommonHelper.tab + CredsHelper.GetCreds();
            ProcessHelper processHelper = new ProcessHelper(gfa_worker_common.Worker.PurchaseWorkerExe, args);
            BasePurchase basePurchase =  ParseHelper.BasePurchaseParser(processHelper.Run());
            _purchaseNetwork.Run(basePurchase, startDate, endDate);
        }
    }
}