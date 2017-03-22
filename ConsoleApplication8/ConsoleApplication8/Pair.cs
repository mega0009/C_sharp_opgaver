using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Pair<T>
    {
        public T First { get; private set; }
        public T Second { get; private set; }

        public void Swap()
        {
            T temp = First;
            First = Second;
            Second= temp; 
      
        }

    }

}
