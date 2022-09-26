using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P157
    {
        static void Main1(string[] args)
        {
            //복사해서 붙여넣기를 사용한 반복 vs 반복문을 사용한 반복
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("출력");
            }
        }
    }
}
