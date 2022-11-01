using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/28
 * 이름 : 송환욱
 * 내용 : [총정리 문제]1000까지 소수 출력하기
 */

namespace Test.Final2
{
    internal class _2_06
    {
        static void Main1(string[] args)
        {
            int index;
            int primes = 0;

            for (int i = 2; i < 1000; i++)
            {
                for (index = 0; index < i; index++)
                {
                    if (i % index == 0)
                    {
                        break;
                    }
                }
                if (index == i)
                {
                    primes++;
                    Console.Write("{0,5}{1}", i, primes % 15 == 0 ? "\n" : "");
                }
            }
            Console.WriteLine("\n2부터 1000 사이의 소수의 개수 : {0}개", primes);
        }
    }
}
