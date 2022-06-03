using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P95
    {
        static void Main95(string[] args)
        {
            // 후위 증감 연산자
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(a); a += 1; // Console.WriteLine(a++)
            Console.WriteLine(a); a -= 1; // Console.WriteLine(a--)
            Console.WriteLine(a);
        }
    }
}
