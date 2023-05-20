using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height= height;
        }

        public double CalculateArea()
        {
           return Height * Width;
            
        }
        public double CalculatePerimiter()
        {
           return (Height * 2) + (Width * 2);
            
        }
    }
}
