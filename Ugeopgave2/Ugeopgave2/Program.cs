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
            Menu MenuProgram = new Menu("Dette er den nye menu");


            MenuProgram.AddMenuItem(new MenuItem("Punkt 1", "Dette er det første punkt"));
            MenuProgram.AddMenuItem(new MenuItem("Punkt 2", "Dette er det andet punkt"));
            MenuProgram.AddMenuItem(new MenuItem("Punkt 3", "Dette er det tredje punkt"));
            MenuProgram.AddMenuItem(new MenuItem("Punkt 4", "Dette er det fjerde punkt"));

            MenuProgram.start();

        }
    }
}
