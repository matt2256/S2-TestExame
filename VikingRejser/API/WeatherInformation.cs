using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class WeatherInformation
    {
        /// <summary>
        /// Represent a public class, used to access coord data from OpemWeatherMap api
        /// </summary>
        public class coord
        {
            //Represent the longitude 
            public double lon { get; set; }

            //Represent the latitude 
            public double lat { get; set; }
        }

        /// <summary>
        /// Represent a public class, used to access weather data from OpenWeatherMap api
        /// </summary>
        public class weather
        {
            //Represent what type the weather is etc. cloods
            public string main { get; set; }
        }

        /// <summary>
        /// Represent a public class, used to access main data form OpenWeatherMap api
        /// </summary>
        public class main
        {
            //Represent what the temperature is 
            public double temp { get; set; }
        }

        public class wind
        {
            public int speed { get; set; }
        }

        public class sys
        {
            public string country { get; set; }
        }

        public class root
        {
            public string name { get; set; }
            public sys sys { get; set; }
            public double dt { get; set; }
            public main main { get; set; }
            public List<weather> Weathers { get; set; }
            public coord coord { get; set; }
        }
    }
}
