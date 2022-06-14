using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P209
    {
        static void Main1(string[] args)
        {
            //Random 클래스를 사용한 임의의 실수 생성
            //NextDouble() -> 0.0 ~ 1.0 사이의 임의의 수를 반환
            Random random = new Random();
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
        }
    }
}