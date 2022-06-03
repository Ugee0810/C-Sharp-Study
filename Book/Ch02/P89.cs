using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P89
    {
        //불 변수 생성
        static void Main89(string[] args)
        {
            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);
        }
    }
}
