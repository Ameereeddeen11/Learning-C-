using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(3+3);

            byte number = 25;
            int count = 15;
            float totalPrice = 20.89f;
            char character = 'A';
            string firstName = "Amiriddin";
            bool isEating = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isEating);



            //for loop and while loop
            double a = 0, b = 1, c;
            Console.WriteLine("Kolik cisel chcete: ");
            c = Convert.ToDouble(Console.ReadLine());
            a++;
            for (int i = 1; i < c; i++)
            {
                Console.Write(i);
                a = a + i;
                b = b * i;
            }
            for (int i = 0; i < c; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Scitani vsech cisel je " + a);
            Console.WriteLine("Soucet vsech cisel je " + b);
            Console.ReadLine();


            double x = 1;
            do
            {
                Console.Write(x + ", ");
                x++;
            } while (x != 11);
            Console.ReadLine() ;

            //casting je tam dva typy 
            //implicit casting 
            // char -> int -> long -> flat -> double

            int myInt = 78;
            double myDouble = myInt;  // automaticky int zmeni na double
            Console.WriteLine(myInt);  // vystup 78
            Console.WriteLine(myDouble);    // vystup 78

            // explicit casting
            // double -> float -> long -> int -> char
            // musi byt rucne dany typ v zavorkach v predu
            double myDouble2 = 9.5653;
            int myInt2 = (int)myDouble2;
            Console.WriteLine(myDouble2);  // vystup je 9.5653
            Console.WriteLine(myInt2);      // vystup je 9


            // type conversion method
            int myInt3 = 512;
            double myDouble3= 3.515;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt3));
            Console.WriteLine(Convert.ToDouble(myInt3));
            Console.WriteLine(Convert.ToInt64(myDouble3));
            Console.WriteLine(Convert.ToString(myBool));

            //user input 

            //type your username add press enter
            Console.WriteLine("Enter username: ");

            //create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            //print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            // If I will need get int information so I must write
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }
    }
}
