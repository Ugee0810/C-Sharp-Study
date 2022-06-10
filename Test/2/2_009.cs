using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/10
 * 이름 : 송환욱
 * 내용 : 팩토리얼 연습문제
 */

namespace Test._2
{
    internal class _2_009
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("3! = " + Factorial(3));
            Console.WriteLine("4! = " + Factorial(4));
            Console.WriteLine("5! = " + Factorial(5));
        }

        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}