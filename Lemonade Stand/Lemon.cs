using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Lemon : Item
    {
        //memeber variables
        int numberOfItemPerPitcher;
        //constructor

        //member methods
        public int NumberOfItemPerPitcher
        {
            get
            {
                return numberOfItemPerPitcher;
            }
            set
            {
                numberOfItemPerPitcher = value;
            }
        }
    }
}
