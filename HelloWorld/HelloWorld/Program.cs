using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(3+3);

            byte number = 25;
            int count = 15;
            float totalPrice = 20.89f;
            char character = 'A';
            string firstName = "Amiriddin";
            bool isEating = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isEating);


            //for loop and while loop
            double a = 0, b = 1, c;
            Console.WriteLine("Kolik cisel chcete: ");
            c = Convert.ToDouble(Console.ReadLine());
            a++;
            for (int i = 1; i < c; i++)
            {
                Console.Write(i);
                a = a + i;
                b = b * i;
            }
            for (int i = 0; i < c; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Scitani vsech cisel je " + a);
            Console.WriteLine("Soucet vsech cisel je " + b);
            Console.ReadLine();


            double x = 1;
            do
            {
                Console.Write(x + ", ");
                x++;
            } while (x != 11);
            Console.ReadLine() ;
        }
    }
}
