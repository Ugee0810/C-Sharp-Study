//Example 3: C# Program to Add Two Integers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example
{
    internal class Example03
    {
        static void Main0(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine("Calculate the sum of two numbers:");
            Console.Write("Input number1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.Write("Result:" + sum);

            Console.ReadKey();
        }
    }
}
