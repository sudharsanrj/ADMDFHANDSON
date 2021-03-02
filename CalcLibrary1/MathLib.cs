using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary1
{
    public class MathLib
    {
        public interface IMathLibrary
        {
            double Addition(double a, double b);
            double Subtraction(double a, double b);
            double Multiplication(double a, double b);
            double Division(double a, double b);
        }
        public class SimpleCalculator : IMathLibrary
        {
            double result = 0;
            public double Addition(double a, double b)
            {
                result = a + b;
                return result;
            }
            public double Multiplication(double a, double b)
            {
                result = a * b;
                return result;
            }
            public double Subtraction(double a, double b)
            {
                result = a - b;
                return result;
            }
            public double Division(double a, double b)
            {
               
                result = a / b;
                return result;
            }

            public void AllClear()
            {
                result = 0;
            }

            public double GetResult
            {
                get { return result; }
            }

        }
    }
}
