using gfa_web.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace gfa_web
{
    [DependsOn(
        typeof(gfa_webEntityFrameworkCoreTestModule)
        )]
    public class gfa_webDomainTestModule : AbpModule
    {

    }
}