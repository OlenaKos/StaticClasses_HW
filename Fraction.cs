using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public class Fraction
    {
        //properties
        public int Numerator { set; get; } //chislitel
        public int Denominator { set; get; } //znamenatel
        public int Sign { set; get; }

        //constructors
        public Fraction() { }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Divizion by zero is not allowed");
            }
            Numerator = Math.Abs(numerator);
            Denominator = Math.Abs(denominator);
            if (numerator * denominator < 0)
            {
                Sign = -1;
            }
            else
            {
                Sign = 1;
            }
        }
        public Fraction(int numerator) : this(numerator, 1) { }

        public static bool operator ==(Fraction fr1, Fraction fr2)
        {
            bool res = false;
            if ((fr1.Numerator == fr2.Numerator) && (fr1.Denominator == fr2.Denominator) && (fr1.Sign == fr2.Sign))
            {
                res = true;
            }

            return res;
        }
        public static bool operator !=(Fraction fr1, Fraction fr2)
        {
            bool res = true;
            if ((fr1.Numerator == fr2.Numerator) && (fr1.Denominator == fr2.Denominator) && (fr1.Sign == fr2.Sign))
            {
                res = false;
            }

            return res;
        }

        public bool Equals(Fraction fr2)
        {
            bool res = false;
            if ((Numerator == fr2.Numerator) && (Denominator == fr2.Denominator) && (Sign == fr2.Sign))
            {
                res = true;
            }

            return res;
        }
    }
}
