using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Item
    {
        //memeber variables
        int totalNumberOfItem;
        //constructor
        public Item()
        {
            totalNumberOfItem = 0;
        }

        //member methods
        public int TotalNumberOfItem
        {
            get
            {
                return totalNumberOfItem;
            }
            set
            {
                totalNumberOfItem = value;
            }
        }
    }
}
