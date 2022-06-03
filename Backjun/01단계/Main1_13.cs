using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._01단계
{
    internal class Main1_13
    {
        static void Main1(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            // string->int
            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);

            int n1 = int.Parse(str2[0].ToString()); // "385"(<-string)의 '3'(<-char)
            int n2 = int.Parse(str2[1].ToString()); // "385"의 '8'
            int n3 = int.Parse(str2[2].ToString()); // "385"의 '5'

            Console.WriteLine(num1 * n3);
            Console.WriteLine(num1 * n2);
            Console.WriteLine(num1 * n1);
            Console.WriteLine(num1 * num2);
        }
    }
}
