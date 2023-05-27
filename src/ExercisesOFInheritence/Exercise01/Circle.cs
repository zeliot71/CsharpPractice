using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public const double Pi = 3.1416;

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Pi * Radius * Radius;
        }

    }
}
