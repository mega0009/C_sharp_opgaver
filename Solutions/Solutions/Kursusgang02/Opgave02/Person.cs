using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kursusgang02.Opgave02
{
    class Person
    {
        public Person(string navn) : this(navn, null, null)
        {}


       public Person() { }

        public Person(string navn, Person far, Person mor)
        {
            this.Navn = navn;
            this.Far = far;
            this.Mor = mor;
            Console.WriteLine("jeg har lavet en instant af person, navn: " +Navn+ " id er: " + this.Id);
        }
        
        public virtual void Print()
        {
            Console.WriteLine(this.Navn);
        }

        public void PrintTree()
        {
            Print();
            if (Far != null)
                Far.PrintTree();
            if (Mor != null)
                Mor.PrintTree();
        }

        public string Navn { get; set; }
        public string Efternavn { get; set; }
        public int Alder { get; set; }
        public Person Far { get; set; }
        public Person Mor { get; set; }

        public readonly int Id = _nextID++;
        private static int _nextID = 1;
    
       

    }
}
