using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 송환욱
 * 내용 : 피라미드 출력 연습문제
 */

namespace Test._1
{
    internal class _1_008
    {
        static void Main1(string[] args)
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 5; j > i + 1; j--)
                {
                    Console.Write(" ");
                }
                
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
