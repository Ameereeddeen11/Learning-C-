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
            Console.ReadLine();
        }
    }
}