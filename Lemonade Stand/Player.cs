using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        //memeber variables
        Inventory inventory;
        double wallet;
        //constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = 20;
        }

        //member methods
        public Inventory Inventory
        {
            get
            {
                return inventory;
            }
        }
        public double Wallet
        {
            get
            {
                return wallet;
            }
            set
            {
                wallet = value;
            }
        }
    }
}
