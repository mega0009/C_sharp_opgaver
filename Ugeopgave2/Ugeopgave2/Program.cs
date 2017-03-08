using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugeopgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laver en instans a menu klassen kaldet MenuProgram. 
            /* Menu MenuProgram = new Menu("Dette er den nye menu");

             // Tilføjer MenuItems til MenuProgram.
             MenuProgram.AddMenuItem(new MenuItem("Punkt 1", "Dette er det første punkt"));
             MenuProgram.AddMenuItem(new MenuItem("Punkt 2", "Dette er det andet punkt"));
             MenuProgram.AddMenuItem(new MenuItem("Punkt 3", "Dette er det tredje punkt"));
             MenuProgram.AddMenuItem(new MenuItem("Punkt 4", "Dette er det fjerde punkt"));

             MenuProgram.start();*/

            Menu menu = new Menu("FancyMenu");
            menu.AddMenuItem(new MenuItem("Punkt1", "Dette er punkt 1"));
            menu.AddMenuItem(new MenuItem("Punkt2", "Dette er punkt 2"));
            Menu underMenu = new Menu("undermenu");
            underMenu.AddMenuItem(new MenuItem("testpunkt", "Dette er et testpunkt"));
            underMenu.AddMenuItem(new MenuItem("testpunkt2", "Dette er et andet testpunkt"));
            menu.AddMenuItem(underMenu);
            menu.start();

        }
    }
}
