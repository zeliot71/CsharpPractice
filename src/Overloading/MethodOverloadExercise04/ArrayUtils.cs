using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExercise04
{
    public class ArrayUtils
    {
        public int Sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }
        public double Sum(double[] array)
        {
            double sum1 = 0;
            foreach(double i in array)
            {
                sum1 += i;
            }
            return sum1;
        }
    }
}
