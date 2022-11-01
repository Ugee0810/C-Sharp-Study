//Example 17: Find Number is Even or Odd using if else Statement in C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example._01.Basic
{
    internal class Example17_2
    {
        static bool IsEvenNumber(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main0(string[] args)
        {
            int n;
            Console.Write("Enter an integer : ");
            n = Int32.Parse(Console.ReadLine());

            if (IsEvenNumber(n))
            {
                Console.WriteLine("{0} is even", n);
            }
            else
            {
                Console.WriteLine("{0} is odd", n);
            }

            Console.ReadKey();
        }
    }
}
