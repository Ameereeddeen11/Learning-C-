namespace if_else_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            string result = (age >= 18) ? "You can vote" : "You con't vote";
            Console.WriteLine(result);

            Console.WriteLine("What is time now? ");
            int time = Convert.ToInt32(Console.ReadLine());
            if (10 >= time)
            {
                Console.WriteLine("Good morning");
            }
            else if (14 >= time)
            {
                Console.WriteLine("Good day");
            }
            else if (15 <= time)
            {
                Console.WriteLine("Good aftermoon");
            }

            Console.WriteLine("Give me value for a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me value for b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("which operations do you want to do? ");
            string opertion = Console.ReadLine();
            switch (opertion)
            {
                case "+":
                    int c = a + b;
                    Console.WriteLine(c);
                    break;
                case "-":
                    int c = a - b;
                    Console.WriteLine(c);
                    break;
                case "*":
                    int c = a * b;
                    Console.WriteLine(c);
                    break;
                case "/":
                    int c = a / b;
                    Console.WriteLine(c);
                    break;
                default:
                    Console.WriteLine("I can't calculate");
                    break;
            }
            Console.ReadLine();
        }
    }
}