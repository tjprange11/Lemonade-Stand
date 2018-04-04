using System;
using System.Globalization;
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
        public static void displayRules()
        {
            displayMessage("Introduction :\n");
            displayMessage("You have 7 days to make as much money as possible, and you’ve decided to open a lemonade stand! You’ll have complete \ncontrol over your business, including pricing, quality control, inventory control, and purchasing supplies. Buy your \ningredients, set your recipe, and start selling! The first thing you’ll have to worry about is your recipe. At first, \ngo with the default recipe, but try to experiment a little bit and see if you can find a better one. Make sure you buy \nenough of all your ingredients, or you won’t be able to sell! You’ll also have to deal with the weather, which will \nplay a big part when customers are deciding whether or not to buy your lemonade. Read the weather report every day! \nWhen the temperature drops, or the weather turns bad (overcast, cloudy, rain), don’t expect them to buy nearly as much \nas they would on a hot, hazy day, so buy accordingly. Feel free to set your prices higher on those hot, muggy days too, as you’ll make more profit, even if you sell a bit less lemonade. The other major factor which comes into play is your \ncustomer’s satisfaction. As you sell your lemonade, people will decide how much they like or dislike it. This will make your business more or less popular. If your popularity is low, fewer people will want to buy your lemonade, even if the weather is hot and sunny. But if you’re popularity is high, you’ll do okay, even on a rainy day! At the end of 7 days \nyou’ll see how much money you made.Play again, and try to beat your high score!");
            displayMessage("\nPress Enter to Continue!");
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
        public static void displayWeather(int highTemp, string forecast, int day)
        {
            displayMessage("*************************************************************************");
            displayMessage("Day : " + day);
            displayMessage("The High Temperature :" + highTemp);
            displayMessage("The Forecast : " + forecast);
            displayMessage("*************************************************************************");
        }
        public static void displayWallet(double money)
        {
            Console.WriteLine("You have : " + money.ToString("C", CultureInfo.CurrentCulture));
        }
        public static void endDayReport(double customers, double profit)
        {
            if(profit > 0)
            {
                Console.WriteLine("You made " + profit.ToString("C", CultureInfo.CurrentCulture) + " today!");
            }
            else
            {
                Console.WriteLine("You lost " + profit.ToString("C", CultureInfo.CurrentCulture) + " today!");
            }
            displayMessage("You had " + customers + " customers today!");
        }
        public static void endGameReport(double profit)
        {
            displayMessage("The Game is OVER!!!");
            if (profit > 0)
            {
                Console.WriteLine("You made " + profit.ToString("C", CultureInfo.CurrentCulture) + " over the week!");
            }
            else
            {
                Console.WriteLine("You lost " + profit.ToString("C", CultureInfo.CurrentCulture) + " over the week!");
            }

        }

    }
}
