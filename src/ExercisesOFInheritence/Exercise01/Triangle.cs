using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    

    class Triangle : Shape
    {
       
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double bases, double height)
        {
            Base = bases;
            Height = height;
        }
        public override double CalculateArea()
        {
           return 1/2 * Base * Height;
        }
    }
}
