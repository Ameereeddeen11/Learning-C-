using System;

namespace caesorsifra
{
    static class Validation
    {
        // kontrola zda uzivatel neco zadal
        public static string IsValidText(string text)
        {
            bool valid = false;  // nastaveni promene
            while (!valid)  // dokud neni validni
            {
                string textWithoutSpace = text.Replace(" ", "");  // odstraneni mezer
                if (text.Length == 0 || textWithoutSpace.Length == 0)  // kontrola zda je text prazdny
                {
                    Console.WriteLine("nic jste nezadali text");
                    Console.WriteLine("Zadejte něco?");
                    text = Console.ReadLine();  // cteni textu
                }
                else
                {
                    valid = true;  // nastaveni validni
                }
            }
            return text;  // vraceni textu
        }

        // kontrola zda uzivatel neco posun
        public static string IsValidPosun(string posun)
        {
            bool valid = false;  // nastaveni promene
            bool valid2 = false;  // nastaveni promene
            while (!valid2)  // dokud neni validni
            {
                try
                {
                    int b = int.Parse(posun);  // prevedeni posunu na cislo
                    valid2 = true;  // nastaveni validni
                }
                catch (Exception)  // pokud se nepodari prevest na cislo
                {
                    Console.WriteLine("posun nemuze byt pismeno");
                    Console.WriteLine("zadejte posun:");
                    posun = Console.ReadLine();  // cteni posunu
                }
            }
            while (!valid)  // dokud neni validni
            {
                string posunWithoutSpace = posun.Replace(" ", "");  // odstraneni mezer
                if (posunWithoutSpace.Length == 0)  // kontrola zda je posun prazdny
                {
                    Console.WriteLine("nezadali jste posun");
                    Console.WriteLine("zadejte posun:");
                    posun = Console.ReadLine();  // cteni posunu
                }
                else
                {
                    valid = true;  // nastaveni validni
                }
            }
            return posun;  // vraceni posunu
        }
    }
}
