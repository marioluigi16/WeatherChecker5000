using AGITestBlank.Models.CityList;
using AGITestBlank.Models.Common;
using AGITestBlank.Models.CurrentWeather;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGITestBlank.Models.Forecast
{
    public class objForecast
    {
        public int code { get; set; }
        public string message { get; set; }
        public clsCity city { get; set; }
        public int cnt { get; set; }
        public List<Forecast> list { get; set; }
    }
}
