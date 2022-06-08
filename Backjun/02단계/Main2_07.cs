using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
주사위 세개(2480)

문제
1에서부터 6까지의 눈을 가진 3개의 주사위를 던져서 다음과 같은 규칙에 따라 상금을 받는 게임이 있다. 

1. 같은 눈이 3개가 나오면 10,000원+(같은 눈)×1,000원의 상금을 받게 된다. 
2. 같은 눈이 2개만 나오는 경우에는 1,000원+(같은 눈)×100원의 상금을 받게 된다. 
3. 모두 다른 눈이 나오는 경우에는 (그 중 가장 큰 눈)×100원의 상금을 받게 된다. 

예를 들어, 3개의 눈 3, 3, 6이 주어지면 상금은 1,000+3×100으로 계산되어 1,300원을 받게 된다.
또 3개의 눈이 2, 2, 2로 주어지면 10,000+2×1,000 으로 계산되어 12,000원을 받게 된다.
3개의 눈이 6, 2, 5로 주어지면 그중 가장 큰 값이 6이므로 6×100으로 계산되어 600원을 상금으로 받게 된다.

3개 주사위의 나온 눈이 주어질 때, 상금을 계산하는 프로그램을 작성 하시오.

입력
첫째 줄에 3개의 눈이 빈칸을 사이에 두고 각각 주어진다. 

출력
첫째 줄에 게임의 상금을 출력 한다.
 */

/*
 * 풀이
 * 1~6범위 3개
 * 1번 식 :: 3개가 같은 수 = (1~6 x 1000) + 10000
 * 2번 식 :: 2개가 같은 수 = (같은 눈 x 100) + 1000
 * 3번 식 :: 모두 숫자가 다른 경우, 그 중 가장 큰 수x100 
 */
/*
namespace Backjun._02단계
{
    internal class Main2_07
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);

            if (a == b && a == c && b == c)
            {
                Console.WriteLine(a * 1000 + 10000);
            }
            else if (a == b)
            {
                Console.WriteLine(a * 100 + 1000);
            }
            else if (a == c)
            {
                Console.WriteLine(a * 100 + 1000);
            }
            else if (b == c)
            {
                Console.WriteLine(b * 100 + 1000);
            }
            else if (a > b && a > c)
            {
                Console.WriteLine(a * 100);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b * 100);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c * 100);
            }
        }
    }
}
*/