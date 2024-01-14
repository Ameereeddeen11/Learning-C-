using System;
namespace caesorsifra
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = false;
            while (!run)
            {
                string odpoved;
                string text;
                int posun;
                Console.WriteLine("chcete sifrovat napiste 1");
                Console.WriteLine("chcete desifrovat napiste 2");
                odpoved = Console.ReadLine();
                Console.WriteLine("zadejte text:");
                text = Console.ReadLine();
                Console.WriteLine("zadejte posun:");
                posun = Convert.ToInt32(Console.ReadLine());
                
                if (odpoved == "1")
                {
                    Sifrovani(IsValid(text), posun);
                }
                else if (odpoved == "2")
                {
                    Sifrovani(IsValid(text), -posun);
                }
                else
                {
                    Console.WriteLine("Dali jste sptnou hodnotu nebo jste neuvedli");
                }

                Console.WriteLine("chcete pokracovat? ano = 1 ne = 0");
                string odpoved2 = Console.ReadLine();
                if (odpoved2 == "1")
                {
                    run = false;
                }
                else if (odpoved2 == "0")
                {
                    run = true;
                }
                else
                {
                    Console.WriteLine("tanto moznost neexistuje");
                    run = true;
                }
            }
        }

        static string IsValid(string text)
        {
            bool valid = false;
            while (!valid)
            {
                if (text.Length == 0)
                {
                    Console.WriteLine("nic jste nezadali");
                    Console.WriteLine("Zadejte neco?");
                    text = Console.ReadLine();
                }
                else
                {
                    valid = true;
                }
            }
            return text;
        }
        static void Sifrovani(string text, int posun)
        {
            string output = "";
            foreach (char pismeno in text)
            {
                char baseChar = char.IsUpper(pismeno) ? 'A' : 'a';
                output = output + (char)(((pismeno + posun - baseChar) % 26 + 26) % 26 + baseChar);
            }
            Console.WriteLine(output);
        }
    }
}
