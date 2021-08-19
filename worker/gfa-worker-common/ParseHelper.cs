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
    }
}