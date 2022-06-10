using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/10
 * 이름 : 송환욱
 * 내용 : 유클리드 호제법 최대공약수 연습문제
 */

namespace Test._2
{
    internal class _2_008
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("  1과   5의 최대공약수 : " + Gcd(1, 5));
            Console.WriteLine("  3과   6의 최대공약수 : " + Gcd(3, 6));
            Console.WriteLine(" 12과  18의 최대공약수 : " + Gcd(12, 18));
            Console.WriteLine(" 60과  24의 최대공약수 : " + Gcd(60, 24));
            Console.WriteLine("192과 162의 최대공약수 : " + Gcd(192, 162));
        }

        public static int Gcd(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return Gcd(b, a % b);
            }
        }
    }
}