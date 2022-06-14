using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P163
    {
        static void Main1(string[] args)
        {
            //while 반복문 이용
            int i = 0;
            int[] intary = { 52, 273, 32, 65, 103 };

            while (i < intary.Length)
            {
                Console.WriteLine(i+"번째 출력" + intary[i]);
                i++; //탈출을 위해 변수를 하나 더 만듬
            }
        }
    }
}
