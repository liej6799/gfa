using gfa_web.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace gfa_web.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(gfa_webEntityFrameworkCoreModule),
        typeof(gfa_webApplicationContractsModule)
        )]
    public class gfa_webDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
