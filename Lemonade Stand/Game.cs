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
        //constructor
        public Game()
        {
            for(int i = 0; i < 7;i++)
            {
                week.Add(new Day());
            }
        }
        //member methods
        public void playGame()
        {
            UserInterface.displayRules();
            for (int i = 0; i < week.Count; i++)
            {
                buyCups();
                buyLemons();
                buySugar();
                buyIce();
            }
        }
        public void buyCups()
        {
            UserInterface.buyingCupsMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    player.Inventory.Cups.TotalNumberOfItem += 25;
                    break;
                case "2":
                    player.Inventory.Cups.TotalNumberOfItem += 50;
                    break;
                case "3":
                    player.Inventory.Cups.TotalNumberOfItem += 100;
                    break;
                default:
                    UserInterface.displayMessage("Invalid Entry!");
                    buyCups();
                    break;
            }
        }
        public void buyLemons()
        {
            UserInterface.buyingLemonMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    player.Inventory.Lemons.TotalNumberOfItem += 10;
                    break;
                case "2":
                    player.Inventory.Lemons.TotalNumberOfItem += 30;
                    break;
                case "3":
                    player.Inventory.Lemons.TotalNumberOfItem += 75;
                    break;
                default:
                    UserInterface.displayMessage("Invalid Entry!");
                    buyLemons();
                    break;
            }
        }
        public void buySugar()
        {
            UserInterface.buyingSugarMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    player.Inventory.Sugar.TotalNumberOfItem += 8;
                    break;
                case "2":
                    player.Inventory.Sugar.TotalNumberOfItem += 20;
                    break;
                case "3":
                    player.Inventory.Sugar.TotalNumberOfItem += 48;
                    break;
                default:
                    UserInterface.displayMessage("Invalid Entry!");
                    buySugar();
                    break;
            }
        }
        public void buyIce()
        {
            UserInterface.buyingIceMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    player.Inventory.Ice.TotalNumberOfItem += 100;
                    break;
                case "2":
                    player.Inventory.Ice.TotalNumberOfItem += 250;
                    break;
                case "3":
                    player.Inventory.Ice.TotalNumberOfItem += 500;
                    break;
                default:
                    UserInterface.displayMessage("Invalid Entry!");
                    buyIce();
                    break;
            }
        }
        public void priceQuantity()
        {
            UserInterface.displayMessage("How many cents would you like to sell your lemonade for?");
            string input = Console.ReadLine();
            while (numValidate(input))
            {
                UserInterface.displayMessage("Invalid Entry!");
                UserInterface.displayMessage("How many cents would you like to sell your lemonade for?");
                input = Console.ReadLine();
            }
            // variable for price

            UserInterface.displayMessage("How many lemons would you like to put in each pitcher?");
            input = Console.ReadLine();
            while (numValidate(input))
            {
                UserInterface.displayMessage("Invalid Entry!");
                UserInterface.displayMessage("How many lemons would you like to put in each pitcher?");
                input = Console.ReadLine();
            }
            player.Inventory.Lemons.NumberOfItemPerPitcher = Int32.Parse(input);

            UserInterface.displayMessage("How many cups of sugar would you like to put in each pitcher?");
            input = Console.ReadLine();
            while (numValidate(input))
            {
                UserInterface.displayMessage("Invalid Entry!");
                UserInterface.displayMessage("How many cups of sugar would you like to put in each pitcher?");
                input = Console.ReadLine();
            }
            player.Inventory.Sugar.NumberOfItemPerPitcher = Int32.Parse(input);

            UserInterface.displayMessage("How many ice cubes would you like to put in each cup?");
            input = Console.ReadLine();
            while (numValidate(input))
            {
                UserInterface.displayMessage("Invalid Entry!");
                UserInterface.displayMessage("How many ice cubes would you like to put in each cup?");
                input = Console.ReadLine();
            }
            player.Inventory.Ice.NumberOfItemPerCup = Int32.Parse(input);

        }
        public bool numValidate(string num)
        {
            int result;
            return Int32.TryParse(num, out result);

        }

    }
}
