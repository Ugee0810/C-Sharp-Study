using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 송환욱
 * 내용 : 반복문 실습 교재 p157
 */

namespace Ch03
{
    internal class _3_For
    {
        static void Main1(string[] args)
        {
            //for문
            /*
                for (초기식; 조건식; 증감식)
                {

                }
            */

            for (int i = 1; i<=5; i++)
            {
                Console.WriteLine("{0}회 반복...", i);
            }

            //1부터 10까지의 합   
            int sum = 0;

            for (int k = 1; k<=10; k++)
            {
                //sum
                sum += k; //sum = sum + k 
            }
            Console.WriteLine("1부터 10까지의 합 : " + sum);

            //1부터 10까지 짝수합
            int tot = 0;

            for (int k = 1; k <= 10; k++)
            {
                if (k % 2 == 0)
                {
                    tot += k;
                }
            }
            Console.WriteLine("1부터 10까지의 짝수합 : " + tot);

            //중첩 for문
            for (int a = 1; a <= 3; a++)
            {
                Console.WriteLine("a : " + a);
                for (int b = 1; b <= 4; b++)
                {
                    Console.WriteLine("b : " + b);
                    for (int c = 1; c <= 5; c++)
                    {
                        Console.WriteLine("c : " + c);
                    }
                }
            }

            //구구단
            for (int x = 2; x < 10; x++)
            {
                Console.WriteLine("{0}단 시작", x);
                for (int y = 1; y < 10; y++)
                {
                    int z = x * y;
                    Console.WriteLine("{0} x {1} = {2}", x, y, z);
                }
            }

            //별삼각형
            for (int start = 1; start <= 10; start++)
            {
                for (int end = 10; end >= start; end--) //start가 1일 때 1회, 2일 때 2회...
                {
                    Console.Write("★");
                }
                Console.WriteLine();
            }
        }
    }
}