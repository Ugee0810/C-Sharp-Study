// Example 15: Convert Dollars to Cents in C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example._01.Basic
{
    //Solution 2: Calculate with Custom Method
    internal class Example15_2
    {
        static void Main0(string[] args)
        {
            double dollar_amount;
            int cents;
            // int compute_cents;

            Console.Write("Enter dollar amount :");
            dollar_amount = Convert.ToDouble(Console.ReadLine());

            cents = compute_cents(dollar_amount);

            Console.WriteLine("{0} $  = {1} ¢", dollar_amount, cents);

            Console.ReadLine();
        }

        static int compute_cents(double dollar_amount)
        {
            return (int)(dollar_amount * 100);
        }
    }
}
