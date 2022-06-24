using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
별 찍기 - 1

문제
첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

입력
첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.

출력
첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.
 */

namespace Backjun._03단계
{
    internal class Main3_09_2438
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int start = 1; start <= n; start++)
            {
                for (int end = 1; end <= start; end++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
