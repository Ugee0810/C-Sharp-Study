using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P129
    {
        static void Main1(string[] args)
        {
            //현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            //오전과 오후 구분
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전");
            }

            if (DateTime.Now.Hour >= 12)
            {
                Console.WriteLine("오후");
            }
        }
    }
}
