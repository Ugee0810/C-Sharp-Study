using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
숫자의 개수

문제
세 개의 자연수 A, B, C가 주어질 때 A × B × C를 계산한 결과에 0부터 9까지 각각의 숫자가 몇 번씩 쓰였는지를 구하는 프로그램을 작성하시오.

예를 들어 A = 150, B = 266, C = 427 이라면 A × B × C = 150 × 266 × 427 = 17037300 이 되고, 계산한 결과 17037300 에는 0이 3번, 1이 1번, 3이 2번, 7이 2번 쓰였다.

입력
첫째 줄에 A, 둘째 줄에 B, 셋째 줄에 C가 주어진다. A, B, C는 모두 100보다 크거나 같고, 1,000보다 작은 자연수이다.

출력
첫째 줄에는 A × B × C의 결과에 0 이 몇 번 쓰였는지 출력한다. 마찬가지로 둘째 줄부터 열 번째 줄까지 A × B × C의 결과에 1부터 9까지의 숫자가 각각 몇 번 쓰였는지 차례로 한 줄에 하나씩 출력한다.
 */

namespace Backjun._04단계
{
    internal class Main4_03_2577_N
    {
        static void Main1(string[] args)
        {
            //정수 a, b, c를 담을 그릇을 만든다.
            int[] input = new int[3];

            //정수 a, b, c를 받는다.
            for (int i = 0; i < 3; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            //a, b, c의 곱한 값을 result에 저장
            int result = input[0] * input[1] * input[2];

            //곱한 값을 분석할 수 있게 char으로 변환한다.
            char[] pieceNum = result.ToString().ToCharArray();

            //1~9의 숫자를 카운트할 변수 생성
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < pieceNum.Length; j++)
                {
                    if (pieceNum[j].ToString() == i.ToString())
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                count = 0;
            }
        }
    }
}
