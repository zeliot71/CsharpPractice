using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample01
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x,int y, int z)
        {
            return x + y + z;
             
        }
        public double Add(double x, double y) 
        {
            return x + y;
        }
        public int Add(int[] x)
        {
            int sum = 0;
            foreach (int i in x)
            {
                sum += i;
            }
            return sum;
        }

    }
}
