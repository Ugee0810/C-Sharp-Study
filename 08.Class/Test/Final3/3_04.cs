using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/29
 * 이름 : 송환욱
 * 내용 : [총정리 문제]버블 정렬
 * 
 * 버블 정렬
 * - 인접한 2개의 요소를 비교하여 더 큰 수를 뒤로 보내는 정렬 방법
 */

namespace Test.Final3
{
    internal class _3_04
    {
        static void Main1(string[] args)
        {
            int[] values = { 3, 5, 2, 7, 1 };
            PrintArray(values);

            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (values[j] > values[j+1])
                    {
                        int temp = values[j];
                        values[j] = values[j+1];
                        values[j+1] = temp;
                    }
                }
                PrintArray(values);
            }
        }
        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine("0,5", i);
            }
            Console.WriteLine();
        }
    }
}
