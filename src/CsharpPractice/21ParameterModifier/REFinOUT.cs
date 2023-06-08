using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ParameterModifier
{
    internal class REFinOUT
    {
        internal void Something(ref int a)
        {
            //Ref: eta asole refferance type er moto kaj kore
            //value type keo refferance type er convert kore
            Console.WriteLine(a);
            a = 5;
        }

    }
}
