using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P160
    {
        static void Main1(string[] args)
        {
            //배열의 범위를 벗어나는 인덱스에 접근
            int[] intary = { 52, 273, 32, 65, 103 };
            Console.WriteLine(intary[5]); // Error
        }
    }
}
