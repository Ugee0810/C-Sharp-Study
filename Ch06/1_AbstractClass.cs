using Ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/13
 * 이름 : 송환욱
 * 내용 : 추상 클래스 실습하기 교재 p230
 * 
 * 추상 클래스(Abstract Class)
 * - 공통의 기능은 하나의 메서드로 구현하고 개별적인 기능은 상속 받아 override 메서드로 구현시키는 추상 메서드를 갖는 클래스
 */

namespace Ch06
{
    internal class _1_AbstractClass
    {
        static void Main1(string[] args)
        {
            //추상 클래스는 객체생성 안됨
            //Car car = new Car();

            //Car 다형성의 원리
            Car sedan = new Sedan("그랜저", "검정색", 0, 2000);
            Car truck = new Truck("포터", "파란색", 0, 1);

            sedan.SpeedUp(100);
            sedan.SpeedDown(50);
            sedan.Show();

            truck.SpeedUp(100);
            truck.SpeedDown(50);
            truck.Show();

        }
    }
}
