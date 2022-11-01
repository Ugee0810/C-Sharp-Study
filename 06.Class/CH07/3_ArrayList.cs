using Ch07.Sub1;
using System;
// 1. Collections 라이브러리 선언
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15
 * 이름 : 송환욱
 * 내용 : 컬렉션(자료구조) ArrayList 실습
 * 
 * ArrayList
 * - 배열과 유사한 동적 선형 구조 자료
 * - List는 ArrayList를 일반화(제네릭) 시킨 자료 구조 ArrayList보다 더 나은 성능
 */

namespace Ch07
{
    internal class _3_ArrayList
    {
        static void Main1(string[] args)
        {
            // 2. ArrayList 생성
            ArrayList list1 = new ArrayList();

            // 3. 데이터 입력
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            // 3-1. 데이터 출력
            foreach (int n in list1)
            {
                Console.WriteLine(n + " "); // 출력 : 1, 2, 3, 4, 5
            }
            Console.WriteLine();

            // 4. 데이터 삽입
            list1.Insert(1, 6); //인덱스 참조 1의 자리에 6을 삽입(기존의 1의 자리는 2의 자리로 밀림)

            // 4-1. 데이터 출력
            foreach (int n in list1)
            {
                Console.WriteLine(n + " "); // 출력 : 1, 6, 2, 3, 4, 5
            }
            Console.WriteLine();

            // 5. 데이터 삭제
            list1.Remove(6);   //데이터 6 삭제
            list1.RemoveAt(0); //인덱스 참조 0의 자리의 데이터 삭제

            // 5-1. 데이터 출력
            foreach (int n in list1)
            {
                Console.WriteLine(n + " "); // 출력 : 2, 3, 4, 5
            }
            Console.WriteLine();

            // 6. 다양한 형식의 데이터를 갖는 ArrayList -> 배열은 한 가지의 형식만 가능
            ArrayList list2 = new ArrayList();
            list2.Add(100);
            list2.Add(100.1);
            list2.Add(true);
            list2.Add('A');
            list2.Add("Apple");

            // 6.1 데이터 출력
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            Console.WriteLine();


            //////////////////////
            /// List 교재 p211 ///
            /////////////////////
            // Generic 형식이여서 한 가지 형식의 데이터만 가짐
            // 삽입 삭제는 ArrayList와 같음
            List<int> list3 = new List<int>();
            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.Add(4);
            list3.Add(5);

            // 데이터 출력
            foreach (int n in list3)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            List<string> list4 = new List<string>();
            list4.Add("김유신");
            list4.Add("김춘추");
            list4.Add("장보고");
            list4.Add("강감찬");
            list4.Add("이순신");

            //데이터 출력
            foreach (var item in list4)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            List<Apple> list5 = new List<Apple>();
            list5.Add(new Apple("경주", 1500));
            list5.Add(new Apple("서울", 3000));
            list5.Add(new Apple("하남", 1000));

            //데이터 출력
            list5[0].Show();
            list5[1].Show();
            list5[2].Show();
        }
    }
}
