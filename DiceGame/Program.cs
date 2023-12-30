using System;
namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1;
            int player1points = 0;
            int player2;
            int player2points = 0;
            Random random = new Random();
            Console.WriteLine("Lets play simple Dice Game!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to start roll");
                Console.ReadKey();
                player1 = random.Next(1, 7);
                Console.WriteLine("You rolled: " + player1);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(2000);
                player2 = random.Next(1, 7);
                Console.WriteLine("Computer rolled: " + player2);
                if (player1 > player2)
                {
                    Console.WriteLine("You won! This roll");
                    player1points++;
                }
                else if (player1 < player2)
                {
                    Console.WriteLine("Computer won! This roll");
                    player2points++;
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
            if (player1points > player2points)
            {
                Console.WriteLine("You won! " + player1points + " to " + player2points);
            }
            else if (player1points < player2points)
            {
                Console.WriteLine("Computer won! " + player2points + " to " + player1points);
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.ReadKey();
        }
    }
}