using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/10
 * 이름 : 송환욱
 * 내용 : 메서드 연습문제
 */

namespace Test._2
{
    internal class _2_006
    {
        public static void Intro()
        {
            Console.WriteLine("******* START *******");
            Console.WriteLine("2개의 정수를 입력");
        }

        public static int Input(char name)
        {
            Console.Write("변수 " + name + " 값 입력 : ");
            int value = int.Parse(Console.ReadLine());
            return value;
        }

        public static void Result(int val)
        {
            Console.WriteLine("덧셈 결과 : " + val);
            Console.WriteLine("******* END *******");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main1(string[] args)
        {
            //Type4
            Intro();

            int a = Input('a');
            int b = Input('b');

            int output = Add(a, b);
            Result(output);
        }
    }
}
