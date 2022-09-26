using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[기본예제 6-1]인스턴스 메서드 생성과 사용

namespace Book.Ch06
{
    internal class P266_268
    {
        /*인스턴스 메서드 생성과 사용
        class Test
        {
            public int Power(int x)
            {
                return x * x;
            }
        }
        
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(10));
            Console.WriteLine(test.Power(20));
        }
        */

        /*두 개의 매개변수를 갖는 메서드
        class Test
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Multi(52, 273));
            Console.WriteLine(test.Multi(103, 32));
        }
        */

        /*아무것도 반환하지 않는 메서드
        class Test
        {
            public void Print()
            {
                Console.WriteLine("Print() 메서드가 호출되었습니다.");
            }
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            test.Print();
        }
        */
    }
}