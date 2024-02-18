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
            //Console.WriteLine("This is convert from Binary to Decimal");
            int decamal = 0;
            int lenght = input.Length;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            foreach (char bit in result)
            {
                if (bit == '1')
                {
                    int index = input.IndexOf(bit); 
                    int power = lenght - (index + 1);
                    decamal += (int)Math.Pow(2, index);
                }
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
