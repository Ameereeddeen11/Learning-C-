using System;
namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            bool isResultCorrect = false;
            Random random = new Random();
            int randomnum = random.Next(1, 11);
            Console.WriteLine("Hello! Lets play Guessing number game.");
            Console.WriteLine("I think a random number between 1 and 10. You have to guess the number.");
            Console.WriteLine("Please enter any key to start game");
            Console.ReadKey();
            Console.WriteLine("Hmm... Let me to thing the number");
            System.Threading.Thread.Sleep(2000);
            while (!isResultCorrect)
=======
            bool run = false;
            while (!run)
>>>>>>> guessnumber
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
                    else if (guess == randomnum)
                    {
                        Console.WriteLine("Your guess is correct");
                        isResultCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }

                Console.WriteLine("Congratulations! You won the game.");
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("Press 1 to play again. Press any key to exit");
                string playAgain = Console.ReadLine();
                if (playAgain == "1")
                {
                    run = false;
                }
                else
                {
                    run = true;
                }
            }
            Console.ReadKey();
        }
    }
}