using System;
namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isResultCorrect = false;
            Random random = new Random();
            int randomnum = random.Next(1, 10);
            Console.WriteLine("Hello! Lets play Guessing number game.");
            Console.WriteLine("I think a random number between 1 and 10. You have to guess the number.");
            Console.WriteLine("Please enter any key to start game");
            Console.ReadKey();
            Console.WriteLine("Hmm... Let me to thing the number");
            System.Threading.Thread.Sleep(2000);
            while (!isResultCorrect)
            {
                Console.WriteLine("I thought a number. Please enter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > randomnum)
                {
                    Console.WriteLine("Your guess is high");
                }
                else if (guess < randomnum)
                {
                    Console.WriteLine("Your guess is low");
                }
                else
                {
                    Console.WriteLine("Correct! I guessed " + randomnum);
                    isResultCorrect = true;
                }
            }

            Console.WriteLine("Congratulations! You won the game.");
            Console.ReadKey();
        }
    }
}