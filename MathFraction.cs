using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class MathFraction
    {
        public static Fraction sum(Fraction first, Fraction second) // 3/22 + 5/33 = 9/66 + 10/66
        {
            int NOK = getNOK(first.Denominator, second.Denominator);
            int firstMult = NOK / first.Denominator; 
            int secMult = NOK / second.Denominator; 
            
            int numerator = first.Sign * first.Numerator * firstMult + second.Sign *second.Numerator * secMult;
            int denominator = NOK;
            Fraction res = new Fraction(numerator, denominator);
            return res;
        }
        public static Fraction subt(Fraction first, Fraction second)
        {
            int NOK = getNOK(first.Denominator, second.Denominator);
            int firstMult = NOK / first.Denominator;
            int secMult = NOK / second.Denominator; 

            int numerator = first.Sign * first.Numerator * firstMult - second.Sign * second.Numerator * secMult;
            int denominator = NOK;
            Fraction res = new Fraction(numerator, denominator);
            return res;
        }

        public static Fraction mult(Fraction first, Fraction second)
        {

            int numerator = first.Sign * first.Numerator  * second.Sign * second.Numerator;
            int denominator = first.Denominator * second.Denominator;

            int NOD = getNOD(numerator, denominator);
            numerator = numerator / NOD;
            denominator = denominator / NOD;

            Fraction res = new Fraction(numerator, denominator);
            return res;
        }

        public static int getNOD(int a, int b) //get Greatest Common Divisor by Euclids algorithm a = 22, b = 33, NOD = 11
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int getNOK(int a, int b) //get Smallest Coommon Multiplyer a = 22, b = 33, NOK =66
        {
            return a * b / getNOD(a, b);
        }
    }
}
