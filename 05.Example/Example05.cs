//Example 5: Multiply Two Floating Point Numbers in C# Console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example
{
    internal class Example05
    {
        static void Main0(string[] args)
        {
            float number1, number2, product;
            number1 = 12.45f;
            number2 = 10.74f;

            product = number1 * number2;

            Console.WriteLine("{0} * {1} = {2}", number1, number2, product);
            Console.ReadLine();
        }
    }
}
