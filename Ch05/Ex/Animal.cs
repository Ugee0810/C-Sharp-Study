using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.ex
{
    internal class Animal
    {
        /////////////////////////////////////////////////////////////////////////////////////
        //속성(필드) - 접근제한자는 대부분 private

        //생성자 - 캡슐화된 필드(속성)를 초기화 하는 메서드

        //프로퍼티 - Getter, Setter 캡슐화가 되어 있어 참조할 수 없는 필드를 사용할 수 있게 해줌

        //기능(Method)

        /////////////////////////////////////////////////////////////////////////////////////
        //속성
        private string name;
        private int    height;
        private double weight;
        private int    leg;

        //생성자
        public Animal(string name, int height, double weight, int leg)
        {
            this.name   = name;
            this.height = height;
            this.weight = weight;
            this.leg    = leg;
        }

        //프로퍼티
        public string Name   { get { return name; }   set { Name   = value; } }
        public int Height { get { return Height; } set { Height = value; } }
        public double Weight { get { return Weight; } set { Weight = value; } }
        public int Leg    { get { return Leg; }    set { Leg    = value; } }

        //기능
        public void Show()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Animal Name   is : "+ name);
            Console.WriteLine("Animal Height is : "+ height + "cm");
            Console.WriteLine("Animal Weight is : "+ weight + "Kg");
            Console.WriteLine("Animal Leg    is : "+ leg);
        }
    }
}
