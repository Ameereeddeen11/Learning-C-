using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace While_and_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //do while loop 
            int u = 0;
            do
            {
                Console.WriteLine(u + ", ");
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
            }*/

            //break used in loop
            Console.WriteLine("This is break used in for loop");
            for(int t = 0; t <= 10; ++t)
            {
                if(t == 6)
                {
                    break;
                }
                Console.WriteLine(t);
            }

            //continue used in loop
            Console.WriteLine("This is continue used in for loop");
            for(int c = 0; c <=10; ++c)
            {
                if (c == 6)
                {
                    continue;
                }
                Console.WriteLine(c);
            }

            //break in while loop 
            /*Console.WriteLine("This is break used in while");
            int m = 0;
            while (m < 10)
            {
                if (m == 5)
                {
                    break;
                }
                Console.WriteLine(m);
                m++;
            }*/

            //continue in while loop 
            Console.WriteLine("This is continue in while loop");
            int p = 0;
            while (p < 10)
            {
                if (p == 7)
                {
                    p++;
                    continue;
                }
                Console.WriteLine(p);
                p++;
            }
        }
    }
}
