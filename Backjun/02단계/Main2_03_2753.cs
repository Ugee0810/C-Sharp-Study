using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
윤년(2753)

문제
연도가 주어졌을 때, 윤년이면 1, 아니면 0을 출력하는 프로그램을 작성하시오.

윤년은 연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때이다.

예를 들어, 2012년은 4의 배수이면서 100의 배수가 아니라서 윤년이다. 1900년은 100의 배수이고 400의 배수는 아니기 때문에 윤년이 아니다. 하지만, 2000년은 400의 배수이기 때문에 윤년이다.

입력
첫째 줄에 연도가 주어진다. 연도는 1보다 크거나 같고, 4000보다 작거나 같은 자연수이다.

출력
첫째 줄에 윤년이면 1, 아니면 0을 출력한다.
 */

/*
 * 풀이
 * 윤년(1) = 4의 배수 && 100의 배수가 아닐 때 || 400의 배수일 때
 * 2012년 = 윤년 (4의 배수이고, 100의 배수가 아님)
 * 1900년 = 일반 (100의 배수이고, 400의 배수는 아님)
 * 2000년 = 윤년 (400의 배수)
 */

namespace House.백준.Lv2
{
    internal class Main2_03_2753
    {
        static void Main1(string[] args)
        {
            int year = 0;
            year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}