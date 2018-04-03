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
        int cups;
        Lemon lemons;
        Sugar sugar;
        Ice ice;
        //constructor

        //member methods
        public int Cups
        {
            get
            {
                return cups;
            }
            set
            {
                cups = value;
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
