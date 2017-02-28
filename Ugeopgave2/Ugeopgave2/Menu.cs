using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugeopgave2
{
    class Menu
    {
        //private string _MenuTitle;
        public bool running { get; set; }
        public string MenuTitle;
        // Skal lave en Menu som en list. 
        List<MenuItem> MenuList = new List<MenuItem>();


        // Laver en constructer til menutitle. 
        public Menu(string menutitle)
        {
            MenuTitle = menutitle;
        }


        // AddMenuItem tager en MenuItem som parameter
        public void AddMenuItem(MenuItem itemInput)
        {
            MenuList.Add(itemInput);
        }

        public void start()
        {
            running = true;
            do
            {
                DrawMenu();
                //HandleInput();
                running = false;
                Console.ReadLine();
            } while (running);



        }
        /* private void HandleInput()
         {
             ConsoleKeyInfo cki = Console.ReadKey();
             switch (cki.Key)
             {
                 case ConsoleKey.Backspace:
                 case ConsoleKey.Escape:
                     running = false;
                     break;
                 case ConsoleKey.UpArrow:
                     MoveUp();
                     break;
                 case ConsoleKey.DownArrow:
                     MoveDown();
                     break;
                 case ConsoleKey.Enter:
                     GetSelectedMenuItem().Select();
                     break;
                 default:
                     break;
             }
         }*/

        private void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine(MenuTitle);
            foreach (MenuItem Item in MenuList)
            {
                Console.WriteLine(Item.Title);
                Console.WriteLine(Item.Content);
            }
        }

        // Declaring methods to navigate the menu.
        private void MoveUp()
        {

        }
    }
}
