using System;
using System.Collections.Generic;
using System.Text;
using gfa_web.Localization;
using Volo.Abp.Application.Services;

namespace gfa_web
{
    /* Inherit your application services from this class.
     */
    public abstract class gfa_webAppService : ApplicationService
    {
        protected gfa_webAppService()
        {
            LocalizationResource = typeof(gfa_webResource);
        }
    }
}
