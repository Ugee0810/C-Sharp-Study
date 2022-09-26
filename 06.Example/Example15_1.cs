// Example 15: Convert Dollars to Cents in C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example._01.Basic
{
    //Solution 1: Calculate in Main Method 
    internal class Example15_1
    {
        static void Main0(string[] args)
        {
            double dollar_amount;
            int cents;
            // int compute_cents;

            Console.Write("Enter dollar amount :");
            dollar_amount = Convert.ToDouble(Console.ReadLine());

            cents = (int)(dollar_amount * 100);

            Console.WriteLine("{0} $  = {1} ¢", dollar_amount, cents);

            Console.ReadLine();
        }
    }
}
