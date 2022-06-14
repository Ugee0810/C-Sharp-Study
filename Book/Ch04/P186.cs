using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //필수 입력

namespace Book.Ch04
{
    internal class P186
    {
        static void Main1(string[] args)
        {
            //Console.SetCursorPosition() 메서드
            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("메서드 호출 후");

            //Thread.Sleep() 메서드
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");            
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
        }
    }
}