﻿using System;
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

                // cteni textu pro sifrovani
                Console.WriteLine("chcete šifrovat napište: 1");
                Console.WriteLine("chcete dešifrovat napište: 2");
                odpoved = Console.ReadLine();
                Console.WriteLine("zadejte text:");
                text = Console.ReadLine();
                Console.WriteLine("zadejte posun:");
                posun = Console.ReadLine();

                // urceni zda se jedna o sifrovani nebo desifrovani
                if (odpoved == "1")
                {
                    Sifrovani(IsValidText(text), IsValidPosun(posun));
                }
                else if (odpoved == "2")
                {
                    Sifrovani(IsValidText(text), "-"+IsValidPosun(posun));
                }
                else
                {
                    Console.WriteLine("Dali jste šptnou hodnotu nebo jste neuvedli žadnou hodnotu");
                    run = false;
                }

                // urceni zda chce uzivatel pokracovat
                Console.WriteLine("chcete pokračovat? ano = 1 ne = 0");
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
                    Console.WriteLine("tanto možnost neexistuje");
                    run = true;
                }
            }
        }

        // kontrola zda uzivatel neco zadal
        static string IsValidText(string text)
        {
            bool valid = false;
            while (!valid)
            {
                string textWithoutSpace = text.Replace(" ", "");
                if (text.Length == 0 || textWithoutSpace.Length == 0)
                {
                    Console.WriteLine("nic jste nezadali text");
                    Console.WriteLine("Zadejte něco?");
                    text = Console.ReadLine();
                }
                else
                {
                    valid = true;
                }
            }
            return text;
        }

        // kontrola zda uzivatel neco posun
        static string IsValidPosun(string posun)
        {
            bool valid = false;
            while(!valid)
            {
                string posunWithoutSpace = posun.Replace(" ", "");
                if (!(int.TryParse(posun, out int number)) || posun.Length == 0 || posunWithoutSpace.Length == 0)
                {
                    Console.WriteLine("nezadali jste posun");
                    Console.WriteLine("zadejte posun:");
                    posun = Console.ReadLine();
                }
                else
                {
                    valid = true;
                    Console.WriteLine("validace probehla uspesne");
                }
            }
            return posun;
        }

        // metodan pro sifrovani a desifrovani
        static void Sifrovani(string text, string posun)
        {
            string output = "";
            int posunNumber= Convert.ToInt32(posun);
            foreach (char pismeno in text)
            {
                char baseChar = char.IsUpper(pismeno) ? 'A' : 'a';
                output = output + (char)(((pismeno + posunNumber - baseChar) % 26 + 26) % 26 + baseChar);
            }
            Console.WriteLine(output);
        }
    }
}