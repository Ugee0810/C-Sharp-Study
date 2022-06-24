using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
별 찍기 - 2

문제
첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.

입력
첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.

출력
첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.

예제 출력 1
    *
   **
  ***
 ****
*****
 */
namespace Backjun._03단계
{
    internal class Main3_10_2439_N
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star = 1;

            //띄어쓰기가 n만큼 시작하고 별은 1부터 시작
            //다음 반복 땐 n-1 별은 1+1
            for (int a = 1; a <= n; a++)
            {
                for (int i = n; i >= 1; i--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
