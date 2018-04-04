using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        //memeber variables
        Cup cups;
        Lemon lemons;
        Sugar sugar;
        Ice ice;
        //constructor
        public Inventory()
        {
            cups = new Cup();
            lemons = new Lemon();
            sugar = new Sugar();
            ice = new Ice();
        }

        //member methods
        public Cup Cups
        {
            get
            {
                return cups;
            }
        }
        public Lemon Lemons
        {
            get
            {
                return lemons;
            }
        }
        public Sugar Sugar
        {
            get
            {
                return sugar;
            }
        }
        public Ice Ice
        {
            get
            {
                return ice;
            }
        }
    }
}
