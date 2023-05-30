using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInheritenceExample
{
    internal class Bus : Transport
    {

        public override void StartEngine()
        {
            Console.WriteLine("Starting Bus Engine");
            //abstract class er abstract method'k override er maddhome different class e diifferent vabe call kora jai
        }
    }
}
