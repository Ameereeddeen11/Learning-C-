using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_at_school
{
    internal class Program
    {
        static double sum (double x, double y)
        {
            double z = x + y;
            return z;
        }

        static double product(double x, double y)
        {
            double z = x / y;
            return z;
        }

        static double multiplication(double x, double y)
        {
            double z = x * y;
            return z;
        }

        static void Main(string[] args)
        {
            double a, b;
            string operat;

            Console.WriteLine("Enter first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Operator");
            operat = Convert.ToString(Console.ReadLine());

            switch (operat)
            {
                case "+":
                    sum(a, b);
                    Console.WriteLine("Enter first number: " + sum(a, b));
                    break;

                case "/":
                    product(a, b);
                    Console.WriteLine("podil cisel je " + product(a, b));
                    break;

                case "*":
                    multiplication(a, b);
                    Console.WriteLine("multiplication is " + multiplication(a, b));
                    break;
            }
        }
    }
}