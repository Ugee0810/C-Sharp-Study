using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P114
    {
        static void Main1(string[] args)
        {
            // 소수점 제거
            double num = 52.273103;
            Console.WriteLine(num.ToString("0.0"));
            Console.WriteLine(num.ToString("0.00"));
            Console.WriteLine(num.ToString("0.000"));
            Console.WriteLine(num.ToString("0.0000"));

            // 숫자와 문자열 덧셈
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
        }
    }
}
