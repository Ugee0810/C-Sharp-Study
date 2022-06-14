using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * [기본예제 6-1]인스턴스 메서드 생성과 사용
 */

namespace Book.Ch06
{
    internal class P266_268
    {
        class Test
        {
            public int Power(int x)
            {
                return x * x;
            }
        }

        static void Main1(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(10));
            Console.WriteLine(test.Power(20));
        }
    }
}