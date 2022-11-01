using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P168
    {
        static void Main1(string[] args)
        {
            //for 반복문으로 곱셈
            int n1 = 1;
            for (int i = 1; i <= 20; i++)
            {
                n1 *= i;
            }
            Console.WriteLine(n1);

            //한글 전부 출력
            for (int k = '가'; k <= '힣'; k++)
            {
                Console.WriteLine((char)k);
            }
        }
    }
}
