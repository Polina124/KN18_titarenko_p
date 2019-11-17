using System;
using System.Collections.Generic;

namespace lb_1
{
    class Evaluator
    {
        public class CasualEvaluator
        {
            private static double add(double x, double y)
            {
                return x + y;
            }
            private static double minus(double x, double y)
            {
                return x - y;
            }
            private static double division(double x, double y)
            {
                return x / y;
            }
            private static double multiply(double x, double y)
            {
                return x * y;
            }

            private Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>()
            {
                {"+", add},
                {"-", minus},
                {"/", division},
                {"*", multiply},
            };

            public double Result(string sign, double LeftOperand, double RightOperand)
            {
                return operations[sign](LeftOperand, RightOperand);
            }
        }

        public class EngineerEvaluator
        {
            private static double cos(double x)
            {
                return Math.Cos(x);
            }

            private static double sin(double x)
            {
                return Math.Sin(x);
            }

            private static double tan(double x)
            {
                return Math.Tan(x);
            }

            private static double sqrt(double x)
            {
                return Math.Sqrt(x);
            }

            private static double power(double x)
            {
                return x*x;
            }

            private static double log(double x)
            {
                return Math.Log(x);
            }

            private static double log10(double x)
            {
                return Math.Log10(x);
            }

            private static double exponenta (double x)
            {
                return Math.Exp(x);
            }

            private static double arccos(double x)
            {
                return Math.Acos(x);
            }

            private static double arcsin(double x)
            {
                return Math.Asin(x);
            }
            private Dictionary<string, Func<double, double>> operations = new Dictionary<string, Func<double, double>>()
            {
                {"cos", cos},
                {"sin", sin},
                {"tan", tan},
                {"sqrt", sqrt},
                {"power", power },
                {"log", log},
                {"log10", log10},
                {"exp", exponenta},
                {"acos", arccos},
                {"asin", arcsin},


            };

            public double Result(string sign, double num)
            {
                return operations[sign](num);
            }
        }
    }
}
