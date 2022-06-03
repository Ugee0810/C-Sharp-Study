using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P82
    {
        // 오버플로우
        static void Main27(string[] args)
        {
            int a = 2000000000;
            int b = 1000000000;

            Console.WriteLine(a + b);
        }
        // unit와 ulong 자료형
        static void Main28(string[] args)
        {
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);
        }

    }
}
