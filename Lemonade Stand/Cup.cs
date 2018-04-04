using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Cup : Item
    {
        //memeber variables
        double pricePerCup;
        //constructor
        public Cup() : base()
        {
            pricePerCup = 0;
        }
        //member methods
        public double PricePerCup
        {
            get
            {
                return pricePerCup;
            }
            set
            {
                pricePerCup = value;
            }
        }
        public bool checkCups()
        {
            return TotalNumberOfItem > 0;
        }
    }
}
