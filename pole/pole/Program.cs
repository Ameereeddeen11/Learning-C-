using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] pole = new int[10];
           pole[0] = 1;

           for (int i = 0; i < 10; i++)
           {
               pole[i] = i + 1;
           }

           for (int i = 0; i < 10; i++)
           {
               Console.Write(pole[i] + ",");
           }
           Console.WriteLine();


               string[] jmena = { "Tomas", "Dan", "Honza" };
           Array.Sort(jmena); //seradi podle abecedy 
           Array.Reverse(jmena); //seradi zezadu

           foreach(string j in jmena) // se k psani pole
           {
               Console.Write("{0} ", j);
           } */

            Console.Write("Zadejte kolik chcete zapsat znamek: ");
            int pocet = Convert.ToInt32(Console.ReadLine()); // int32 convertuje na int
            int[] znamky = new int[pocet];

            for(int i = 0; i < pocet; i++)
            {
                Console.Write("zadejte " + (i + 1) + ". cislo");
                znamky[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Prumer znamek je: {0}", znamky.Average()); //average je prumer

            Console.ReadLine();
        }
    }
}
