using Newtonsoft.Json;

namespace AGITestBlank.Models.Common
{
    public class Rain
    {
        [JsonProperty("3h")]
        public double amt3h { get; set; }
    }
}
