using WeatherChecker5000.Models.CityList;
using WeatherChecker5000.Models.Common;
using WeatherChecker5000.Models.CurrentWeather;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherChecker5000.Models.Forecast
{
    public class objForecast
    {
        public int code { get; set; }
        public int message { get; set; }
        public clsCity city { get; set; }
        public int cnt { get; set; }
        public List<Forecast> list { get; set; }
    }
}
