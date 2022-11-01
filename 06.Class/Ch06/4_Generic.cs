using Ch06.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/14
 * 이름 : 송환욱
 * 내용 : 제네릭 실습하기 교재 p395
 * 
 * 제네릭(Generic)
 * - 클래스 내부의 변수의 타입을 동적으로 일반화 시키는 문법
 * - 제네릭 사용으로 클래스를 범용성을 갖도록 활용
 */

namespace Ch06
{
    class FruitBox<T> //치환변수 'T' 제네릭 선언
    {
        private T fruit;

        //Getter, Setter
        public T Fruit
        {
            get { return fruit;  } // return값<T>의 show() 매서드 호출
            set { fruit = value; }
        }
    }

    internal class _4_Generic
    {
        static void Main1(string[] args)
        {
            Apple  apple  = new Apple ("한국", 3000);
            Banana banana = new Banana("대만", 4000);

            FruitBox<Apple> box1 = new FruitBox<Apple>();
            box1.Fruit = apple; //setter 호출
            box1.Fruit.Show();  //getter 호출

            FruitBox<Banana> box2 = new FruitBox<Banana>();
            box2.Fruit = banana;
            box2.Fruit.Show();

        }
    }
}