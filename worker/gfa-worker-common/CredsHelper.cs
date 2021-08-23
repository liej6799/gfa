using System;
using System.IO;
using Newtonsoft.Json;

namespace gfa_worker_common
{
    public static class CredsHelper
    {
        public static string GetCreds()
        {
            string result = String.Empty;
            using (StreamReader file = File.OpenText(CommonHelper.credsPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                Creds creds = (Creds)serializer.Deserialize(file, typeof(Creds));
                if (creds != null)
                {
                    // Convert creds Password to 
                    creds.asciiPassword = string.Empty;
                    CommonHelper.UpdateNetworkConfiguration(creds.networkConfigurationBasePath);
              
                    for (int i = 0; i < creds.password.Length; i++)
                    {
                        creds.asciiPassword += System.Text.Encoding.ASCII.GetBytes(creds.password.Substring(i, 1))[0]
                            .ToString() + ',';
                    }
                    
                    result = "/U:" + creds.username + CommonHelper.tab + "/P:" + creds.asciiPassword;
                }
            }
            
            return result;
        }
    }
}