using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P94
    {
        static void Main94(string[] args)
        {
            // 증감 연산자의 후위 형태
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(a++);
            Console.WriteLine(a--);
            Console.WriteLine(a);

            // 증감 연산자의 전위 형태
            int b = 10;
            Console.WriteLine(b);
            Console.WriteLine(++b);
            Console.WriteLine(--b);
            Console.WriteLine(b);
        }
    }
}
