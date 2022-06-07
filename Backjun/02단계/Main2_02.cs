using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
시험 성적(9498)

문제
시험 점수를 입력받아 90 ~ 100점은 A, 80 ~ 89점은 B, 70 ~ 79점은 C, 60 ~ 69점은 D, 나머지 점수는 F를 출력하는 프로그램을 작성하시오.
            //90 ~ 100 = A
            //80 ~ 89 = B
            //70 ~ 79 = C
            //60 ~ 69 = D
            //~ 59 = F

입력
첫째 줄에 시험 점수가 주어진다. 시험 점수는 0보다 크거나 같고, 100보다 작거나 같은 정수이다.

출력
시험 성적을 출력한다.
 */

/*
namespace House.백준.Lv2
{
    internal class Main2_02
    {
        static void Main(string[] args)
        {
            string strscore = Console.ReadLine();
            int strnum = int.Parse(strscore);

            if (90 <= strnum && strnum <= 100)
            {
                Console.WriteLine("A");
            }
            else if (80 <= strnum && strnum <= 89)
            {
                Console.WriteLine("B");
            }
            else if (70 <= strnum && strnum <= 79)
            {
                Console.WriteLine("C");
            }
            else if (60 <= strnum && strnum <= 69)
            {
                Console.WriteLine("D");
            }
            else if (0 <= strnum && strnum <= 59)
            {
                Console.WriteLine("F");
            }
        }
    }
}
*/