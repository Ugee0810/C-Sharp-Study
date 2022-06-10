using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/03
 * 이름 : 송환욱
 * 내용 : 문자열(String) 처리 실습 교재 p112
 */

namespace Ch02
{
    internal class _6_String
    {
        static void Main1(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine("greeting : " + greeting);
            Console.WriteLine();

            // 문자열 길이
            Console.WriteLine("greeting 길이 : " + greeting.Length);

            // 문자열 추출
            Console.WriteLine("greeting[0] : " + greeting[0]);
            Console.WriteLine("greeting[3] : " + greeting[3]);
            Console.WriteLine("greeting[4] : " + greeting[4]);
            Console.WriteLine("greeting[5] : " + greeting[5]);

            // IndexOf(앞에서 참조)
            Console.WriteLine("Index 'G' : "      + greeting.IndexOf('G'));
            Console.WriteLine("Index \"G\" : "    + greeting.IndexOf("G"));
            Console.WriteLine("Index \"o\" : "    + greeting.IndexOf("o"));
            Console.WriteLine("Index \"Mor\" : "  + greeting.IndexOf("Mor"));
            Console.WriteLine("Index \"ing\" : "  + greeting.IndexOf("ing"));

            // LastindexOf(뒤에서 참조)
            Console.WriteLine("LastIndxOf 'G' : "     +greeting.LastIndexOf('G'));
            Console.WriteLine("LastIndxOf 'o' : "     +greeting.LastIndexOf('o'));
            Console.WriteLine("LastIndxOf \"Mor\" : " +greeting.LastIndexOf("Mor"));
            Console.WriteLine("LastIndxOf \"ing\" : " +greeting.LastIndexOf("ing"));

            // Substring(자르기)
            Console.WriteLine("Substring(0, 4) : {0} ", greeting.Substring(0, 4)); // Substring(Start, Length) <- 자바는 End
            Console.WriteLine("Substring(5, 7) : {0} ", greeting.Substring(5, 7));
            Console.WriteLine("Substring(5) : {0} "   , greeting.Substring(5));

            // Replace(교체)
            string replaced = greeting.Replace("Morning", "Afternoon"); // 앞의 문자열을 뒷 문자열로 교체
            Console.WriteLine("replaced : " +replaced);

            // 기본형 데이터를 문자열로 변환
            int      var1 = 1;
            double   var2 = 2.12;
            bool     var3 = true;

            string str1 = var1.ToString();
            string str2 = var2.ToString();
            string str3 = "" + var3; // "" + 형태 = ToString()

            Console.WriteLine("str1 : " + str1);
            Console.WriteLine("str2 : " + str2);
            Console.WriteLine("str3 : " + str3);

            // 문자열 데이터를 기본형으로 변환
            string s1 = "3";
            string s2 = "3.14";
            string s3 = "True";

            int    r1  = int.Parse(s1);
            double r2  = double.Parse(s2);
            bool   r3  = bool.Parse(s3);

            Console.WriteLine($"r1 : {r1}");
            Console.WriteLine($"r2 : {r2}");
            Console.WriteLine($"r3 : {r3}");

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
        }
    }
}