using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P214
    {
        static void Main1(string[] args)
        {
            //리스트 요소 제거
            //변수 선언
            List<int> list = new List<int>() { 1, 2, 3, 4 };

            //Remove()
            list.Remove(1);

            //반복 수행
            foreach (var item in list)
            {
                Console.WriteLine(list.Count + item);
            }
        }
    }
}