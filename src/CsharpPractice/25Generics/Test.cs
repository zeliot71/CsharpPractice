using _26OperatorOverloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Generics
{
    public class Test<T> where T: Fraction
    {
        public T Add(T a,T b)
        {
            return (a + b) as T;
        }
    }
}
