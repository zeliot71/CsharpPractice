using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26OperatorOverloading
{
    public readonly struct Fraction
    {
        private readonly int num;
        private readonly int den;


        public Fraction(int numerator, int denominator)
        {
            if 
                (denominator == 0) throw new ArgumentException("Denominator cannot be zero", nameof(denominator));
            num = numerator;
            den = denominator;
        }
       
    }
}
