using WeatherChecker5000.Models.Common;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace WeatherChecker5000.Models.Forecast
{
    public class Forecast
    {
        public int dt { get; set; } //unix epoch timestamp
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Snow snow { get; set; }

        [JsonIgnore]
        public DateTime dt_cs   //conversion from unix epoch to DateTime
        {
            get
            {
                DateTime dtEpochStart = new DateTime(1970, 1, 1);
                return dtEpochStart.AddSeconds(dt);
            }
        }

        /// <summary>
        /// For binding...from looking at the API doc and sample JSON,
        /// it seems there will ALWAYS be one Weather object returned,
        /// even though a JSON array is being used...
        /// </summary>
        [JsonIgnore]
        public string weather_desc
        {
            get
            {
                try
                {
                    if (weather.Count > 0)
                        return weather[0].description;
                    else
                        return "";
                }
                catch
                {
                    return "";
                }
            }
        }
    }
}
