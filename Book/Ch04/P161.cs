using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P161
    {
        static void Main1(string[] args)
        {
            //원하는 크기의 배열 생성 방법
            //특정한 크게의 배열 생성
            int[] ary = new int[100];

            Console.WriteLine(ary[0]);
            Console.WriteLine(ary[99]);
        }
    }
}
