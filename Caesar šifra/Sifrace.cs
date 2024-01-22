using System;

namespace caesorsifra
{
    static class Sifrace
    {
        // metoda pro sifrovani 
        public static void Sifrovani(string text, string posun)
        {
            string output = "";  // vystup
            int posunNumber = Convert.ToInt32(posun);  // prevedeni posunu na cislo
            foreach (char pismeno in text)
            {
                if (char.IsLetter(pismeno))  // kontrola zda je pismeno
                {
                    char baseChar = char.IsUpper(pismeno) ? 'A' : 'a';  //urceni jestli pismeno je velka nebo mala 
                    output = output + (char)(((pismeno + posunNumber - baseChar) % 26 + 26) % 26 + baseChar);  // sifrovani
                }
                else if (char.IsDigit(pismeno))  // kontrola zda je cislo
                {
                    char baseChar = char.IsDigit(pismeno) ? '0' : '0'; 
                    output = output + (char)(((pismeno + posunNumber - baseChar) % 10 + 10) % 10 + baseChar);  // sifrovani
                }
                else if (char.IsWhiteSpace(pismeno))  // kontrola zda je mezera
                {
                    output = output + " ";  // pridani mezery
                }
            }
            Console.WriteLine(output);  // vypis vystupu
        }

        // metoda pro desifrovani
        public static void Desifrovani(string text, string posun)
        {
            string output = "";  // vystup
            int posunNumber = int.Parse(posun);  // prevedeni posunu na cislo
            foreach (char pismeno in text)  // kontrola zda je pismeno
            {
                    if (char.IsLetter(pismeno))  // kontrola zda je pismeno
                    {
                        char baseChar = char.IsUpper(pismeno) ? 'A' : 'a';  //urceni jestli pismeno je velka nebo mala
                        output = output + (char)(((pismeno - posunNumber - baseChar) % 26 + 26) % 26 + baseChar);  // desifrovani
                    }
                    else if (char.IsDigit(pismeno)) // kontrola zda je cislo
                    {
                        char baseChar = char.IsDigit(pismeno) ? '0' : '0';  // urceni jestli pismeno je velka nebo mala
                        output = output + (char)(((pismeno - posunNumber - baseChar) % 10 + 10) % 10 + baseChar);  // desifrovani
                    }
                    else if (char.IsWhiteSpace(pismeno))  // kontrola zda je mezera
                    {
                        output = output + " ";  // pridani mezery
                    }
            }
            Console.WriteLine(output);  // vypis vystupu
        }
    }
}