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
            //Console.WriteLine("Hello, there!");
            //Console.Write("Here Amiriddin ");
            //Console.Write("Abdullaev");

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
            Console.WriteLine("This is int variable " + mySecondInt + " which was casted from double. That means this is explicit casting (manually): converting a larger type to a smaller type size");

            // convertion method
            Console.WriteLine("This is int variable " + Convert.ToInt32(myDoubleToCasting) + " which was converted from double");
            Console.WriteLine("This is long variable " + Convert.ToInt64(myIntToCasting) + " which was converted from int");

            // user input
            Console.WriteLine("What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + userName);
            // ReadLine method returns only string value
            // But you can convert value to int by using Convert.To method 
            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I am also " + age + " years old");

            // Operators 
            int x1 = 645;
            int y1 = 432;
            int z1 = 5;
            int sum1 = x1 + y1;
            int result2 = x1 - y1;
            int result3 = x1 * y1;
            int result4 = x1 / y1;
            int result5 = x1 % y1;
            Console.WriteLine("Sum of variables x1 and y1 is " + sum1);
            Console.WriteLine("Subtraction of variables x1 and y1 is " + result2);
            Console.WriteLine("Multiplication of variables x1 and y1 is " + result3);
            Console.WriteLine("Division of variables x1 and y1 is " + result4 + " and remain " + result5);
            
            // assignment operators example
            x1 += 5;
            y1 -= 5;
            x *= 5;
            y /= 5;
            Console.WriteLine("If we add x1 with 5 it will equel " + x1);
            Console.WriteLine("If we subtract y1 with 5 it will equel " + y1);
            Console.WriteLine("If we multiply x with 5 it will equel " + x);
            Console.WriteLine("If we divit y with 5 it will equel " + y);

            // Comparison operators 
            // this operators return only true or false result 
            int x2 = 675;
            int y2 = 483;
            bool comparison = x2 > y2;
            Console.WriteLine("Is x2 variable greater then y2 " + comparison);

            // logical operators 
            // it also give us only true or false value 
            Console.WriteLine("Is x2 variable greater then 435 and also lesser then 765? " + (x2 > 435 && x2 < 765)); // returns True because both statements are True
            Console.WriteLine("Is x2 variable lesser then 5 or also lesser then 5? " + (x2 < 5 || x2 < 5)); // returns False because one of the statements is False 
            Console.WriteLine("Is x2 variable greater then 448 and also lesser then 843? " + (!(x2 > 448 && x2 < 843))); // returns False because even the both statements are True  

            // Math 
            Console.WriteLine("Give me two numbers I will show which is greater and which is lesser");
            int user_input_1 = Convert.ToInt32(Console.ReadLine());
            int user_input_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is the greatest " + Math.Max(user_input_1, user_input_2));
            Console.WriteLine("Is the lessest " + Math.Min(user_input_1, user_input_2));
            Console.WriteLine("Give me some number to find square root of that number");
            long user_input_3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Square root of " + user_input_3 + " is " + Math.Sqrt(user_input_3));
            Console.WriteLine("Now give me some number to find absolute value of some number");
            long user_input_4 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Absolute value of " + user_input_4 + " number is " + Math.Abs(user_input_4));
            Console.WriteLine("Give me sum decimals number to find the nearest whole number to that");
            double user_input_5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The nearthest whole number to " + user_input_5 + " is " + Math.Round(user_input_5));

            Console.ReadLine();
        }
    }
}