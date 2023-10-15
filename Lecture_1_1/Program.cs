using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number:");
            int number1 = Convert.ToInt32(Console.ReadLine()); //readline string değer döndürür. Bu nedenle int'e  çevirdim 
            Console.WriteLine("Please enter your second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1/number2;

            Console.WriteLine($"Result: {result}");

            int[] number = new int[3];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"{i+1}:{number[i]}");
            }
           
        }

    }
}
