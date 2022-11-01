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
    static void Main1(string[] args)
        {
            ///////////////////
            // Variable 변수 //
            ///////////////////
            int num1; // 데이터 선언
            num1 = 1; // 데이터 할당

            int num2 = 2; // 선언과 동시에 초기화
            int num3 = num1 + num2; // 데이터 연산

            Console.WriteLine("num3 = " + num3); // 데이터 출력

            ///////////////////
            // Constant 상수 //
            ///////////////////
            const double pi = 3.141592;
            const int num = 10;
            // num = 20; <- Constant = 값 변환 X

            Console.WriteLine("num = " + num);
            Console.WriteLine("pi = "  + pi);
        }
    }
}