using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P184
    {
        static void Main1(string[] args)
        {
            //문자열 양 옆의 공백 제거
            string input = " test      \n";
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read();
        }
    }
}