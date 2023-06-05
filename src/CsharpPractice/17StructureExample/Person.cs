using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17StructureExample
{
    public struct Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Child child { get; set; }
    }
}
