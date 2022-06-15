﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[응용 예제 6-2]메모화

namespace Book.Ch06
{
    class Fibonacci2
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();//계산한 피보나치 수를 저장하는 딕셔너리 객체
        public static long Get(int i)
        {
            //기본 값
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }

            //이미 계산했던 값인지 확인
            if (memo.ContainsKey(i))
            {
                return memo[i];
            }
            else
            {
                //계산하지 않았다면 계산하기
                long value = Get(i - 2) + Get(i - 1);
                memo[i] = value;
                return value;
            }
        }
    }

    internal class P308_310
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(Fibonacci2.Get(40));
            Console.WriteLine(Fibonacci2.Get(100));
        }
    }
}
