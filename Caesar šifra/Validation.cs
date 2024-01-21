using System;

namespace caesorsifra
{
    static class Validation
    {
        // kontrola zda uzivatel neco zadal
        public static string IsValidText(string text)
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
        public static string IsValidPosun(string posun)
        {
            bool valid = false;
            bool valid2 = false;
            while (!valid2)
            {
                foreach (char pismeno in posun)
                {
                    if (char.IsLetter(pismeno))
                    {
                        Console.WriteLine("posun nemuze byt pismeno");
                        Console.WriteLine("zadejte posun:");
                        posun = Console.ReadLine();
                    }
                    else
                    {
                        valid2 = true;
                    }
                }
            }
            while (!valid)
            {
                //bool res = int.TryParse(posun, out int result);
                string posunWithoutSpace = posun.Replace(" ", "");
                if (posunWithoutSpace.Length == 0)
                {
                    Console.WriteLine("nezadali jste posun");
                    Console.WriteLine("zadejte posun:");
                    posun = Console.ReadLine();
                }
                else
                {
                    valid = true;
                }
            }
            return posun;
        }
    }
}
