using System;

namespace Solutions.Kursusgang02.Opgave02
{
    class Opgave02
    {
        public static void Run() // svarer til main
        {
            Person p = 
                new Person("Aryan", 
                    new Person("Mohammad", 
                        new Person("Javad"),
                        new Person("Golijan")
                        ), 
                    new Person("Saeedeh", 
                        new Person("Abdul Qasem "), 
                        new Person("Leyla")
                        )
                    );


            p.PrintTree();
            Console.ReadKey();

            Employee Megalan = new Employee();
            Megalan.Navn = "Megalan";
            //Megalan.EmployeeID = 1;
            Megalan.Print();

            Employee Aryan = new Employee();
            Aryan.Navn = "Aryan";


            Aryan.Print();
            Console.ReadLine();
        }
    }
}