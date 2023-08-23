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

            Console.WriteLine("Five me some number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("I can't calculate faktorial");
            }
            else
            {
                if (num == 0)
                {
                    return 1
                }
                else
                {
                    int result = num * (num - 1);
                    Console.WriteLine("Faktorial is " + result);
                }
            }
            Console.ReadLine();
        }
    }
}
