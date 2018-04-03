﻿using System;
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
                UserInterface.buyingLemonMenu();
                UserInterface.buyingSugarMenu();
                UserInterface.buyingIceMenu();
            }
        }
        public void buyCups()
        {
            UserInterface.buyingCupsMenu();
            string input = Console.ReadLine();
            switch (input)
            {
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

    }
}
