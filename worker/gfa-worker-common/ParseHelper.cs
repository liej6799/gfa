using System;
using System.IO;
using Newtonsoft.Json;

namespace gfa_worker_common
{
    public static class ParseHelper
    {
        public static BaseItem BaseItemParser(string input)
        {
            return JsonConvert.DeserializeObject<BaseItem>(input);
        }
        
        public static BaseItem TestBaseItemParser()
        {
            
            using (StreamReader file = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "BaseItem.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (BaseItem) serializer.Deserialize(file, typeof(BaseItem));
            }
        }
        
        public static BasePurchase BasePurchaseParser(string input)
        {
            return JsonConvert.DeserializeObject<BasePurchase>(input);
        }
        
        public static BasePurchase TestBasePurchaseParser()
        {
            
            using (StreamReader file = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "BasePurchase.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (BasePurchase) serializer.Deserialize(file, typeof(BasePurchase));
            }
        }
        
        public static BaseVendor BaseVendorParser(string input)
        {
            return JsonConvert.DeserializeObject<BaseVendor>(input);
        }
        
        public static BaseVendor TestBaseVendorParser()
        {
            
            using (StreamReader file = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "BaseVendor.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (BaseVendor) serializer.Deserialize(file, typeof(BaseVendor));
            }
        }

        public static BaseSales BaseSalesParser(string input)
        {
            return JsonConvert.DeserializeObject<BaseSales>(input);
        }
        
    }
}