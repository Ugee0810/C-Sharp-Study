using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P213
    {
        static void Main1(string[] args)
        {
            //리스트 요소 추가
            //변수 선언
            List<int> list = new List<int>();

            //리스트에 요소 추가
            //add()
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            //반복 수행
            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }


            //List 인스턴스 생성과 동시에 요소 추가
            List<int> list2 = new List<int>() {1, 2, 3, 4};

            foreach (var item in list2)
                Console.WriteLine(list.Count + item);
        }
    }
}