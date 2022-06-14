using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/14
 * 이름 : 송환욱
 * 내용 : 자주 사용하는 내장 클래스 실습하기
 */

namespace Ch06
{
    internal class _6_InternalClass
    {
        static void Main1(string[] args)
        {
            ////////////////////////////////
            //////// Math 클래스 ////////////
            ////////////////////////////////
            //Math math = new Math();
            Console.WriteLine("PI : " + Math.PI);
            Console.WriteLine("9 제곱근 : " + Math.Sqrt(9));
            Console.WriteLine("16 제곱근 : " + Math.Sqrt(16));
            Console.WriteLine("절대값 : " + Math.Abs(-5));
            Console.WriteLine("올림값 : " + Math.Ceiling(1.2));
            Console.WriteLine("올림값 : " + Math.Ceiling(1.8));
            Console.WriteLine("내림값 : " + Math.Floor(1.2));
            Console.WriteLine("내림값 : " + Math.Floor(1.8));
            Console.WriteLine("반올림 : " + Math.Round(1.2));
            Console.WriteLine("반올림 : " + Math.Round(1.8));

            //////////////////////////////////
            //////// Random 클래스 ////////////
            //////////////////////////////////
            Random rand = new Random();

            int rand1 = rand.Next();
            Console.WriteLine("rand1 : " + rand1);

            // 0 ~ 9 사이의 임의의 정수
            int rand2 = rand.Next(10);
            Console.WriteLine("rand2 : " + rand2);

            // 1 ~ 9
            int rand3 = rand.Next(1, 10);
            Console.WriteLine("rand3 : " + rand3);

            // 0 ~ 1 사이의 임의의 실수
            double num1 = rand.NextDouble();
            Console.WriteLine("num1 : " + num1);

            // 0 ~ 10 사이의 임의의 실수
            double num2 = num1 * 10;
            Console.WriteLine("num2 : " + num2);

            // 1에서 10 사이의 임의의 정수
            double num3 = Math.Ceiling(num2);
            Console.WriteLine("num3 : " + num3);

            ////////////////////////////////////
            //////// DateTime 클래스 ////////////
            ////////////////////////////////////
            // 싱글톤 객체
            DateTime now = DateTime.Now;
            Console.WriteLine(now); //output 현재 시간

            // 개별 시간 데이터 출력
            Console.WriteLine("년 : " + now.Year);
            Console.WriteLine("월 : " + now.Month);
            Console.WriteLine("일 : " + now.Day);
            Console.WriteLine("시 : " + now.Hour);
            Console.WriteLine("분 : " + now.Minute);
            Console.WriteLine("초 : " + now.Second);

            // 문자열 format
            string result1 = now.ToString("yyyy-MM-dd");
            Console.WriteLine("result1 : " + result1);

            string result2 = now.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine("result2 : " + result2);
        }
    }
}
