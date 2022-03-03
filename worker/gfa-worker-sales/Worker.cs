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
            //CredsHelper.GetCreds();
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

                //Normal();
                Test();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(_gfaWebConfigsConfigDto.TimerInMs, stoppingToken);
            }
        }

        private void Test()
        {
            BaseSales baseSales =  ParseHelper.TestBaseSalesParser();
            _salesNetwork.Run(baseSales.Records, DateTime.Now, DateTime.Now);
        }
        

        private void Normal()
        {
            string args = String.Empty;
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            if (_gfaWebConfigsConfigDto.IsAll)
            {
                startDate = DateTime.Now.AddYears(-2);

                while (startDate < DateTime.Now)
                {
                    args = String.Empty;
                    endDate = startDate.AddMonths(1);
                    args = "/TGL:" + startDate.ToString("yyyyMMdd") + CommonHelper.tab +
                           "/TGL2:" + endDate.ToString("yyyyMMdd");


                    args += CommonHelper.tab + CredsHelper.GetCreds();
                    _logger.LogInformation(startDate.ToString("yyyyMMdd"));


                    ProcessHelper isAllprocessHelper = new ProcessHelper(gfa_worker_common.Worker.SalesWorkerExe, args);
                    BaseSales isAllbaseSales = ParseHelper.BaseSalesParser(isAllprocessHelper.Run());
                    for (int a = 0; a < isAllbaseSales.Records.Count; a += 100)
                    {
                        _salesNetwork.Run(isAllbaseSales.Records.Skip(a).Take(100).ToList(), startDate, endDate);
                    }
              
                    startDate = startDate.AddMonths(1);
                }
                return;
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

            ProcessHelper processHelper = new ProcessHelper(gfa_worker_common.Worker.SalesWorkerExe, args);

            BaseSales baseSales = ParseHelper.BaseSalesParser(processHelper.Run());
            for (int a = 0; a < baseSales.Records.Count; a += 100)
            {
                _salesNetwork.Run(baseSales.Records.Skip(a).Take(100).ToList(), startDate, endDate);
            }      
        }
    }
}
