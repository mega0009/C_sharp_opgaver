using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kursusgang02.Opgave02
{
   class Employee : Person
    {


        public int EmployeeID  { get; set; }
       
        

        public Employee ()
        {
            EmployeeID++;
        }

       public override void Print()
        {
            Console.WriteLine(Navn + " Employee ID: " + EmployeeID);
            
        }

    }
}
