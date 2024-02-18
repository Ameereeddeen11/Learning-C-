using BinaryConverter;
using System;
namespace BinaryCoverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I can converter");
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Binary to Decimal");
            Console.WriteLine("3. Decimal to Hexadecimal");
            Console.WriteLine("4. Hexadecimal to Decimal");
            Console.WriteLine("5. Decimal to Octal");
            Console.WriteLine("6. Octal to Decimal");
            int choice = Convert.ToInt32(Console.ReadLine());
            DecimalToBinary decimalToBinary = new DecimalToBinary();
            DecimalToOctal decimalToOctal = new DecimalToOctal();
            DecimalToHexadecimal decimalToHexadecimal = new DecimalToHexadecimal();
            switch (choice)
            {
                case 1:
                    decimalToBinary.ConvertDecimalToBinary();
                    break;
                case 2:
                    decimalToBinary.ConvertBinaryToDecimal();
                    break;
                case 3:
                    decimalToHexadecimal.ConvertDecimalToHexadecimal();
                    break;
                case 4:
                    decimalToHexadecimal.ConvertHexadecimalToDecimal();
                    break;
                case 5:
                    decimalToOctal.ConvertDecimalToOctal();
                    break;
                case 6:
                    decimalToOctal.ConvertOctalToDecimal();
                    break;
            }
        }
    }
}