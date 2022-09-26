using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P133
    {
        static void Main1(string[] args)
        {
            //중첩 조건문 활용
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 식사");
            }
            else
            {
                if(DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 식사");
                }
                else
                {
                    Console.WriteLine("저녁 식사");
                }
            }
        }
    }
}
