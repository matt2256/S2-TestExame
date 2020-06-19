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
        public void GetWeatherData(string _cityName, int _key, object _weatherType, object _temp, object _windSpeed, object _countryName )
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format($"api.openweathermap.org/data/2.5/weather?q={_cityName}&appid={_key}");

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInformation.root>(json);

                WeatherInformation.root output = result;

                //main(WeatherType) = weather.main
                _weatherType = string.Format("{0}", output.weather.main);
                //temp(Temperature) = main.temp
                _temp = string.Format("{0}", output.main.temp);
                //speed(WindSpeed) = wind.speed
                _windSpeed = string.Format("{0}", output.wind.speed);
                //country(CountryName) = sys.country
                _countryName = string.Format("{0}", output.sys.country);
            }
        }
    }
}
