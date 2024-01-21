using System;

namespace caesorsifra
{
    static class Sifrace
    {
        // metodan pro sifrovani a desifrovani
        public static void Sifrovani(string text, string posun)
        {
            string output = "";
            int posunNumber = Convert.ToInt32(posun);
            foreach (char pismeno in text)
            {
                if (char.IsLetter(pismeno))
                {
                    char baseChar = char.IsUpper(pismeno) ? 'A' : 'a';
                    output = output + (char)(((pismeno + posunNumber - baseChar) % 26 + 26) % 26 + baseChar);
                }
                else if (char.IsDigit(pismeno))
                {
                    char baseChar = char.IsDigit(pismeno) ? '0' : '0';
                    output = output + (char)(((pismeno + posunNumber - baseChar) % 10 + 10) % 10 + baseChar);
                }
                else if (char.IsWhiteSpace(pismeno))
                {
                    output = output + " ";
                }
            }
            Console.WriteLine(output);
        }

        // metoda pro desifrovani
        public static void Desifrovani(string text, string posun)
        {
            string output = "";
            int posunNumber = int.Parse(posun);
            foreach (char pismeno in text)
            {
                    if (char.IsLetter(pismeno))
                    {
                        char baseChar = char.IsUpper(pismeno) ? 'A' : 'a';
                        output = output + (char)(((pismeno - posunNumber - baseChar) % 26 + 26) % 26 + baseChar);
                    }
                    else if (char.IsDigit(pismeno))
                    {
                        char baseChar = char.IsDigit(pismeno) ? '0' : '0';
                        output = output + (char)(((pismeno - posunNumber - baseChar) % 10 + 10) % 10 + baseChar);
                    }
                    else if (char.IsWhiteSpace(pismeno))
                    {
                        output = output + " ";
                    }
            }
            Console.WriteLine(output);
        }
    }
}