using System;

namespace MiniApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; ++i)
            {
                // int result;
                if (i % 3 == 0)
                {
                    Console.WriteLine("bizz");
                }
                else if (i % 7 == 0 )
                {
                    Console.WriteLine("bazz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            double price = 30;
            double result = 0;
            foreach(char i in name)
            {
                result += price;
            }
            //return result;
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
