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
        /// Represent a method for retriving weather data form OpenWeatherMap´s api
        /// </summary>
        /// <param name="_cityName">Represent the input name (string) of the city</param>
        /// <param name="_key">Represent the API key (string)used for authentication on OpenWeatherMap.com</param>
        /// <param name="_weatherType">Represent the parameter (object) used to parse the weather type </param>
        /// <param name="_temp">Represent the parameter (object) used to parse the temperature </param>
        /// <param name="_windSpeed">Represent the parameter (object) used to parse the windspeed</param>
        /// <param name="_countryName">Represent the parameter (object) used to parse the county name </param>
        public void GetWeatherData(string _cityName, string _key, object _weatherType, object _temp, object _windSpeed, object _countryName )
        {
            using(WebClient web = new WebClient())
            {
                //Represent url being formatted to a string 
                string url = string.Format($"api.openweathermap.org/data/2.5/weather?q={_cityName}&appid={_key}");

                //Represent a json variable set to download a web string called url 
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
