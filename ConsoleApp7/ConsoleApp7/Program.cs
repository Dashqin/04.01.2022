using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate sum of a and b:");
            int a = 2;
            int b = 3;
            Console.WriteLine(Calculator.Sum(a.Power(), b.Power()));
            Console.WriteLine("Calculate sum of a,b and c:");
            a = 1;
            b = 2;
            int c = 3;
            Console.WriteLine(Calculator.Sum(a.Power(), b.Power(), c.Power()));
            Console.WriteLine("Calculate multiply of a and b:");
            a = 5;
            b = 4;
            Console.WriteLine(Calculator.Multiply(a.Power(), b.Power()));
            Console.WriteLine("Calculate multiply of a,b and c:");
            a = 2;
            b = 7;
            c = 4;
            Console.WriteLine(Calculator.Multiply(a.Power(), b.Power(), c.Power()));
            Console.WriteLine("Calculate divide of a and b:");
            a = 6;
            b = 2;
            Console.WriteLine(Calculator.Divide(a.Power(), b.Power()));
            Console.WriteLine("Calculate divide of a,b and c:");
            a = 8;
            b = 4;
            c = 2;
            Console.WriteLine(Calculator.Divide(a.Power(), b.Power(), c.Power()));
        }
    }
}
