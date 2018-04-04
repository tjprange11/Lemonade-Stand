using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        //memeber variables
        int highTemperature;
        string weatherForecast;
        //constructor
        public Weather()
        {
            Random rnd = new Random();
            highTemperature = rnd.Next(50, 100);
            List<string> weather = new List<string>() { "overcast", "cloudy", "rainy", "sunny", "cloudy and sunny", "hazy" };
            weatherForecast = weather.ElementAt<string>(rnd.Next(0, weather.Count - 1));
        }
        //member methods
        public int HighTemperature
        {
            get
            {
                return highTemperature;
            }
        }
        public string WeatherForecast
        {
            get
            {
                return weatherForecast;
            }
        }

    }
}
