using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 송환욱
 * 내용 : 다이아몬드 출력 연습문제
 */

namespace Test._1
{
    internal class _1_009
    {
        static void Main1(string[] args)
        {
			int count = 0;

			for (int i = 1; i <= 9; i++)
			{
				if (i <= 5)
					count++;
				else
					count--;

				for (int j = 1; j <= 5 - count; j++)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= 2 * count - 1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
