using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
            MethodParaments("Amiriddin");  //Amiriddin is argument
            MethodMultipleParameters("Dan", 16);

            Console.WriteLine("Are you from Czech Republic");
            string country = Console.ReadLine();
            if (country == "yes")
            {
                MethodDefault();
            }
            else
            {
                Console.WriteLine("You are from " + country);
            }

            Console.WriteLine(MethodReturnValue(4, 5));
            int myNum_1 = MethodReturnValue(89, 81);
            double myNum_2 = MethodReturnValue(58.48, 48.455);
            Console.WriteLine("Int: " + myNum_1);
            Console.WriteLine("Double: " + myNum_2);
            MethodArguments(number_1: 132, number_2: 3, number_3: 34);
            /*int s = 1;
            for (int i = 1; i <= 10; i++)
            {
                s = s * i;
            }
            Console.WriteLine(s);*/
        }

        static void MyMethod()
        {
            Console.WriteLine("Hi, this is MyMethod");
        }

        //method for paramenters and arguments
        static void MethodParaments(string fname /* fname is parameter */)  
        {
            Console.WriteLine(fname + " Abdullaev");
        }
        
        //multiple parameters 
        static void MethodMultipleParameters(string name, int age)
        {
            Console.WriteLine(name + " is " + age);
        }

        //default value 
        static void MethodDefault(string country = "You are from Czech Repoblic")
        {
            Console.WriteLine(country);
        }

        //return values
        static int MethodReturnValue(int x, int y)
        {
            return x + y;
        }

        //arguments named
        static void MethodArguments(int number_1, int number_2, int number_3)
        {
            Console.WriteLine("The smallest number is " + number_2);
        }

        //overloading method
        //multiple methods can have the same name with different parameters
        static double MethodReturnValue(double x, double y)
        {
            return x + y;
        }
    }
}
