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
    internal class _3_001
    {
        private string name;
        private int    age;

        public _3_001(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine("===============");
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);
            Console.WriteLine("---------------");
        }

        static void Main1(string[] args)
        {
            _3_001 kim = new _3_001("김유신", 23);
            _3_001 lee = new _3_001("이순신", 31);

            kim.Show();
            lee.Show();
        }
    }
}
