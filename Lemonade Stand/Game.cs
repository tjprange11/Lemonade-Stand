using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        //memeber variables
        Player player;
        List<Day> week = new List<Day>();
        int pitcher;
        //constructor
        public Game()
        {
            pitcher = 0;
            player = new Player();
        }
        //member methods
        public void playGame()
        {
            UserInterface.displayRules();
            Console.ReadLine();
            Console.Clear();
            int weekLength = 7;
            for (int i = 0; i < weekLength; i++)
            {
                week.Add(new Day());
                UserInterface.displayWeather(week.ElementAt<Day>(i).Weather.HighTemperature, week.ElementAt<Day>(i).Weather.WeatherForecast,i+1);
                week.ElementAt(i).DailyProfit = player.Wallet;
                buyCups();
                buyLemons();
                buySugar();
                buyIce();
                priceQuantity();
                week.ElementAt<Day>(i).setCustomers(player.Inventory.Cups.PricePerCup);
                int dailyCustomers = daySales(week.ElementAt<Day>(i));
                week.ElementAt<Day>(i).DailyProfit = player.Wallet - week.ElementAt<Day>(i).DailyProfit;
                player.TotalProfit += week.ElementAt<Day>(i).DailyProfit;
                player.Inventory.Ice.Melt();
                UserInterface.endDayReport(dailyCustomers, week.ElementAt<Day>(i).DailyProfit);
            }
            UserInterface.endGameReport(player.TotalProfit);
        }
        private void buyCups()
        {
            UserInterface.displayWallet(player.Wallet);
            UserInterface.buyingCupsMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    if (walletValidate(.94))
                    {
                        UserInterface.displayMessage("Successfully bought 25 cups!");
                        player.Inventory.Cups.TotalNumberOfItem += 25;
                        player.Wallet -= .94;
                        buyCups();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buyCups();
                    }
                    break;
                case "2":
                    if (walletValidate(1.60))
                    {
                        UserInterface.displayMessage("Successfully bought 50 cups!");
                        player.Inventory.Cups.TotalNumberOfItem += 50;
                        player.Wallet -= 1.60;
                        buyCups();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buyCups();
                    }
                    break;
                case "3":
                    if (walletValidate(3.02))
                    {
                        UserInterface.displayMessage("Successfully bought 100 cups!");
                        player.Inventory.Cups.TotalNumberOfItem += 100;
                        player.Wallet -= 3.02;
                        buyCups();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buyCups();
                    }
                    break;
                default:
                    UserInterface.displayMessage("Invalid Entry!");
                    buyCups();
                    break;
            }
        }
        private void buyLemons()
        {
            UserInterface.displayWallet(player.Wallet);
            UserInterface.buyingLemonMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    if (walletValidate(.72))
                    {
                        UserInterface.displayMessage("Successfully bought 10 Lemons!");
                        player.Inventory.Lemons.TotalNumberOfItem += 10;
                        player.Wallet -= .72;
                        buyLemons();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buyLemons();
                    }
                    break;
                case "2":
                    if (walletValidate(2.11))
                    {
                        UserInterface.displayMessage("Successfully bought 30 Lemons!");
                        player.Inventory.Lemons.TotalNumberOfItem += 30;
                        player.Wallet -= 2.11;
                        buyLemons();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buyLemons();
                    }
                    break;
                case "3":
                    if (walletValidate(4.40))
                    {
                        UserInterface.displayMessage("Successfully bought 75 Lemons!");
                        player.Inventory.Lemons.TotalNumberOfItem += 75;
                        player.Wallet -= 4.40;
                        buyLemons();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buyLemons();
                    }
                    break;
                default:
                    UserInterface.displayMessage("Invalid Entry!");
                    buyLemons();
                    break;
            }
        }
        private void buySugar()
        {
            UserInterface.displayWallet(player.Wallet);
            UserInterface.buyingSugarMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    if (walletValidate(.5))
                    {
                        UserInterface.displayMessage("Successfully bought 8 cups of Sugar!");
                        player.Inventory.Sugar.TotalNumberOfItem += 8;
                        player.Wallet -= .5;
                        buySugar();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buySugar();
                    }
                    break;
                case "2":
                    if (walletValidate(1.60))
                    {
                        UserInterface.displayMessage("Successfully bought 20 cups of Sugar!");
                        player.Inventory.Sugar.TotalNumberOfItem += 20;
                        player.Wallet -= 1.60;
                        buySugar();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buySugar();
                    }
                    break;
                case "3":
                    if (walletValidate(3.44))
                    {
                        UserInterface.displayMessage("Successfully bought 48 cups of Sugar!");
                        player.Inventory.Sugar.TotalNumberOfItem += 48;
                        player.Wallet -= 3.44;
                        buySugar();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buySugar();
                    }
                    break;
                default:
                    UserInterface.displayMessage("Invalid Entry!");
                    buySugar();
                    break;
            }
        }
        private void buyIce()
        {
            UserInterface.displayWallet(player.Wallet);
            UserInterface.buyingIceMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    if (walletValidate(.8))
                    {
                        UserInterface.displayMessage("Successfully bought 100 ice cubes!");
                        player.Inventory.Ice.TotalNumberOfItem += 100;
                        player.Wallet -= .8;
                        buyIce();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buyIce();
                    }
                    break;
                case "2":
                    if (walletValidate(2.02))
                    {
                        UserInterface.displayMessage("Successfully bought 250 ice cubes!");
                        player.Inventory.Ice.TotalNumberOfItem += 250;
                        player.Wallet -= 2.02;
                        buyIce();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buyIce();
                    }
                    break;
                case "3":
                    if (walletValidate(3.73))
                    {
                        UserInterface.displayMessage("Successfully bought 500 ice cubes!");
                        player.Inventory.Ice.TotalNumberOfItem += 500;
                        player.Wallet -= 3.73;
                        buyIce();
                    }
                    else
                    {
                        UserInterface.displayMessage("Inefficient funds!");
                        buyIce();
                    }
                    break;
                default:
                    UserInterface.displayMessage("Invalid Entry!");
                    buyIce();
                    break;
            }
        }
        private void priceQuantity()
        {
            UserInterface.displayMessage("How many cents would you like to sell your lemonade for?");
            string input = Console.ReadLine();
            while (!numValidate(input))
            {
                UserInterface.displayMessage("Invalid Entry!");
                UserInterface.displayMessage("How many cents would you like to sell your lemonade for?");
                input = Console.ReadLine();
            }
            player.Inventory.Cups.PricePerCup = double.Parse(input) / 100;

            UserInterface.displayMessage("How many lemons would you like to put in each pitcher?");
            input = Console.ReadLine();
            while (!numValidate(input))
            {
                UserInterface.displayMessage("Invalid Entry!");
                UserInterface.displayMessage("How many lemons would you like to put in each pitcher?");
                input = Console.ReadLine();
            }
            player.Inventory.Lemons.NumberOfItemPerPitcher = Int32.Parse(input);

            UserInterface.displayMessage("How many cups of sugar would you like to put in each pitcher?");
            input = Console.ReadLine();
            while (!numValidate(input))
            {
                UserInterface.displayMessage("Invalid Entry!");
                UserInterface.displayMessage("How many cups of sugar would you like to put in each pitcher?");
                input = Console.ReadLine();
            }
            player.Inventory.Sugar.NumberOfItemPerPitcher = Int32.Parse(input);

            UserInterface.displayMessage("How many ice cubes would you like to put in each cup?");
            input = Console.ReadLine();
            while (!numValidate(input))
            {
                UserInterface.displayMessage("Invalid Entry!");
                UserInterface.displayMessage("How many ice cubes would you like to put in each cup?");
                input = Console.ReadLine();
            }
            player.Inventory.Ice.NumberOfItemPerCup = Int32.Parse(input);

        }
        private bool numValidate(string num)
        {
            int result;
            return Int32.TryParse(num, out result);

        }
        private bool walletValidate(double num)
        {
            if(player.Wallet > num)
            {
                return true;
            }
            return false;
        }
        private int daySales(Day day)
        {
            int count = 0;
            for (int i = 0;i < day.Customers.Count; i++)
            {
                if (day.Customers.ElementAt<Customer>(i).BuysLemondade)
                {
                    if (player.Inventory.Cups.checkCups())
                    {
                        if (player.Inventory.Ice.checkIce())
                        {
                            if (checkPitcher())
                            {
                                count++;
                                player.Wallet += player.Inventory.Cups.PricePerCup;
                                player.Inventory.Cups.TotalNumberOfItem--;
                                player.Inventory.Ice.TotalNumberOfItem -= player.Inventory.Ice.NumberOfItemPerCup;
                                pitcher--;
                            }
                        }
                    }
                }
            }
            return count;
        }
        private bool checkPitcher()
        {
            if (pitcher == 0)
            {
                if(player.Inventory.Lemons.checkLemons())
                {
                    if(player.Inventory.Sugar.checkSugar())
                    {
                        player.Inventory.Lemons.TotalNumberOfItem -= player.Inventory.Lemons.NumberOfItemPerPitcher;
                        player.Inventory.Sugar.TotalNumberOfItem -= player.Inventory.Sugar.NumberOfItemPerPitcher;
                        pitcher = 15;
                        return true;
                    }
                }
                
            }
            else
            {
                return true;
            }
            return false;
        }

    }
}
