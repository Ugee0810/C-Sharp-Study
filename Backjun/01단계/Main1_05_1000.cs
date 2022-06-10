using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._01단계
{
    internal class Main1_05_1000
    {
        static void Main1(string[] args)
        {
            // 입력
            string[] num = Console.ReadLine().Split();

            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);

            //출력
            //Console.WriteLine("num 첫 번째 값 : " + num[0]);
            //Console.WriteLine("num 두 번째 값 : " + num[1]);
            Console.WriteLine(n1 + n2);
        }
    }
}
