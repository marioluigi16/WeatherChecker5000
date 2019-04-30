using WeatherChecker5000.Models.Forecast;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherChecker5000.ViewModels
{
    class ForecastPageViewModel : ViewModelBase
    {
        private int cityID;

        public ForecastPageViewModel(int cityID, objForecast obj)
        {
            this.cityID = cityID;
            _forecast_GET = obj;
        }

        private objForecast _forecast_GET;
        public objForecast forecast_GET
        {
            get
            {
                /*
                if (_forecast_GET == null)
                {
                    _forecast_GET = Managers.mgrHTTP.HTTPGet<objForecast>("forecast", cityID.ToString()).Result;
                }
                */
                return _forecast_GET;
            }
        }

        public List<Forecast> lstForecast { get { return forecast_GET.list; } }
    }
}
