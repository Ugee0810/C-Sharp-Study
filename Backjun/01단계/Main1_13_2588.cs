using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
문제
(세 자리 수) × (세 자리 수)는 다음과 같은 과정을 통하여 이루어진다.

(1)과 (2)위치에 들어갈 세 자리 자연수가 주어질 때 (3), (4), (5), (6)위치에 들어갈 값을 구하는 프로그램을 작성하시오.

입력
첫째 줄에 (1)의 위치에 들어갈 세 자리 자연수가, 둘째 줄에 (2)의 위치에 들어갈 세자리 자연수가 주어진다.

출력
첫째 줄부터 넷째 줄까지 차례대로 (3), (4), (5), (6)에 들어갈 값을 출력한다.
 */

namespace House.백준.Lv1
{
    internal class Main1_13_2588
    {
        static void Main1(string[] args)
        {
            //ReadLine으로 각각 세 자리 수를 받는다.
            //n의 자리를 구해야 하는 str2는 ToCharArray로 배열로 각각 저장
            //이렇게 했을 때 char[숫자, 숫자, 숫자]로 캐스팅 변환 후 WriteLine에서 계산

            String str1 = Console.ReadLine(); // (1)위치 값 입력
            String str2 = Console.ReadLine(); // (2)위치 값 입력
            char[] str3 = str2.ToCharArray(); // (2)의 숫자 개별 저장

            int   num1 = int.Parse(str1);      // 정수 캐스팅 변환
            int[] num2 = new int[str3.Length]; // 정수 캐스팅 변환

            for (int i = 0; i < str3.Length; i++)
            {
                num2[i] = int.Parse(str3[i].ToString()); // 위치 값의 길이 만큼 반복시키면서 정수를 문자열로 변환
            }

            Console.WriteLine(num1 * num2[2]); //(3)위치 값
            Console.WriteLine(num1 * num2[1]); //(4)위치 값
            Console.WriteLine(num1 * num2[0]); //(5)위치 값
            Console.WriteLine(num1 * num2[2] 
                            + num1 * num2[1] * 10 
                            + num1 * num2[0] * 100); //(6)위치 값
        }
    }
}