﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Sugar : Item
    {
        //memeber variables
        int numberOfItemPerPitcher;
        //constructor
        public Sugar() : base()
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
        public bool checkSugar()
        {
            return TotalNumberOfItem > numberOfItemPerPitcher;
        }
    }
}
