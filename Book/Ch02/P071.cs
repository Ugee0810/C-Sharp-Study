using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P071
    {
        // 문자열 연결 연산자
        static void Main18(string[] args)
        {
            Console.WriteLine("가나다" +"라마" + "바사아" + "자차카타" + "파하");
        }
        //문자 선택
        static void Main19(string[] args)
        {
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[3]);
        }
    }
}
