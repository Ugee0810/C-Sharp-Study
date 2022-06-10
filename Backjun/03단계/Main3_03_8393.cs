using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
합(8393)

문제
n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.

입력
첫째 줄에 n (1 ≤ n ≤ 10,000)이 주어진다.

출력
1부터 n까지 합을 출력한다.
 */

namespace Backjun._03단계
{
    internal class Main3_03_8393
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
