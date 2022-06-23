using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers.Lv1
{
    internal class _12969
    {
        static void Main1(string[] args)
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine("{0}", a + b);

            for (int j = 0; j < b; j++)
            {
                for (int i = 0; i < a; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
