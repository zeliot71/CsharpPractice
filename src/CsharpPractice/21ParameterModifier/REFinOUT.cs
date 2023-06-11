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

        internal void Something2(in int a)
        {
            //In: er value kokhono set kora jabena only use/read kora jabe
            Console.WriteLine(a);
        }

        internal void Something3(out int a) 
        {
            
            //Out: er bepar ulta, set kortei hobe nahole error dibe! & print/read kora jabena
            a = 52;

        }
    }
}
