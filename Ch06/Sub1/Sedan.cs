using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Sedan : Car
    {
        //필드
        private int cc;

        //생성자
        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        //Method(기능)
        public override void SpeedUp(int speed)
        {
            Console.WriteLine("Sedan SpeedUp ...");
            base.speed += speed;
        }

        public override void SpeedDown(int speed)
        {
            Console.WriteLine("Sedan SpeedDown ...");
            base.speed -= speed;
        }

        public override void Show()
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
