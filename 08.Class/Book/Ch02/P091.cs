using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P091
    {
        static void Main1(string[] args)
        {
            // 숫자와 관련된 복합 대입 연산자
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);

            // 숫자와 관련된 복합 대입 연산자 다른 방식
            int a = 0;
            a = a + 52;
            a = a + 273;
            a = a + 103;

            Console.WriteLine(a);
        }
    }
}
