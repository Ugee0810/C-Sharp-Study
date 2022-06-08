using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car
    {
        //속성(필드)
        private string name;
        private string color;
        private int    speed;
        
        //생성자
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        // 프로퍼티 - Getter, Setter 캡슐화가 되어 있어 참조할 수 없는 필드를 사용할 수 있게 해줌
        public string Name { get { return name;} set { name = value; } } //value("EF소나타") -> name에 저장

        public string Color{
            get
            {
                return Color; 
            } 
            set
            {
                Color = value;
            } 
        }

        public int Speed {
            get 
            {
                return Speed;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("speed는 0보다 작을 수 없습니다.");
                    speed = 0;
                }
                else
                {
                    Speed = value;
                }
            } 
        }

        //기능(메서드)
        public void SpeedUp(int speed) 
        {
            this.speed += speed;
        }

        public void SpeedDown(int speed) 
        {
            this.speed -= speed;
        }

        public void Show() 
        {
            Console.WriteLine("===============");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("속도   : "+speed);
        }
    }
}
