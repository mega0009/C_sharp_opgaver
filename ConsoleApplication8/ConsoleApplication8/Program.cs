using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            HandyMethods numberTest = new HandyMethods();
            int min = numberTest.Min(250, 5, 10, 35, 2);
            Console.WriteLine("The minumum number is: " + min);
            Console.ReadLine();
            int max = numberTest.Max(350, 450, 320, 10);
            Console.WriteLine("The maximum number is: " + max);
            Console.ReadLine();
            
        }
    }
}
