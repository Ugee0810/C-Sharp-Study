using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/28
 * 이름 : 송환욱
 * 내용 : [총정리 문제]윤년 판별하기
 */

namespace Test.Final2
{
    internal class _2_01
    {
        static void Main1(string[] args)
        {
            Console.Write("연도 입력 : ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("{0}는 윤년 입니다.", year);
            }
            else
            {
                Console.WriteLine("{0}는 평년 입니다.", year);
            }

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0}는 윤년 입니다.", year);
            }
            else
            {
                Console.WriteLine("{0}는 평년 입니다.", year);
            }
        }
    }
}
