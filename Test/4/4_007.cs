using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/17
 * 이름 : 송환욱
 * 내용 : 객체 배열 연습문제
 */

namespace Test._4
{
    class Artists
    {
        public string Name   { get; set; }
        public string Contry { get; set; }
        public int    Birth  { get; set; }

        public Artists(string name, string contry, int birth)
        {
            Name = name;
            Contry = contry;
            Birth = birth;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Name, Contry, Birth);
        }
    }

    internal class _4_007
    {
        static void Main1(string[] args)
        {
            Artists[] famousArts = {
                new Artists("레오나르도 다빈치" , "이탈리아" , 1452),
                new Artists("미켈란젤로"       , "이탈리아" , 1475),
                new Artists("빈센트 반 고흐"   , "네덜란드" , 1853),
                new Artists("클로드 모네"      , "프랑스"   , 1840),
                new Artists("파블로 피카소"    , "스페인"   , 1881)
            };

            foreach (Artists art in famousArts)
            {
                Console.WriteLine(art.ToString());
            }
        }
    }
}
