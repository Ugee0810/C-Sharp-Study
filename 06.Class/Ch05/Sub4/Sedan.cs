using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Sedan : Car
    {
        private int cc;


        public Sedan(string name, string color, int speed, int v) : base(name, color, speed)
        {
            this.cc = cc;
        }


        public void Show()
        {
            Console.WriteLine("===============");
            Console.WriteLine("차랑명 : "     + name);
            Console.WriteLine("차랑색 : "     + color);
            Console.WriteLine("차랑속도 : "   + speed);
            Console.WriteLine("차랑배기량 : " + cc);
            Console.WriteLine("---------------");
        }
    }
}
