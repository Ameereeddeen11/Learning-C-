using System;
namespace Repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Some comment is here. It is for single line comment
            /*
                More comment. It is for multi-line comment
            */
            Console.WriteLine("Hello, there!");
            Console.Write("Here Amiriddin ");
            Console.Write("Abdullaev");

            // Variables 
            string myString = "Hello";
            Console.WriteLine("This is string variable " + myString);
            char myChar = 'A';
            Console.WriteLine("This is char variable (it stores only characters) " + myChar);
            int myInt = 100;
            Console.WriteLine("This is int variable (stores number withouot decimals) " + myInt);
            double myDouble = 5.78D;
            Console.WriteLine("This is double variable (stores number with decimals) " + myDouble);
            bool myBool = false;
            Console.WriteLine("This is bool variable " + myBool);

            // int varibale
            int myNumber = 78;
            myNumber = 0; // Now the variable myNumber is 0
            Console.WriteLine("Your number is " + myNumber);
            // constants are for to against overwrite existing variable
            const int myNum = 5;
            // now you can't change myNum variable
            Console.WriteLine(myNum);
            int x = 68, y = 43, z = 65;
            int sum = x + y + z;
            Console.WriteLine("Sum of x,y,z variables is " + sum);

            // casting 
            int myIntToCasting = 9;
            double myDoubleToCasting = myIntToCasting;
            Console.WriteLine("This is double variable " + myDoubleToCasting + " which was casted from int. That means this implicit casting (automatically): converting a smaller type to a larger type size");
            int mySecondInt = (int)myDoubleToCasting;
            Console.WriteLine("This is int variable " +  mySecondInt + " which was casted from double. That means this is explicit casting (manually): converting a larger type to a smaller type size");

            // convertion method
            Console.WriteLine("This is int variable " + Convert.ToInt32(myDoubleToCasting) + " which was converted from double");
            Console.WriteLine("This is long variable " + Convert.ToInt64(myIntToCasting) + " which was converted from int");
            Console.ReadLine();
        }
    }
}