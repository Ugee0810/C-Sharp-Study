using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/16
 * 이름 : 송환욱
 * 내용 : 클래스 연습문제
 */

namespace Test._3
{
    class Car
    {
        public string company;
        public string name;
        public int price;

        public Car(string company, string name, int price)
        {
            this.company = company;
            this.name = name;
            this.price = price;
        }

        private void Drive()
        {
            Console.WriteLine(name + " 운행 중...");
        }

        public void Show()
        {
            Drive();
            Console.WriteLine("제조사 : " + company);
            Console.WriteLine("차량명 : " + name);
            Console.WriteLine("가격   : " + price);
            Console.WriteLine();
        }
    }

    internal class _3_003
    {
        static void Main1(string[] args)
        {
            Car sonata;
            Car bmw;

            sonata = new Car("현대", "소나타", 3000);
            bmw    = new Car("BMW", "520d", 5000);

            sonata.Show();
            bmw   .Show();
        }
    }
}
