using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    static class Program 
    {
        static void Main(string[] args)
        {
            int a = 2;
            double result = Math.Pow(Math.Sqrt(a), 2);
            Console.WriteLine(result);

            int t = MathFraction.getNOD(22, 33);

            int b = MathFraction.getNOK(22, 33);

            Fraction fr1 = new Fraction(3, 22);
            Fraction fr2 = new Fraction(5, 33);
            Fraction frRes = MathFraction.sum(fr1, fr2);


            Fraction fr11 = new Fraction(-8, 22);
            Fraction fr22 = new Fraction(5, 33);
            Fraction frRes2 = MathFraction.sum(fr11, fr22);

            //Fraction fr11 = new Fraction(-8, 22);
            //Fraction fr22 = new Fraction(5, 33);
            //Fraction frRes2 = MathFraction.sum(fr11, fr22);

            //Fraction fr11 = new Fraction(-8, 22);
            //Fraction fr22 = new Fraction(5, 33);
            //Fraction frRes2 = MathFraction.sum(fr11, fr22);


            Console.ReadLine();
        }
    }
}
