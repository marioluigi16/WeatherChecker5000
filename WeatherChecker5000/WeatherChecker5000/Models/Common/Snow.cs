using Newtonsoft.Json;

namespace WeatherChecker5000.Models.Common
{
    public class Snow
    {
        [JsonProperty("3h")]
        public double amt3h { get; set; }
    }
}
