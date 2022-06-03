using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P103
    {
        static void Main1(string[] args)
        {
            // long 자료형을 나타내는 기호 : 소문자에 주의
            Console.WriteLine(123456 + 65432l); // l보다 L사용

            // long 자료형을 나타내는 기호 : 대문자
            Console.WriteLine(123456 + 654321L);
        }
    }
}
