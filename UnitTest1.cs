using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaticClasses;

namespace UnitTestProject_StaticClasses
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkFractionSummPositive()
        {

            Fraction fr1 = new Fraction(3, 22);
            Fraction fr2 = new Fraction(5, 33);
            Fraction frRes = MathFraction.sum(fr1, fr2);
            Fraction frEx = new Fraction(19, 66);

            Assert.AreEqual(frRes.Denominator, frEx.Denominator);
            Assert.AreEqual(frRes.Numerator, frEx.Numerator);
            Assert.AreEqual(frRes.Sign, frEx.Sign);

        }
        [TestMethod]
        public void checkFractionSummPositive2()
        {

            Fraction fr1 = new Fraction(3, 22);
            Fraction fr2 = new Fraction(5, 33);
            Fraction frRes = MathFraction.sum(fr1, fr2);
            Fraction frEx = new Fraction(19, 66);

            Assert.AreEqual(frRes, frEx);

        }
        [TestMethod]
        public void checkFractionSummNegative()
        {

            Fraction fr1 = new Fraction(-8, 22);
            Fraction fr2 = new Fraction(5, 33);
            Fraction frRes = MathFraction.sum(fr1, fr2);
            Fraction frEx = new Fraction(-14, 66);

            Assert.AreEqual(frRes.Denominator, frEx.Denominator);
            Assert.AreEqual(frRes.Numerator, frEx.Numerator);
            Assert.AreEqual(frRes.Sign, frEx.Sign);

        }

        [TestMethod]
        public void checkFractionSubt()
        {

            Fraction fr1 = new Fraction(3, 22);
            Fraction fr2 = new Fraction(5, 33);
            Fraction frRes = MathFraction.subt(fr1, fr2);
            Fraction frEx = new Fraction(-1, 66);

            Assert.AreEqual(frRes.Denominator, frEx.Denominator);
            Assert.AreEqual(frRes.Numerator, frEx.Numerator);
            Assert.AreEqual(frRes.Sign, frEx.Sign);

        }
    }
}
