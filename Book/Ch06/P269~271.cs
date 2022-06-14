using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[기본예제 6-2, 3]매개변수와 반환(1, 2)

namespace Book.Ch06
{
    internal class P269_271
    {
        /*매개변수와 반환(1)
        class Test
        {
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100)); //output : 5050
        }
        */
        
        /*매개변수와 반환(2)
        class Test
        {
            public int Multiply(int min, int max)
            {
                int output = 1;
                for (int i = min; i <= max; i++)
                {
                    output *= i;
                }
                return output;
            }
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Multiply(1, 10));
        }
        */
    }
}
