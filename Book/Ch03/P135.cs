using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P135
    {
        static void Main1(string[] args)
        {
            //if else if 조건문
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 식사");
            }
            else if ( DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 식사");
            }
            else
            {
                Console.WriteLine("저녁 식사");
            }

            //논리 연산자와 조건문
            //학점 변수
            double score = 4.5;
            //조건을 구분(else if는 단계적으로 실행하므로 더 간단하게 할 수 있다.
            if (score == 4.5)                     Console.WriteLine("신");
            else if (4.2 <= score && score < 4.5) Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score && score < 4.2) Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= score && score < 3.5) Console.WriteLine("중간");
            else if (0 < score && score < 2.8)    Console.WriteLine("일반인");
            else                                  Console.WriteLine("??");
        }
    }
}
