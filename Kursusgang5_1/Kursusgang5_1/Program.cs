using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursusgang5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> strings = new List<string>() { "Mahmoud", "Mohammad", "Ali", "Farid" };
            int returnValue = strings[0].CompareTo(strings[1]);
            Console.WriteLine("The value is: " + returnValue);
            string tekst = "Salaam";
            foreach (char item in tekst)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
