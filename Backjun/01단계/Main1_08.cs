using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._01단계
{
    internal class Main1_08
    {
        static void Main1(string[] args)
        {
            string[] asdsad = Console.ReadLine().Split();

            int A = int.Parse(asdsad[0]);
            int B = int.Parse(asdsad[1]);

            if (0 < A && B < 10)
            {
                Console.WriteLine(A / B);
            }
        }
    }
}
