using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloadingExample01
{
   public class Rectangle
    {
        public int length;
        public int width;

        public Rectangle()
        {
            length= 0;
            width= 0;
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle(int sideLength)
        {
            length= sideLength;
            width = sideLength;
        }

        public int CalculateArea()
        {
            return length * width;
        }

    }
}
