//Example 11: Program to finds the average of 3 numbers in C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example._01.Basic
{
    internal class Example11
    {
        static void Main0(string[] args)
        {
            int number1, number2, number3, avarage;

            Console.Write("Enter 1st number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number :");
            number3 = Convert.ToInt32(Console.ReadLine());

            avarage = (number1 + number2 + number3) / 3;

            Console.Write("Avarage of three numbers is {0}", avarage);

            Console.ReadKey();
        }
    }
}
