using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class HandyMethods
    {
        public T Min <T>(params T [] variables) where T : IComparable
        {
            if (variables.Length > 0)
                return variables.Min<T>();
            else
                return default(T);

        }

        public T Max<T>(params T[] variables) where T : IComparable
        {
            if (variables.Length > 0)
                return variables.Max<T>();
            else
                return default(T);


        }
    }
}
