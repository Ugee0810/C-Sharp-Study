using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/24
 * 이름 : 송환욱
 * 내용 : 파일입출력 연습문제
 */

namespace Test._6
{
    internal class _6_002
    {
        static void Main2(string[] args)
        {
            string path = "C:\\Users\\1302\\Desktop\\Gugudan.txt";

            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                // 스트림 생성
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                for (int x = 2; x <= 9; x++)
                {
                    sw.WriteLine($"{x}단");
                    for (int y = 1; y <= 9; y++)
                    {
                        int z = x * y;
                        sw.WriteLine("{0} x {1} = {2}", x, y, z);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // 파일 닫기
                sw.Close();
                fs.Close();
            }

            Console.WriteLine("구구단 파일 생성 완료...");
        }
    }
}
