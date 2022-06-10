using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
두 수 비교하기(1330)

문제
두 정수 A와 B가 주어졌을 때, A와 B를 비교하는 프로그램을 작성하시오.

입력
첫째 줄에 A와 B가 주어진다. A와 B는 공백 한 칸으로 구분되어져 있다.

출력
첫째 줄에 다음 세 가지 중 하나를 출력한다.

A가 B보다 큰 경우에는 '>'를 출력한다.
A가 B보다 작은 경우에는 '<'를 출력한다.
A와 B가 같은 경우에는 '=='를 출력한다.

제한
-10,000 ≤ A, B ≤ 10,000
 */

namespace House.백준.Lv2
{
    internal class Main2_01_1330
    {
        static void Main1(string[] args)
        {
            String[] strings = Console.ReadLine().Split();
            int A = int.Parse(strings[0]);
            int B = int.Parse(strings[1]);

            if (A > B)
            {
                Console.WriteLine(">");
            }
            if (A < B)
            {
                Console.WriteLine("<");
            }
            if (A == B)
            {
                Console.WriteLine("==");
            }
        }
    }
}