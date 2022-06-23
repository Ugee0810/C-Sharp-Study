using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/23
 * 이름 : 송환욱
 * 내용 : 배열과 리스트 연습문제
 */

namespace Test._5
{
    internal class _5_010
    {
        static void Main1(string[] args)
        {
            //배열
            String[] arrNames = new string[5];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";

            Array.Sort(arrNames); //배열 정렬 (보통은 고정 데이터라 정렬 못하지만, 버전업 되면서 추가된 기능)

            Console.WriteLine("배열");
            foreach (string name in arrNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();


            //리스트
            List<string> lstNames = new List<string>();
            lstNames.Add("dog");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");

            lstNames.Sort(); //리스트 정렬

            Console.WriteLine("리스트");
            foreach (string name in lstNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
