using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/10
 * 이름 : 송환욱
 * 내용 : 배열 연습문제
 */

namespace Test._2
{
    internal class _2_001
    {
        static void Main1(string[] args)
        {
            char[] chars = { 'I', ' ', 'L', 'O', 'V', 'E', ' ', 'Y', 'O', 'U' };
            int row, col;

            for (row = 1; row < 10; row++)
            {
                for (col = 0; col <= row; col++)
                {
                    Console.Write(chars[col]);
                }
                Console.Write("\n");
            }
        }
    }
}
