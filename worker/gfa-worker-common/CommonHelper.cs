using Org.OpenAPITools.Client;

namespace gfa_worker_common
{
    public static class CommonHelper
    {
        public static string rootPath = "C:\\xampp\\htdocs\\gfakuntansi\\";

        public static string credsPath = rootPath + "creds.json";

        public static char tab = '\t';

        public static Configuration NetworkConfiguration = new(){
            BasePath   = "https://gfaapi.liej6799dev.xyz"
        };
        
        public static Configuration LocalNetworkConfiguration = new(){
            BasePath   = "https://localhost:44399"
        };
}
}