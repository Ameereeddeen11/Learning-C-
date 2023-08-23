namespace ForAndWhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loops
            int a = 0;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
            // do while loop
            int x = 0;
            do 
            { 
                Console.WriteLine(x); 
                x++;
            } 
            while (x < 5);

            // for loop
            for (int y = 0; y < 8; y++)
            {
                Console.WriteLine(y);
            }
            
            // for loop in for loop
            for (int z =  0; z < 8; z++)
            {
                Console.WriteLine("This is z for loop " + z);
                for (int b = 0; b <= z; b++)
                {
                    Console.WriteLine("This is b for loop " + b);
                }
            }

            // foreach loop is used for loop through elements in an array
            string[] logo = { "Apple", "BMW", "Mersedes-Benz", "YouTube"};
            foreach (string l in logo)
            {
                Console.WriteLine(l);
            }
        }
    }
}