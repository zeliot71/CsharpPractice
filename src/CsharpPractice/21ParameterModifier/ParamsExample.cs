using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ParameterModifier
{
    
    internal class ParamsExample
    {
        public int sum(int a, int b)
        {
            return a+ b;
        }

        public int sum(params int[] a)
        {
            int sUm = 0;    
            foreach(var i in a)
            {
                sUm += i;
            }
            return sUm;
        }
    }
}
