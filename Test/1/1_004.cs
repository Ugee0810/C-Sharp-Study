using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 송환욱
 * 내용 : 증감 연산자 연습문제
 */

namespace Test._1
{
    internal class _1_004
    {
        static void Main1(string[] args)
        {
            int num = 1;
            int result;

            result = num++;
            Console.WriteLine("result1 : " + result);

            result = ++num;
            Console.WriteLine("result2 : " + result);

            result = num--;
            Console.WriteLine("result3 : " + result);

            result = --num;
            Console.WriteLine("result4 : " + result);
        }
    }
}
