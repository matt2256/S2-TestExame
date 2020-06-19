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

        /// <summary>
        /// Represent a public class,  used to access wind data form OpenWeatherMap api
        /// </summary>
        public class wind
        {
            //Represent the wind speed
            public int speed { get; set; }
        }

        /// <summary>
        /// Represent a public class, used to access country specifik data form OpenWeatherMap api
        /// </summary>
        public class sys
        {
            //Represent thge country name 
            public string country { get; set; }
        }

        /// <summary>
        /// Represent a public class, used for main control of all the classes above 4
        /// </summary>
        public class root
        {
            public weather weather { get; set; }
            public sys sys { get; set; }
            public double dt { get; set; }
            public main main { get; set; }
            public List<weather> Weathers { get; set; }
            public coord coord { get; set; }
            public wind wind { get; set; }
        }
    }
}
