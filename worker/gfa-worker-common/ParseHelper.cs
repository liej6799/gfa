using Newtonsoft.Json;

namespace gfa_worker_common
{
    public static class ParseHelper
    {
        public static BaseItem BaseItemParser(string input)
        {
            return JsonConvert.DeserializeObject<BaseItem>(input);
        }
    }
}