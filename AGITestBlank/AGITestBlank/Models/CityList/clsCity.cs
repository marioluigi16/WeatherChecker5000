using AGITestBlank.Models.Common;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGITestBlank.Models.CityList
{
    public class clsCity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public Coord coord { get; set; }
    }

    public static class clsCityList
    {
        private static List<clsCity> _lstCity;

        public static List<clsCity> lstCity
        {
            get
            {
                if (_lstCity == null)
                    _lstCity = GetCities();

                return _lstCity;
            }
        }

        public static List<clsCity> GetCities()
        {
            //read in the resource file saved in the base project
            var cities = Properties.Resources.city_list;

            //encode the byte array into a readable string
            string strJson = Encoding.UTF8.GetString(cities);

            List<clsCity> ret = JsonConvert.DeserializeObject<List<clsCity>>(strJson);
            ret = RemoveDuplicateCityNames(ret);
            return ret;
        }

        public static List<string> GetCountries()
        {
            return lstCity.GroupBy(x => x.country)
                .Select(g => g.First().country)
                .OrderBy(o => o)
                .ToList();
        }

        public static List<clsCity> RemoveDuplicateCityNames(List<clsCity> lst)
        {
            //OpenWeatherMap does not group cities by US State...only country.
            //  for the sake of this demo, I'm gonna only display unique cities.
            return lst.GroupBy(x => x.name)
                .Select(g => g.First())
                .OrderBy(o => o.name)
                .ToList();
        }
    }
}
