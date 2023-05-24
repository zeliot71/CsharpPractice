using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample02
{
    public class MathUtlis
    {

        public int Multiply(int num2,int num1) 
        {
            return num1 * num2;
        }
        public int Multiply(int num1,int num2,int num3) 
        {
            return num1 * num2 * num3;
        }
        public double Multiply(double num1,double num2)
        {
            return num1 * num2;
        }
        public int Multiply(int[] numbers)
        {
            int product = 1;
            foreach (int number in numbers)
            {
                product *=  number;
            }
            return product;
        }


    }
}
