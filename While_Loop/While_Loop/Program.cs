using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_and_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //do while loop 
            int u = 0;
            do
            {
                Console.Write(u + ", ");
                u++;
            }
            while (u < 13);

            //for loop 
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(a);
            }

            //nested loops
            //outer loop
            for(int x = 1; x <= 3; ++x)
            {
                Console.WriteLine("Outer: " + x);

                for(int z = 1; z<=4; ++z)
                {
                    Console.WriteLine("Inner: " + z);
                }
            }
        }
    }
}
