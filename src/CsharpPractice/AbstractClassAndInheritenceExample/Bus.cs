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
        }
    }
}
