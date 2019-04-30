using AGITestBlank.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGITestBlank.Models.CurrentWeather
{
    public class OpenWeatherObj
    {
        public Coord coord { get; set; }
        public IList<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}
