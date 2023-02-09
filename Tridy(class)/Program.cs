using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tridy_class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("zadejte hodnotu a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("zadejte kodnotu b ");
            b = Convert.ToDouble(Console.ReadLine());

            Soucet myObj= new Soucet(); 
            Console.WriteLine("hodnota je " + myObj.Plus(a, b));        
        }
    }
}
