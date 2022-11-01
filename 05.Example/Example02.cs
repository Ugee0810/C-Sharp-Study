//Example 2: C# Program to Print an Integer Entered by User

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example
{
    internal class Example02
    {
        static void Main0(string[] args)
        {
            int number;
            Console.Write("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered : {0}", number);
            Console.ReadLine();
        }
    }
}