using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/16
 * 이름 : 송환욱
 * 내용 : 클래스 연습문제
 */

namespace Test._3
{
    class King
    {
        //필드
        public string name;
        public int year;

        public King(int year) : this("정조") // 문자열을 만들 수 있는 필드(name)에서 가져 옴(바로 아래 King)
        {
            this.year = year;
        }

        public King(string name)
        {
            this.name = name;
        }

        public King(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public void Show()
        {
            Console.WriteLine("==========");
            Console.WriteLine("name : " + name);
            Console.WriteLine("year : " + year);
            Console.WriteLine("----------");
        }
    }

    class _3_002
    {
        static void Main1(string[] args)
        {
            King k1 = new King("태조", 1392);
            King k2 = new King("세종");
            King k3 = new King(1776);

            k1.Show();
            k2.Show();
            k3.Show();
        }
    }
}
