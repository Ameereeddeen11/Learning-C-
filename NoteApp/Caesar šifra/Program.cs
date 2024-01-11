using System;
using System.Net.Security;
using static System.Net.Mime.MediaTypeNames;
namespace caesorsifra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int posun;
            string abeceda = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("chcete desifrovat nebo sifrovat?");
            string odpoved = Console.ReadLine();
            Console.WriteLine("zadejte text:");
            text = Console.ReadLine();
            Console.WriteLine("zadejte posun:");
            posun = Convert.ToInt32(Console.ReadLine());
            if (odpoved == "sifrovat")
            {
                Sifrovani(text, posun);
            }
            else if (odpoved == "desifrovat")
            {
                Sifrovani(text, -posun);
            }
            else
            {
                Console.WriteLine("chyba");
            }
        }
        static void Sifrovani(string text, int posun)
        {
            string abeceda = "abcdefghijklmnopqrstuvwxyz";
            string output = "";
            foreach (char pismeno in text)
            {
                int index = abeceda.IndexOf(pismeno);
                int index2 = index + posun;
                char pismeno2 = abeceda[index2];
                output = output + pismeno2;
            }
            
            Console.WriteLine(output);
        }
    }
}