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
        }
        //member methods
    }
}
