using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
namespace API
{
    class API
    {
        /// <summary>
        /// Represent a method that uses a api for getting data about the weather
        /// </summary>
        /// <param name="_cityName">Represent the input (string) for the city</param>
        public void GetWeatherData(string _cityName, int _key)
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format($"api.openweathermap.org/data/2.5/weather?q={_cityName}&appid={_key}");

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInformation.root>(json);

                WeatherInformation.root output = result;


            }
        }
    }
}
