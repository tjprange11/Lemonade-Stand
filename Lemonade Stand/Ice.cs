﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Ice : Item
    {
        //memeber variables
        int numberOfItemPerCup;
        //constructor
        public Ice() : base()
        {
            numberOfItemPerCup = 0;

        }

        //member methods
        public int NumberOfItemPerCup
        {
            get
            {
                return numberOfItemPerCup;
            }
            set
            {
                numberOfItemPerCup = value;
            }
        }
        public void Melt()
        {
            UserInterface.displayMessage("The remaining ice melted!");
            TotalNumberOfItem = 0;
        }
        public bool checkIce()
        {
            return TotalNumberOfItem > numberOfItemPerCup;
        }
    }
}
