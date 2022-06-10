using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
구구단(2739)

문제
N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오. 출력 형식에 맞춰서 출력하면 된다.

입력
첫째 줄에 N이 주어진다. N은 1보다 크거나 같고, 9보다 작거나 같다.

출력
출력형식과 같게 N*1부터 N*9까지 출력한다.
 */

namespace Backjun._03단계
{
    internal class Main3_01
    {
        static void Main1(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                int z = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, z);
            }
        }
    }
}