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
        public Lemon() : base()
        {
            numberOfItemPerPitcher = 0;
        }
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
        public bool checkLemons()
        {
            return TotalNumberOfItem > numberOfItemPerPitcher;
        }
    }
}
