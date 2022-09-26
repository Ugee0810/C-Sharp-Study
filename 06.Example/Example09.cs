//Example 9: C# Square Area and Perimeter Calculator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example._01.Basic
{
    internal class Example09
    {
        static void Main0(string[] args)
        {
            int squareheight, area, perimeter;
            Console.Write("What is the height of your square? :");
            squareheight = Convert.ToInt32(Console.ReadLine());
            area = squareheight * squareheight;
            perimeter = 4 * squareheight;
            Console.WriteLine("Area : {0}\nPerimeter : {1}", area, perimeter); // "\n" --> new line
            Console.ReadKey();
        }
    }
}
