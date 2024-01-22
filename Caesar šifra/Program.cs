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
                // nastaveni promenych
                string odpoved;
                string text;
                string posun;

                // cteni textu pro sifrovani nebo desifrovani
                Console.WriteLine("chcete šifrovat napište: 1");
                Console.WriteLine("chcete dešifrovat napište: 2");
                odpoved = Console.ReadLine();

                // urceni zda se jedna o sifrovani nebo desifrovani
                while (odpoved != "1" && odpoved != "2")
                {
                    Console.WriteLine("zadali jste špatnou hodnotu");
                    Console.WriteLine("chcete šifrovat napište: 1");
                    Console.WriteLine("chcete dešifrovat napište: 2");
                    odpoved = Console.ReadLine();
                }
                Console.WriteLine("zadejte text:");
                text = Console.ReadLine();
                Console.WriteLine("zadejte posun:");
                posun = Console.ReadLine();

                if (odpoved == "1")
                {
                    Sifrace.Sifrovani(Validation.IsValidText(text), Validation.IsValidPosun(posun));
                }
                else if (odpoved == "2")
                {
                    Sifrace.Desifrovani(Validation.IsValidText(text), Validation.IsValidPosun(posun));
                }

                // urceni zda chce uzivatel pokracovat
                Console.WriteLine("chcete pokračovat? ano = 1 ne = 0");
                string odpoved2 = Console.ReadLine();
                while(odpoved2 != "1" && odpoved2 != "0")
                {
                    Console.WriteLine("zadali jste špatnou hodnotu");
                    Console.WriteLine("chcete pokračovat? ano = 1 ne = 0");
                    odpoved2 = Console.ReadLine();
                }

                if (odpoved2 == "1")
                {
                    run = false;
                }
                else if (odpoved2 == "0")
                {
                    run = true;
                }
            }
        }        
    }
}