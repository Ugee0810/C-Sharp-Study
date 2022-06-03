using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P66
    {
        static void Main66(string[] args)
        {
            //정수와 연산자
            Console.WriteLine(1 + 2);
            Console.WriteLine(1 - 2);
            Console.WriteLine(1 * 2);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 % 2);

            // 음수와 나머지 연산자 (왼쪽 피연산자의 부호를 따름. 오른쪽은 상관 없음)
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);
        }
    }
}
