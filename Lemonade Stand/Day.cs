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
            for(int i = 0;i < 100;i++)
            {
                customers.Add(new Customer());
            }
        }
        //member methods
    }
}
