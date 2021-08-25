using System.IO;
using Newtonsoft.Json;
using Org.OpenAPITools.Client;

namespace gfa_worker_common
{
    public static class CommonHelper
    {
        public static string rootPath = "C:\\xampp\\htdocs\\gfakuntansi\\";

        public static string credsPath = rootPath + "creds.json";

        public static char tab = '\t';

        public static Configuration NetworkConfiguration = new (){
            BasePath   = "https://gfaapi.liej6799dev.xyz"
        };
        
        public static void UpdateNetworkConfiguration(string newNetworkConfiguration)
        {
            NetworkConfiguration = new Configuration
            {
                BasePath   = newNetworkConfiguration
            };
        }
        
                
        public static string IsDaily = "IsDaily";
        public static string IsMonthly = "IsMonthly";
        public static string IsYearly = "IsYearly";
        public static string IsAll = "IsAll";
        public static string IsNone = "IsNone";
    }
    
    
}