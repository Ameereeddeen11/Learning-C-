namespace Objem_a_objem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte stranu a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte stranu vystku a: ");
            int v = Convert.ToInt32(Console.ReadLine());
            int s = a * v / 2;
            Console.WriteLine("Obsah daneho trojuhelniku je: " + s);
        }
    }
}