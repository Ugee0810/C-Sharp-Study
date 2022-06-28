using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/28
 * 이름 : 송환욱
 * 내용 : [총정리 문제]저금일 계산하기
 */

namespace Test.Final2
{
    internal class _2_08
    {
        static void Main1(string[] args)
        {
            int sum   = 0;
            int days  = 1;
            int money = 1000;

            while (true)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days, money, sum);

                if (sum >= 1000000)
                {
                    break;
                }
                days++;
                money *= 2;
            }
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);
        }
    }
}
