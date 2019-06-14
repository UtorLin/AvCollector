using Newtonsoft.Json;

namespace Util.Helper
{
    public class JsonHelper
    {

        public static T Deserialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }

        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(
                obj,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
        }
    }
}