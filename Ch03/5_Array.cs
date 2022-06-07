using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 송환욱
 * 내용 : 배열 실습 교재 p157
 */

namespace Ch03
{
    internal class _5_Array
    {
        static void Main(string[] args)
        {
            //배열 기본
            int[] arr1 = new int[3];

            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;

            //배열 출력
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("arr1 {0}번째 데이터 : {1}", i+1, arr1[i]) ;
            }

            //배열 생성 초기화
            int[]    nums = { 1, 2, 3, 4, 5 };
            char[]   chars = { 'A', 'B', 'C' };
            string[] cities = { "서울", "대전", "대구", "부산", "광주" };

            //배열 길이
            Console.WriteLine("nums 길이 : "+nums.Length); //output : 5 (원소 갯수)
            Console.WriteLine("chars 길이 : "+chars.Length); //output : 3
            Console.WriteLine("cities 길이 : "+cities.Length); //output : 5

            //배열 반복문(foreach 사용)
            foreach (int num in nums) // 앞 : 원소 / 뒤 : 배열 길이를 원소(앞)에 대입
            {
                Console.WriteLine(num+" ");
            }
            Console.WriteLine();

            foreach (char c in chars)
            {
                Console.WriteLine(c+" ");
            }
            Console.WriteLine();

            foreach (string city in cities)
            {
                Console.WriteLine(city+" ");
            }
            Console.WriteLine();

            ////다차원 배열
            //1차원 배열(선형)
            int[] arr1d = { 10, 20, 30, 40, 50, 60 };

            int total = 0;

            foreach (int num in arr1d)
            {
                total += num;
            }
            Console.WriteLine("arr1d 총합 : "+total);

            //2차원 배열(행렬)
            int[,] arr2d = { { 1, 2, 3, 4 }, 
                             { 5, 6, 7, 8 }, 
                             { 9,10,11,12 } };

            Console.WriteLine("arr2d[0, 0] : " + arr2d[0, 0]); // 1
            Console.WriteLine("arr2d[0, 2] : " + arr2d[0, 2]); // 3
            Console.WriteLine("arr2d[1, 2] : " + arr2d[1, 2]); // 7
            Console.WriteLine("arr2d[2, 3] : " + arr2d[2, 3]); // 12

            //3차원 배열(큐브 행렬)
            int[,,] arr3d = { 
                            { 
                            { 1, 2, 3},
                            { 4, 5, 6 },
                            { 7, 8, 9 } 
                            },
                            {
                            { 10, 11, 12 }, 
                            { 13, 14, 15 }, 
                            { 16, 17, 18 } 
                            }, 
                            { 
                            { 19, 20, 21 }, 
                            { 22, 23, 24 }, 
                            { 25, 26, 27 } 
                            } 
                            };
            Console.WriteLine("arr3d[0, 0, 2] : " + arr3d[0, 0, 2]); // 3
            Console.WriteLine("arr3d[0, 1, 1] : " + arr3d[0, 1, 1]); // 5
            Console.WriteLine("arr3d[1, 0, 1] : " + arr3d[1, 0, 1]); // 11
            Console.WriteLine("arr3d[1, 2, 1] : " + arr3d[1, 2, 1]); // 17
            Console.WriteLine("arr3d[2, 2, 0] : " + arr3d[2, 2, 0]); // 25
        }
    }
}
