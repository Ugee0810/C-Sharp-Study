using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P081
    {
        // 오버플로우
        static void Main26(string[] args)
        {
            int a = 2147483640;
            int b = 52273;

            Console.WriteLine(a + b);
        }
    }
}
