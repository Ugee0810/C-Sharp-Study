using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P092
    {
        static void Main92(string[] args)
        {
            // 문자열과 관련된 복합 대입 연산자
            string a = "Hello ";
            a += "World ";
            a += "!";

            Console.WriteLine(a);

            // 문자열과 관련된 복합 대입 연산자 예제 풀어쓰기
            string b = "Hello ";
            b = b + "World ";
            b = b + "!";

            Console.WriteLine(b);
        }
    }
}
