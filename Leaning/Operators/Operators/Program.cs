using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //there is four types of operators
            //Arithmetic
            int sum1 = 100 + 50;
            int sum2 = sum1 + 562;
            int sum3 = sum2 - sum2;
            int sum4 = 5 * 5;
            int sum5 = sum3 / sum4;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.WriteLine(sum4);
            Console.WriteLine(sum5);

            //Assignment
            int x = 108;
            x += 554;
            Console.WriteLine(x);

            //Comparison
            int a = 456;
            int b = 412;
            Console.WriteLine(a > b);   //return True becouse 456 is highter then 412

            //Logical 
            int z = 5;
            Console.WriteLine(!(z > 3 && z < 10)); // returns False because ! (not) is used to reverse the result


            //Math class has many methods
            //one of the methods are max and min
            int q = 453;
            int w = 1538;
            Console.WriteLine(Math.Max(q, w));
            Console.WriteLine(Math.Max(531, 154));

            Console.WriteLine(Math.Min(q, w));
            Console.WriteLine(Math.Min(531, 154));

            //another method are square, absolute, rounds
            int e = 121;
            int t = -142;
            Console.WriteLine(Math.Sqrt(e));
            Console.WriteLine(Math.Abs(t));
            Console.WriteLine(Math.Round(56.5452));
        }
    }
}
