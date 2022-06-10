using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
기찍 N(2742)

문제
자연수 N이 주어졌을 때, 1부터 N까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.

입력
첫째 줄에 100,000보다 작거나 같은 자연수 N이 주어진다.

출력
첫째 줄부터 N번째 줄 까지 차례대로 출력한다.
 */

namespace Backjun._03단계
{
    internal class Main3_06_2742_N
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                --a;
                sb.AppendLine(a.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
