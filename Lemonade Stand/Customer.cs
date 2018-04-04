using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        //memeber variables
        bool buysLemonade;
        //constructor
        public Customer(double price, int temperature,Random rnd)
        {
            double dif = temperature - (price*100);
            if(rnd.Next(25, 50) <= dif)
            {
                buysLemonade = true;
            }
            else
            {
                buysLemonade = false;
            }
        }
        //member methods
        public bool BuysLemondade
        {
            get
            {
                return buysLemonade;
            }
        }

    }
}
