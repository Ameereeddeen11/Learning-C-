using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is an array where I can put only strings
            string[] languages = {"Hello", "Halo", "Ahoj", "Salom"};
            //this is        first  , second, third , fourth  elements
            //this is an array where I can put only numbers intergiers
            int[] myNum = { 12, 72, 45, 55, 46};
            //this is      first, second etc. elements

            Console.WriteLine(languages[0]); //out Hello
            Console.WriteLine(myNum[3]);  //out 55

            //change element
            languages[2] = "Cau";  //Ahoj is change to Cau
            Console.WriteLine(languages[2]); //now outputs Cau

            //array legth 
            Console.WriteLine(languages.Length); //outputs 4
            Console.WriteLine(myNum.Length);   //output 5

            //if you create an array you can specified size 
            string[] cars = new string[2] {"BWM", "Mersedes-Benz"};

            Console.WriteLine("This is loop an arrays");
            //loop an arrays
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            //this is foreach loop 
            Console.WriteLine("This is foreach loop");
            foreach(string s in languages)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("This is sort an arrays");
            //Sort an array
            Array.Sort(languages);
            foreach(string l in languages)
            {
                Console.WriteLine(l);
            }

            int[] myNumber_2 = { 46, 4415, 58521, 4821, 123 };
            Console.WriteLine(myNumber_2.Max());
            Console.WriteLine(myNumber_2.Min());
            Console.WriteLine(myNumber_2.Sum());

            //multidimensional arrays 
            Console.WriteLine("Multidimensional arrays");
            int[,] numbers = { { 0, 1, 2, }, { 3, 4, 5 } };
            int k = numbers[0, 2];
            Console.WriteLine("number from first row(0) and third column(2) is " + k); //outputs 2

            //you can change elements of a 2D array
            numbers[1, 1] = 3;   //change value to 3
            Console.WriteLine("number from first row(0) and third column(2) is " + numbers[1, 1]);  //outputs 3
            
            //loop through a 2D array
            /*int[,] numbers_2 = { { 65, 18, 69}, { 98, 74, 35} };
            for (int x = 0; x < numbers_2.GetLength(0); x++)
            {
                for (int y = 0; y < numbers_2.GetLength(1); y++)
                {
                    Console.WriteLine(numbers_2[x, y]);
                }
            }*/
            /*//this is another opportunity with foreach
            Console.WriteLine("this is foreach loop a 2D array");
            foreach(int g in numbers_2)
            {
                Console.WriteLine(g);
            }
            Console.ReadLine();*/

            //this is 3D array
            int[,,] numbers_3 = { { { 78, 96 }, { 65, 48 } } };
            for (int e = 0; e < numbers_3.GetLength(0); e++)
            {
                for (int w = 0; w < numbers_3.GetLength(1); w++)
                {
                    for (int r = 0; r < numbers_3.GetLength(2); r++)
                    {
                        Console.WriteLine(e + "-" + w + "-" + r + ":" +numbers_3[e,w,r]);
                    }
                }
            }
        }
    }
}
