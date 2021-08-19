using gfa_web.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace gfa_web.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class gfa_webController : AbpController
    {
        protected gfa_webController()
        {
            LocalizationResource = typeof(gfa_webResource);
        }
    }
}