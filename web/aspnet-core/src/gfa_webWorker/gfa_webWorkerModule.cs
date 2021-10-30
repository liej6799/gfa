using System;
using gfa_webWorker.Quantity;
using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Modularity;


namespace gfa_webWorker
{
    
    [DependsOn(
        typeof(AbpBackgroundWorkersModule)
    )]
    public class gfa_webWorkerModule : AbpModule
    {
        
        public override void OnPreApplicationInitialization(ApplicationInitializationContext context)
        {
            context.AddBackgroundWorker<QuantityWorker>();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAuditingOptions>(options =>
            {
                options.EntityHistorySelectors.AddAllEntities();
            });
        }
    }

}