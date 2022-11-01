//Example 14: C# Program to Count Number of Words in a String

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example._01.Basic
{
    internal class Example14
    {
        static void Main0(string[] args)
        {
            string sentence;
            Console.Write("Enter String  : ");
            sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Count of words :" + words.Length);
            Console.ReadKey();
        }
    }
}
