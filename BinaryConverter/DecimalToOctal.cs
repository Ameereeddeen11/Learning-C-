using System;
namespace BinaryConverter
{
    class DecimalToOctal
    {
        public void ConvertDecimalToOctal(int number)
        {
            string octal = "";
            while (number > 0)
            {
                int remainder = number % 8;
                number /= 8;
                octal += remainder;
            }
            DecimalToBinary decimalToBinary = new DecimalToBinary();
            decimalToBinary.ReverseString(octal);
        }
        public void ConvertOctalToDecimal(string input)
        {
            int fromOctal = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int index = input.Length - i - 1;
                fromOctal += (int)Char.GetNumericValue(input[i]) * (int)Math.Pow(8, index);
            }
            Console.WriteLine(fromOctal);
        }
    }
}
