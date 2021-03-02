using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLibrary1;
using NUnit.Framework;

namespace testingHandson
{
    [TestFixture]
    class SimpleCalci
    {


        CalcLibrary1.MathLib.SimpleCalculator cal = new MathLib.SimpleCalculator();
        [SetUp]
        public void setup()
        {
            double result = cal.GetResult;
        }
        [Test]
            public void Additiontest()
            {
                double r = cal.Addition(5.00, 2.00);
                Assert.That(Does.Equals(r, 7.00), Is.True);
            }
        [Test]
        [TestCase(2, 5, 10)]
        [TestCase(3, 3, 9)]
        [TestCase(5, 1, 5)]
        public void multiplication(double a, double b, double c)
        {
            double r = cal.Multiplication(a, b);
            Assert.AreEqual(c, r);
        }

        [Test]
        [TestCase(2, 2, 0)]
        [TestCase(8, 2, 6)]
        [TestCase(9, 2, 7)]
        public void sub(double a, double b, double c)
        {
            double r = cal.Subtraction(a, b);
            Assert.AreEqual(c, r);
        }

        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(8, 2, 4)]
        [TestCase(8, 0, 0)]
        public void division(double a, double b, double e)
        {
            try
            {
                double r = cal.Division(a, b);
                Assert.AreEqual(e, r);
            }
            catch (Exception f)
            {
                Assert.Fail("Division by zero");
            }
        }
        [Test]
        [TestCase(5, 5, 10)]
        [TestCase(6, 6, 12)]
        public void TestAddAndClear(double a, double b, double e)
        {
            double r = cal.Addition(a, b);
            Assert.AreEqual(e, r);
            cal.AllClear();
            Assert.AreEqual(0, cal.GetResult);
        }

        [TearDown]
        public void cleanup()
        {
            cal.AllClear();
        }

        
    }
}

