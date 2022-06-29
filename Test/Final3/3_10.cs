using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/29
 * 이름 : 송환욱
 * 내용 : [총정리 문제]제네릭 메서드
 */

namespace Test.Final3
{
    internal class _3_10
    {
        static void Main1(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "apple", "banana", "cherry" };

            PrintArray<int>(a);
            PrintArray<double>(d);
            PrintArray<string>(s);
        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0,8}", item);
            }
            Console.WriteLine();
        }
    }
}
