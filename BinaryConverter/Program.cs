using BinaryConverter;
using System;
namespace BinaryCoverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool response = false;
            while (!(response)) 
            { 
                Console.WriteLine("Hello, I can converter");
                Console.WriteLine("1. Decimal to Binary");
                Console.WriteLine("2. Binary to Decimal");
                Console.WriteLine("3. Decimal to Octal");
                Console.WriteLine("4. Octal to Decimal");
                Console.WriteLine("5. Decimal to Hexadecimal");
                Console.WriteLine("6. Hexadecimal to Decimal");
                int choice = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter number:");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                DecimalToBinary decimalToBinary = new DecimalToBinary();
                DecimalToOctal decimalToOctal = new DecimalToOctal();
                DecimalToHexadecimal decimalToHexadecimal = new DecimalToHexadecimal();
                switch (choice)
                {
                    case 1:
                        decimalToBinary.ConvertDecimalToBinary(number);
                        break;
                    case 2:
                        decimalToBinary.ConvertBinaryToDecimal(input);
                        break;
                    case 3:
                        decimalToOctal.ConvertDecimalToOctal(number);
                        break;
                    case 4:
                        decimalToOctal.ConvertOctalToDecimal(input);
                        break;
                    case 5:
                        decimalToHexadecimal.ConvertDecimalToHexadecimal(number);
                        break;
                    case 6:
                        decimalToHexadecimal.ConvertHexadecimalToDecimal(input);
                        break;
                }
                Console.WriteLine("Do you want to convert again?");
                Console.WriteLine("If yes enter 1 if No enter 0");
                int responseInt = Convert.ToInt16(Console.ReadLine());
                if (responseInt == 0)
                {
                    response = true;
                }
                else if (responseInt == 1)
                {
                    response = false;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}