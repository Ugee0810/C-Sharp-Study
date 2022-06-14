using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P215
    {
        static void Main1(string[] args)
        {
            //Math 클래스
            Console.WriteLine(Math.Abs    (-52273));  //절대 값을 구합니다.
            Console.WriteLine(Math.Ceiling(52.273));  //지정된 숫자보다 크거나 같은 최소 정수를 구합니다.
            Console.WriteLine(Math.Floor  (52.273));  //지정된 숫자보다 작거나 같은 최대 정수를 구합니다.
            Console.WriteLine(Math.Max    (52, 7465));//두 개의 매개변수 중에서 큰 값을 구합니다.
            Console.WriteLine(Math.Min    (52, 2789));//두 개의 매개변수 중에서 작은 값을 구합니다.
            Console.WriteLine(Math.Round  (52.273));  //반올림합니다.
        }
    }
}