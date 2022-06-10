using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
A+B - 3(10950)

문제
두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

입력
첫째 줄에 테스트 케이스의 개수 T가 주어진다.

각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)

출력
각 테스트 케이스마다 A+B를 출력한다.
 */

namespace Backjun._03단계
{
    internal class Main3_02_10950
    {
        static void Main1(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split();
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);

                Console.WriteLine(a + b);
            }
        }
    }
}
