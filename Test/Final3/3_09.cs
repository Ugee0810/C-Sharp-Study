using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/29
 * 이름 : 송환욱
 * 내용 : [총정리 문제]메서드 오버로딩
 */

namespace Test.Final3
{
    internal class _3_09
    {
        static void Main1(string[] args)
        {
            Print(10);
            Print(0.123);
            Print("Sum = ", 123.4);
        }

        public static void Print(double x)
        {
            Console.WriteLine(x);
        }

        public static void Print(string s, double x)
        {
            Console.WriteLine(s+x);
        }

        public static void Print(int x)
        {
            Console.WriteLine(x);
        }
    }
}
