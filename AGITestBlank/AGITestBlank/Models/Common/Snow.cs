using Newtonsoft.Json;

namespace AGITestBlank.Models.Common
{
    public class Snow
    {
        [JsonProperty("3h")]
        public double amt3h { get; set; }
    }
}
