using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        //memeber variables
        Weather weather;
        double dailyProfit;
        List<Customer> customers;
        //constructor
        public Day()
        {
            weather = new Weather();
            dailyProfit = 0;
            customers = new List<Customer>();
        }
        //member methods
        public List<Customer> Customers
        {
            get
            {
                return customers;
            }
        }
        public void setCustomers(double price)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                customers.Add(new Customer(price, weather.HighTemperature,rnd));
            }
        }
        public Weather Weather
        {
            get
            {
                return weather;
            }
        }
        public double DailyProfit
        {
            get
            {
                return dailyProfit;
            }
            set
            {
                dailyProfit = value;
            }
        }
    }
}
