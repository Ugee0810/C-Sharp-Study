﻿//Example 7: Program To Calculate the Simple Interest in C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example
{
    internal class Example07
    {
        static void Main0(string[] args)
        {
            int P, T;
            float R, SI;
            Console.Write("Enter Amount :");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate :");
            R = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Time :");
            T = Convert.ToInt32(Console.ReadLine());
            SI = P * R * T / 100;
            Console.WriteLine("Interest is :{0}", SI);
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
