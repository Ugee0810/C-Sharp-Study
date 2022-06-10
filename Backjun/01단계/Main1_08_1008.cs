using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
문제
두 정수 A와 B를 입력받은 다음, A/B를 출력하는 프로그램을 작성하시오.

입력
첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)

출력
첫째 줄에 A/B를 출력한다. 실제 정답과 출력값의 절대오차 또는 상대오차가 10-9 이하이면 정답이다.
*/

namespace Backjun._01단계
{
    internal class Main1_08_1008
    {
        static void Main1(string[] args)
        {
            string[] strs = Console.ReadLine().Split();

            double a = double.Parse(strs[0]);
            double b = double.Parse(strs[1]);

            if (0 < a && b < 10)
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
