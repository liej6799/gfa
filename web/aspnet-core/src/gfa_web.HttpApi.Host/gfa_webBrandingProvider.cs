using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace gfa_web
{
    [Dependency(ReplaceServices = true)]
    public class gfa_webBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "gfa_web";
    }
}
