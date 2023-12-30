using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_switch
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //if
            if (20 < 31)
            {
                Console.WriteLine("31 is greater than 20");
            }
            //short hand if, else
            int time = 15;
            string result = (time < 18) ? "Good day." : "Good evening";
            Console.WriteLine(result);
            //else
            Console.WriteLine("Kolik je hodin je u vas: ");
            int timeZone = Convert.ToInt32(Console.ReadLine());
            if (timeZone < 12)
            {
                Console.Write("Good morning");
            }
            else
            {
                Console.WriteLine("Good evening");
            }
            //else if
            Console.WriteLine("jsem kalkulacka");
            Console.WriteLine("zadejte hodnotu a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zadejte hodnotu b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("chcete to secist +, nebo odecist -");
            string operatory = Console.ReadLine();
            if (operatory == "+")
            {
                int c = a + b;
                Console.WriteLine("vysledek je " + c);
            }
            else if (operatory == "-")
            {
                int c = a - b;
                Console.WriteLine("vysledek je " + c);
            }
            else
            {
                Console.WriteLine("tuhle operaci neumim");
            }
            //switch
            Console.WriteLine("Jsem lepsi kalkulacka");
            Console.WriteLine("zadejte hodnotu a = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zadejte hodnotu b = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("chcete to secist +, odecist -, suocin*, vydelit/");
            string operatory_2 = Console.ReadLine();
            switch (operatory_2)
            {
                case "+":
                    int z = x + y;
                    Console.WriteLine("vysledek je " + z);
                    break;
                case "-":
                    int z = y - x;
                    Console.WriteLine("vysledek je " + z);
                    break;
                case "*":
                    int z = y * x;
                    Console.WriteLine("vysledek je " + z);
                    break;
                case "/":
                    int z = y / x;
                    Console.WriteLine("vysledek je " + z);
                    break;
                default:
                    Console.WriteLine("Tuto operaci neumim");
                    break;
            }
            Console.ReadLine();
        }
    }
}
