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
        
        public GfaWebConfigsConfigDto Run(string workerName)
        {
            var data = _configApi.ApiAppConfigGet().Items;
            return  _configApi.ApiAppConfigGet().Items.FirstOrDefault(x => x.Name.Equals(workerName));
        }
    }
}