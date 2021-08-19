using Volo.Abp.Modularity;

namespace gfa_web
{
    [DependsOn(
        typeof(gfa_webApplicationModule),
        typeof(gfa_webDomainTestModule)
        )]
    public class gfa_webApplicationTestModule : AbpModule
    {

    }
}