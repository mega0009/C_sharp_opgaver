using System;

namespace Solutions.Kursusgang02.Opgave06
{
    class EksempelKlasse
    {
        public int IntVariabel { get; set; }
        public string StringVariabel { get; set; }
    }

    class Opgave06
    {
        public static void Run()
        {
            int a = 1;
            int b = 1;
            Console.WriteLine($"resultat af a == b: {a == b}");

            EksempelKlasse o1 = new EksempelKlasse() {IntVariabel = 3, StringVariabel = "test"};
            EksempelKlasse o2 = new EksempelKlasse() {IntVariabel = 3, StringVariabel = "test" };
            Console.WriteLine($"resultat af o1 == o2: {o1 == o2}");

            // et andet eksempel der giver det omvendte resultat
            Console.WriteLine("omvendt");
            a = b;
            o1 = o2;

            a = 3;
            Console.WriteLine($"resultat af a == b: {a == b}");
            o1.IntVariabel = 10;
            Console.WriteLine($"resultat af o1 == o2: {o1 == o2}");

            Console.ReadKey();
        }
    }
}
