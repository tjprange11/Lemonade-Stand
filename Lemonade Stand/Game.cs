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
                UserInterface.buyingCupsMenu();
                player.Inventory.Cups += 25;
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
                    player.Inventory.Cups += 25;
                    break;
                case "2":
                    player.Inventory.Cups += 50;
                    break;
                case "3":
                    player.Inventory.Cups += 100;
                    break;
                default:
                    UserInterface.displayMessage("Invalid Entry!");
                    buyCups();
                    break;
            }
        }
        
    }
}
