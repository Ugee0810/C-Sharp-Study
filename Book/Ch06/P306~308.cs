using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[응용 예제 6-1]재귀 메서드

namespace Book.Ch06
{
    class Fibonacci
    {
        public static long get(int i)
        {
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }
            if (i == 2) { return 1; }
            return get(i - 2) + get(i - 1);
        }
    }

    internal class P306_308
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(Fibonacci.get(1));
            Console.WriteLine(Fibonacci.get(2));
            Console.WriteLine(Fibonacci.get(3));
            Console.WriteLine(Fibonacci.get(4));
            Console.WriteLine(Fibonacci.get(5));
        }
    }
}
