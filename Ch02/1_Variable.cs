using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/02
 * 이름 : 송환욱
 * 내용 : C# 변수 실습하기 교재 p77
 * 
 * Variable(변수)
 * - 데이터를 처리하기 위해 사용되는 공간
 * - 여러번 데이터를 변경할 수 있음
 * Constant(상수)
 * - 변환할 수 없는 데이터
 */

namespace Ch02
{
    internal class _1_Variable
    {
        // svm + tabtab = static void Main(string[] args) { }
    static void Main1(string[] args)
        {
            /////////////////////////
            // 변수
            /////////////////////////
            int num1; // 데이터 선언
            num1 = 1; // 데이터 할당

            int num2 = 2; // 선언과 초기화
            int num3 = num1 + num2; // 데이터 연산

            // cw + tabtab = Console.WriteLine();
            Console.WriteLine("num3 = " + num3); // 데이터 출력

            /////////////////////////
            // 상수
            /////////////////////////
            const double PI = 3.141592;
            const int NUM = 10;
            // num = 20; <- 상수는 값 변경 X
            // num = 30;

            Console.WriteLine("NUM = " + NUM);
            Console.WriteLine("PI = " + PI);
        }
    }
}
