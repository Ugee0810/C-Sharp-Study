//Example 13: C# Math.Pow Negative Exponent Example

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example._01.Basic
{
    internal class Example13
    {
        static void Main0(string[] args)
        {
            double baseNumber, powerNumber;

            Console.Write("Enter base number :");
            baseNumber = Convert.ToDouble(Console.ReadLine()); //2
            Console.Write("Enter exponent number :");
            powerNumber = Convert.ToDouble(Console.ReadLine()); //-2

            double returnNumber = Math.Pow(baseNumber, powerNumber);
            Console.WriteLine("{0}^{1} = {2}", baseNumber, powerNumber, returnNumber);

            Console.ReadLine();

        }
    }
}
