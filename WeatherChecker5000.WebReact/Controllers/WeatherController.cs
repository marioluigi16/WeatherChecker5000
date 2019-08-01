using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherChecker5000.Managers;
using WeatherChecker5000.Models;
using WeatherChecker5000.Models.CurrentWeather;

namespace WeatherChecker5000.WebReact.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[action]")]
        public async Task<OpenWeatherObj> Current(int id)
        {
            id = 4314388;
            OpenWeatherObj ret = await mgrHTTP.HTTPGet<OpenWeatherObj>("weather", id.ToString());

            return ret;
        }
    }
}