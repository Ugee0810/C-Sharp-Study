using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/10
 * 이름 : 송환욱
 * 내용 : 피보나치 수열 연습문제
 */

namespace Test._2
{
    internal class _2_010
    {
        static void Main1(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Fibo(i) + " ");
            }
        }

        public static int Fibo(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}