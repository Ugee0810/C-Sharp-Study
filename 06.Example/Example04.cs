//Example 4: C# Program to Multiply two Floating Point Numbers Entered by User

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example
{
    internal class Example04
    {
        static void Main0(string[] args)
        {
            float number1, number2, product;

            Console.Write("Enter a number1:");
            number1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter a number2:");
            number2 = Convert.ToSingle(Console.ReadLine());

            product = number1 * number2;

            Console.WriteLine("{0} * {1} = {2}", number1, number2, product);
            Console.ReadLine();
        }
    }
}
