using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15
 * 이름 : 송환욱
 * 내용 : 컬렉션(자료구조) HashSet 실습
 */

namespace Ch07
{
    internal class _5_HashSet
    {
        static void Main1(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(2); //중복(카운트x)
            set.Add(3); //중복(카운트x)

            Console.WriteLine("집합 원소 개수 : " + set.Count);

            foreach (int item in set)
            {
                Console.WriteLine("item : " + item);
            }
            Console.WriteLine();

            //집합 연산
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int>() { 2, 3, 5, 6, 7 };

            //1. 교집합 Intersect()
            var result1 = set1.Intersect(set2);

            //2. 합집합 Union()
            var result2 = set1.Union(set2);

            //3. 차집합 Except()
            var result3 = set1.Except(set2);

            // 결과 출력
            foreach (var item in result1)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            foreach (var item in result2)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            foreach (var item in result3)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
    }
}
