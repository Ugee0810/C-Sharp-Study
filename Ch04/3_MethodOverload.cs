using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 송환욱
 * 내용 : MethodType 실습 교재 p265
 * 메모 : 메서드 오버로딩(MethodOverloading)
 * - 같은 이름의 메서드를 매개변수(parameter)로 구분한 메서드
 * - 메서드 반환 타입은 오버로딩에 영향을 미치지 않는다.
 */

namespace Ch04
{
    internal class _3_MethodOverload
    {
        static void Main1(string[] args)
        {
            // public static int Plus(int a, int b) 호출
            int r1 = Plus(1, 2);

            // public static int Plus(int a, int b, int c) 호출
            int r2 = Plus(1, 2, 3);

            // public static double Plus(double a, double b) 호출
            double r3 = Plus(1.1, 2.1);

            // public static string Plus(string a, string b) 호출
            string r4 = Plus("Hello", "World");

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static string Plus(string a, string b)
        {
            return a + b;
        }
    }
}