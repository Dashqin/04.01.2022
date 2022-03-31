using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    static class Calculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Divide(int a, int b, int c)
        {
            return a / b / c;
        }
    }
}
