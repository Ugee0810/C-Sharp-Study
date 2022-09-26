using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/17
 * 이름 : 송환욱
 * 내용 : 구조체 연습문제
 */

namespace Test._4
{
    struct Point3D
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format($"{x}, {y}, {z}");
        }
    }

    internal class _4_001
    {
        static void Main1(string[] args)
        {
            Point3D p1;
            p1.x = 10;
            p1.y = 20;
            p1.z = 30;

            Console.WriteLine(p1.ToString());

            Point3D p2 = new Point3D(100, 200, 300);
            Console.WriteLine(p2.ToString());
        }
    }
}
