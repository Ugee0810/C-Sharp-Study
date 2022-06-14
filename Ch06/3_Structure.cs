using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/14
 * 이름 : 송환욱
 * 내용 : 구조체 실습하기 교재 p404
 * 
 * 구조체(Struture)
 * - 간단하게 객체를 만들 때 사용하는 구조 형식
 * - 클래스와 동일하지만 몇가지 제한(상속과 캡슐화 X)
 */

namespace Ch06
{
    internal class _3_Structure
    {
        struct Mypoint
        {
            public int x;
            public int y;

            public Mypoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            //필드(속성) 출력 메서드 ToString()
            public override string ToString()
            {
                return string.Format($"x : {x}, y : {y}");
            }
        }

        static void Main1(string[] args)
        {
            Mypoint p1;
            p1.x = 10;
            p1.y = 20;

            Console.WriteLine("p1 : " + p1.ToString());

            Mypoint p2 = new Mypoint(20, 30);
            Console.WriteLine("p2 : " + p2.ToString());
        }
    }
}
