using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherChecker5000.Managers
{
    public static class MgrHTTP
    {
        private const string API_BASIC_URL = "http://api.openweathermap.org/data/2.5/";
        private const string API_KEY = "&APPID=e4199d515d663e6fc93f7179635e361e";

        public static async Task<T> HTTPGet<T>(string route, string cityID)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string uri = API_BASIC_URL
                        + route
                        + "?id=" + cityID
                        + API_KEY
                        + "&units=" + GetAPIMeasurementUnit();
                    HttpResponseMessage response = await client.GetAsync(uri);
                    response.EnsureSuccessStatusCode();

                    string json = Encoding.UTF8.GetString(response.Content.ReadAsByteArrayAsync().Result);
                    return JsonSerializer.Deserialize<T>(json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return default;
            }
        }

        public static async Task<T> HTTPGet<T>(string route, int cityID)
        {
            return await HTTPGet<T>(route, cityID.ToString());
        }

        private static string GetAPIMeasurementUnit()
        {
            try
            {
                switch (mgrMeasurementUnits.g_MeasurementUnit)
                {
                    case "F":
                        return "imperial";
                    case "C":
                        return "metric";
                    case "K":
                        return "kelvin";
                    default:    //shouldn't reach here, but just in case..
                        return "imperial";
                }
            }
            catch
            {
                return "imperial";
            }
        }

        public static async Task HTTPDownloadFile(string url, string fileName)
        {
            using (WebClient client = new WebClient())
            {
                await client.DownloadFileTaskAsync(url, Environment.CurrentDirectory + @"\Assets\" + fileName);
            }
        }

        public static async Task<bool> HTTPPost(TestThing obj)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string uri = "https://postman-echo.com/post";
                    string json = JsonSerializer.Serialize(obj);
                    HttpContent content = new StringContent(json);
                    HttpResponseMessage response = await client.PostAsync(uri, content);
                    response.EnsureSuccessStatusCode();

                    string jsonResult = Encoding.UTF8.GetString(response.Content.ReadAsByteArrayAsync().Result);
                    Debug.Print(jsonResult);
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        
    }

    public class TestThing
    {
        public string Foo1 { get; set; }
        public string Foo2 { get; set; }
    }
}
