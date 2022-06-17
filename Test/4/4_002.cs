using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/17
 * 이름 : 송환욱
 * 내용 : 분할 클래스 연습문제
 * partial 사용
 */

namespace Test._4
{
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1...");
        }
        public void Method2()
        {
            Console.WriteLine("Method2...");
        }
    }

    partial class MyClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3...");
        }
        public void Method4()
        {
            Console.WriteLine("Method4...");
        }
    }

    internal class _4_002
    {
        static void Main1(string[] args)
        {
            MyClass my = new MyClass();
            
            my.Method1();
            my.Method2();
            my.Method3();
            my.Method4();

        }
    }
}
