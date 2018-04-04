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
        public Customer(double price, int temperature)
        {
            double dif = temperature - price;
            Random rnd = new Random();
            int random = rnd.Next(25,50);
            if(random >= dif)
            {
                buysLemonade = true;
            }
        }
        //member methods

    }
}
