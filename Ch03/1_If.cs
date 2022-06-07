using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/03
 * 이름 : 송환욱
 * 내용 : 조건문 실습 교재 p127
 */

/*
namespace Ch03
{
    internal class _1_If
    {
        static void Main(string[] args)
        {
            // if
            int num1 = 1;
            int num2 = 2;

            if (num1 < num2) 
            {
                // 조건이 True일 시 실행
                Console.WriteLine("num1은 num2보다 작다.");
            }

            if (num1 > 1) // 결과가 false if 실행 X
            {
                Console.WriteLine("num1은 1보다 크다.");
            }

            if (num1 > 0) // 첫 번째 조건
            {
                if (num2 > 1) // 두 번째 조건
                {
                    Console.WriteLine("num1은 0보다 크고, num2는 1보다 크다.");
                }
            }
            
            // if ~ else
            if (num1 > 0)
            {
                Console.WriteLine("if ~ else : num1은 0보다 크다.");
            }
            else
            {
                Console.WriteLine("if ~ else : num1은 0보다 크지 않다.");
            }

            // if ~ else if ~ else
            int n1 = 10, n2 = 20, n3 = 30, n4 = 40;

            if (n1 > n2) // 조건 1
            {
                Console.WriteLine("n1 > n2");
            }
            else if (n2 > n3) // 조건 2
            {
                Console.WriteLine("n2 > n3");
            }
            else if (n3 > n4) // 조건 3
            {
                Console.WriteLine("n3 > n4");
            }
            else // false
            {
                Console.WriteLine("n4 > n3, n2, n1");
            }
        }
    }
}
*/