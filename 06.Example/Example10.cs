//Example 10: Area and Perimeter of Circle in C# Console Application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example._01.Basic
{
    internal class Example10
    {
        static void Main0(string[] args)
        {
            double r, perimeter, area;
            Console.Write("Please write the radius of your circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * 3.14 * r;
            area = 3.14 * Math.Pow(r, 2); //area = 3.14 * r * r;
            Console.WriteLine("=============================================");
            Console.WriteLine("The perimeter of yor circle : {0}", perimeter);
            Console.WriteLine("The area of yor circle : {0}", area);
            Console.ReadKey();
        }
    }
}
