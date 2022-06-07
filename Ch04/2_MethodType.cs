using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 송환욱
 * 내용 : MethodType 실습 교재 p265
 */
/*
namespace Ch04
{
    internal class _2_MethodType
    {
        static void Main(string[] args)
        {
            //Type1 호출
            double y1 = Type1(0.1); //인자값 0.1 대입
            double y2 = Type1(1.2); //인자값 1.2 대입

            Console.WriteLine("y1 : "+y1);
            Console.WriteLine("y2 : "+y2);

            //Type2 호출 : 리턴(반환값)이 없으므로 대입연산자 필요 없음
            Type2(true);
            Type2(false);

            //Type3 호출
            string result = Type3();
            Console.WriteLine("Type3 Result : "+result);

            //Type4 호출
            Type4();

        } //Main End


        //Type1 : 매개변수 O, 리턴 값 O
        public static double Type1(double x)
        {
            double y = x + 3.14;
            return y;
        }

        //Type2 : 매개변수 O, 리턴 값 X(void)
        public static void Type2(bool status)
        {
            if (status)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        //Type3 : 매개변수 X, 리턴 값 O
        public static string Type3()
        {
            int n1 = 1, n2 = 2;
            if (n1 > n2)
                return ("n1 > n2");
            else
                return ("n1 < n2");
        }

        //Type4 : 매개변수 X, 리턴 값 X
        public static void Type4()
        {
            double result = Type1(1.121);
            Console.WriteLine("Type4 Result : "+result);
        }
    }
}
*/