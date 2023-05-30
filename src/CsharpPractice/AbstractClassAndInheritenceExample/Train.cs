using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInheritenceExample
{
    internal class Train : Transport
    {
        public override void StartEngine()
        {
            Console.WriteLine("Stating Train Engine");
            //abstract class er abstract method'k override er maddhome different class e diifferent vabe call kora jai
        }
    }
}
