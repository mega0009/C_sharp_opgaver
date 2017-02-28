﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugeopgave2
{
    class Menu
    {
        //private string _MenuTitle;
        private int selected = 0;
        public bool running { get; set; }
        public string MenuTitle;
        MenuItem selected_Item = null;
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
                HandleInput();
                // Console.ReadLine();
            } while (running);



        }
        private void HandleInput()
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
                    // Det valgte item er det element i listen, som er på index seleceted.
                    selected_Item = MenuList[selected];
                    break;
                default:
                    break;
            }
        }

        private void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine(MenuTitle);
            // Laver et for loop, der printer ">", som viser, hvor man befinder sig i menuen, og som printer menu titlen. 
            for (int i = 0; i < MenuList.Count; i++)
            {
                if (i == selected)
                    Console.Write(">");
                Console.WriteLine(MenuList[i].Title);
            }
            // Hvis et MenuItem er valgt, printes dets titel og content. 
            Console.WriteLine();
            if (selected_Item != null)
                Console.WriteLine(selected_Item.Title + " : " + selected_Item.Content);

        }

        // Declaring methods to navigate the menu.
        private void MoveUp()
        {
            selected--;
            // Hvis selected er mindre end 0, der er index for det første element i listen, sættes selected til at være 0.
            if (selected < 0)
                selected = 0;
        }

        private void MoveDown()
        {
            selected++;
            /*Hvis selected er større end eller lig med antallet af elementer i listen, sættes
             *selected lig med antallet af elementer -1, da antallet af elementer er 1 større end den største index værdi. 
             *Dette er fordi index starter fra tallet 0.
             */
            if (selected >= MenuList.Count)
                selected = (MenuList.Count - 1);
            
        }
    }
}
