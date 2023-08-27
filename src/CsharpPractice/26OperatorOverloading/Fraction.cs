using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _26OperatorOverloading
{
    public class Fraction
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
        
        //Operator overloading syntax sound like methods haha
        public static Fraction operator +(Fraction a)
        {
            return a;
        }
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.num, a.den);
        }
        public static Fraction operator+(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        }
        public static Fraction operator  -(Fraction a, Fraction b)
        {
            return a + (-b);
        } 
        public static Fraction operator*(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }
        public static Fraction operator/(Fraction a, Fraction b)
        {
            if(b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.den);
        }

        public override string ToString()
        {
            return $"{num}/ {den}";
        }

    }
}
