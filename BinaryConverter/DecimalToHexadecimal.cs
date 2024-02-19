using System;
namespace BinaryConverter
{
    class DecimalToHexadecimal
    {
        public void ConvertDecimalToHexadecimal(int number)
        {
            string hexadecimal = "";
            while(number > 0)
            {
                int remainder = number % 16;
                number /= 16;
            }
            DecimalToBinary decimalToBinary = new DecimalToBinary();
            decimalToBinary.ReverseString(hexadecimal);
        }
        public void ConvertHexadecimalToDecimal(string input)
        {
            int fromHexadecimal = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int index = input.Length - i - 1;
                fromHexadecimal += (int)Char.GetNumericValue(input[i]) * (int)Math.Pow(2, index);
            }
            Console.WriteLine(fromHexadecimal);
        }
    }
}
