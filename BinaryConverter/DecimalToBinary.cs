using System;
using System.Numerics;
namespace BinaryConverter
{
    class DecimalToBinary
    {
        public void ConvertDecimalToBinary(int number)
        {
            string binary = "";
            while (number > 0)
            {
                int remainder = number % 2;
                number /= 2;
                binary += remainder;
            }
            ReverseString(binary);
        }
        public void ConvertBinaryToDecimal(string input)
        {
            int decamal = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int index = input.Length - i - 1;
                decamal += (int)Char.GetNumericValue(input[i]) * (int)Math.Pow(2, index);
            }
            Console.WriteLine(decamal);
        }
        public void ReverseString(string binary)
        {
            char[] charArray = binary.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            Console.WriteLine(result);
        }
    }
}
