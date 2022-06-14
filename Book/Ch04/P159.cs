using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P159
    {
        static void Main1(string[] args)
        {
            //배열 생성하고 요소에 접근
            //배열 생성
            int[] intary = { 52, 273, 32, 65, 103 };
            //배열의 요소를 변경
            intary[0] = 0;
            //요소 출력
            Console.WriteLine(intary[0]);
            Console.WriteLine(intary[1]);
            Console.WriteLine(intary[2]);
            Console.WriteLine(intary[3]);

            //배열의 길이를 출력
            Console.WriteLine(intary.Length);
        }
    }
}
