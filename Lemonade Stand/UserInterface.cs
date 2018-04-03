using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public static class UserInterface
    {
        public static void displayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void buyingCupsMenu()
        {
            displayMessage("How many cups would you like to buy?");
            displayMessage("1 : 25 cups for $0.94");
            displayMessage("2 : 50 cups for $1.60");
            displayMessage("3 : 100 cups for $3.02");
            displayMessage("Please enter in one of the number or '0' for no cups!");
        }
        public static void buyingLemonMenu()
        {
            displayMessage("How many lemons would you like to buy?");
            displayMessage("1 : 10 lemons for $0.72");
            displayMessage("2 : 30 lemons for $2.11");
            displayMessage("3 : 75 lemons for $4.40");
            displayMessage("Please enter in one of the number or '0' for no lemons!");
        }
        public static void buyingSugarMenu()
        {
            displayMessage("How many cups of sugar would you like to buy?");
            displayMessage("1 : 8 cups of sugar for $0.50");
            displayMessage("2 : 20 cups of sugar for $1.60");
            displayMessage("3 : 48 cups of sugar for $3.44");
            displayMessage("Please enter in one of the number or '0' for no cups of sugar!");
        }
        public static void buyingIceMenu()
        {
            displayMessage("How many ice cubes would you like to buy?");
            displayMessage("1 : 100 ice cubes for $0.80");
            displayMessage("2 : 250 ice cubes for $2.02");
            displayMessage("3 : 500 ice cubes for $3.73");
            displayMessage("Please enter in one of the number or '0' for no ice cubes!");
        }

    }
}
