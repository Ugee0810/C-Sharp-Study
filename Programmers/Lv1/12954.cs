using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers.Lv1
{
    internal class _12954
    {
        static void Main1(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            long[] answer = new long[n];

            for (long i = 0; i < n; ++i)
            {
                if (i == 0)
                {
                    answer[i] = x;
                    continue;
                }
                answer[i] = x * (i + 1);
            }
            Console.WriteLine(answer);;
        }
    }
}
