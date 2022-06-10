using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
N찍기(2741)

문제
자연수 N이 주어졌을 때, 1부터 N까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.

입력
첫째 줄에 100,000보다 작거나 같은 자연수 N이 주어진다.

출력
첫째 줄부터 N번째 줄 까지 차례대로 출력한다.

풀이
얼핏 보면 쉬운 문제처럼 보이지만 코드를 제출하면 시간 초과에 걸리게 되는 문제다.
Console.WriteLine은 (메모리상 변수의 조작에 비하면) 시간이 많이 걸리는 작업이다. 따라서 WriteLine을 반복적으로 여러번 호출하면 시간이 오래 걸리게 되고, 시간 초과가 된다.
(N=100,000에 대해 테스트 해보자. 100,000까지 모두 찍히는데 생각보다 많은 시간이 필요하다.)

따라서 WriteLine을 최소한으로 호출하면서 1부터 N까지의 값을 모두 출력하기 위해서 StringBuilder를 사용하였다.
StringBuilder에 값을 이어붙이면서 1부터 N까지의 모든 숫자를 이어붙인 String 한덩어리를 한번에 출력하는 것이다.
 */

namespace Backjun._03단계
{
    internal class Main3_05_2741_N
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}