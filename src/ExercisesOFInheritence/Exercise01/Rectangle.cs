using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
