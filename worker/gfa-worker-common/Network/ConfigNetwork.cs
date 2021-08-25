using System.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace gfa_worker_common.Network
{
    public class ConfigNetwork
    {
        private readonly ConfigApi _configApi;
        
        public ConfigNetwork()
        {
            _configApi = new ConfigApi(CommonHelper.NetworkConfiguration);
        }
        
        public string Run(string workerName)
        {
            var result =  _configApi.ApiAppConfigGet().Items.FirstOrDefault(x => x.Name.Equals(workerName));

            if (result != null)
            {
                if (result.IsAll)
                {
                    return CommonHelper.IsAll;
                }
                else if (result.IsDaily)
                {
                    return CommonHelper.IsDaily;
                }
                else if (result.IsMonthly)
                {
                    return CommonHelper.IsMonthly;
                }
                else if (result.IsYearly)
                {
                    return CommonHelper.IsYearly;
                }
            }
            return CommonHelper.IsNone;
        }
    }
}