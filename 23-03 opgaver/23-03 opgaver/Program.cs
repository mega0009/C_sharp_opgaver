using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_03_opgaver
{
    class Program
    {
        static void Main(string[] args)
        {

            // Making a data source:
            int[] numbers = new int[10] { 5, 10, 15, 35, 27, 3, 38, 42, 40, 2 };
            IEnumerable<int> multiplesOfFive = numbers.Where(x => x % 5 == 0);

            foreach (int item in multiplesOfFive)
            {
                Console.WriteLine("Number: " + item);
            }

            Console.ReadLine();

            int max = 40;
            int min = 20;

            IEnumerable<int> interval = numbers.Where(x => x > min && x < max);

            Console.WriteLine("Tal i intervallet mellem min og max værdien: ");
           

            foreach (int item in interval)
            {
                Console.WriteLine("Number: " + item);
            }

            Console.ReadLine();


            int maximuninterval = interval.Max();

            Console.WriteLine("Max number in interval: " + maximuninterval);

            Console.ReadLine();

            int faktor = 10;
            IEnumerable<int> multiplyNumbers = numbers.Select(x => x * faktor);
           

            Console.WriteLine("Numbers in array multiplied by a factor: ");

            foreach (int item in multiplyNumbers)
            {
                Console.WriteLine("Number: " + item);
            }

            Console.ReadLine();



            /* Delegates, er en parameter til en metode, hvor parameteren også er en metode. 
             * Her bruges query operators fra IEnumerable, der tager et delegate som argument.
             * Dette  gøres for at definere, hvordan der skal filtreres, sorteres eller udføres operationer
               på elementerne i en Collection.
            */

            IEnumerable<int> sortNumbers = numbers.OrderByDescending(x => x);
       
        
            Console.WriteLine("Tallene i arrayet sorteret i omvendt rækkefølge:");
            foreach (int item in sortNumbers)
            {
                Console.WriteLine("Number: " + item);
            }
            Console.ReadLine();

            Console.WriteLine("Kombinere udtryk 2,4 og 5 i et enkelt udtryk");


            IEnumerable<int> combinedMethod = numbers.Where(x => x > min && x < max).Select(x => x * faktor).OrderByDescending(x => x);
            foreach (int item in combinedMethod)
            {
                Console.WriteLine("Nummber: " + item);
            }

            Console.ReadLine();
        }
    }
}
