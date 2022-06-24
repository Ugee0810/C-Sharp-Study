using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class Main07_03_1193_N
    {
        static void Main1()
        {
            int x = int.Parse(Console.ReadLine());

            int level = 1;
            int temp = 1;

            while (temp < x)
            {
                level++;
                temp += level;
            }
            int den = temp - x + 1;
            
            if (level % 2 == 0)
            {
                // 짝수(분자++ 분모--)
                Console.WriteLine($"{level + 1 - den} / {den}");
            }
            else
            {
                // 홀수(분자-- 분모++)
                Console.WriteLine($"{den} / {level + 1 - den}");
            }
        }
    }
}
