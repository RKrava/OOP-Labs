using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Expression
    {
        double _a, _c, _d;

        public Expression(double a, double c, double d)
        {
            _a = a;
            _c = c;
            _d = d;
        }
        public void Set_a(double a)
        {
            _a = a;
        }
        public void Set_c(double c)
        {
            _c = c;
        }
        public void Set_d(double d)
        {
            _d = d;
        }
        public double Get_a()
        {
            return _a;
        }
        public double Get_c()
        {
            return _c;
        }
        public double Get_d()
        {
            return _d;
        }
        public double GetAnswer()
        {
            try
            {
                if (_d == 0) throw new DivideByZeroException();
                if (_d < 0) throw new ArithmeticException();
                if (_c + _a + 1 == 0) throw new DivideByZeroException();
                return (2 * _c - _d * Math.Sqrt(42 / _d)) / (_c + _a + 1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by Zero! Info: " + ex.Message);
                Environment.Exit(0);
                return 0;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Negative square root! Info: " + ex.Message);
                Environment.Exit(1);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! Info: " + ex.Message);
                Environment.Exit(2);
                return 0;
            }
        }
    }
}
