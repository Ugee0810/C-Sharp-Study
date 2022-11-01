using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 송환욱
 * 내용 : Method 실습 교재 p265
 * 메모 : C# Method 이름의 시작은 항상 대문자
 */

namespace Ch04
{
    internal class _1_Method
    {
        static void Main1(string[] args)
        {
            //////Method 호출
            //(1)
            int r1 = F(1);
            int r2 = F(2);
            int r3 = F(3);

            Console.WriteLine("r1 : "+r1); //2x + 3 = 5
            Console.WriteLine("r2 : "+r2); //3x + 3 = 7
            Console.WriteLine("r3 : "+r3); //4x + 3 = 9

            //(2)
            int t1 = Sum(1, 10);
            int t2 = Sum(1, 100);
            int t3 = Sum(start:1, end:1000);

            Console.WriteLine("t1 : "+t1);
            Console.WriteLine("t2 : "+t2);
            Console.WriteLine("t3 : "+t3);

        } //Main End

        //Class Method 정의(static 함수)
        //(1)
        public static int F(int x) //return되는 타입을 int로 선언 ()안은 매개변수(숫자 투입)
        {
            int y = 2 * x + 3;
            return y;
        }

        //(2)
        public static int Sum(int start, int end)
        {
            int total = 0;

            for (int k = start; k <= end; k++)
            {
                total += k;
            }
            return total;
        }
    }
}
