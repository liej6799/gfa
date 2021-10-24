using System.Globalization;
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
            //BasePath   = "https://gfaapi.liej6799dev.xyz"
            BasePath = "https://localhost:44399"
        };
        
        public static void UpdateNetworkConfiguration(string newNetworkConfiguration)
        {
            NetworkConfiguration = new Configuration
            {
                BasePath   = newNetworkConfiguration
            };
        }
        
        public static string YMDHMSDateFormat = "yyyy-MM-dd HH:mm:ss";
        
        public static CultureInfo DateProvider = CultureInfo.InvariantCulture;
    }
}