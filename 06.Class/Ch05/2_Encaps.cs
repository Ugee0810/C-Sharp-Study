using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/08
 * 이름 : 송환욱
 * 내용 : 캡슐화 실습 교재 p203
 * 캡슐화(Encapsulation)
 * - 캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보를 은닉하는 특성을 말한다.
 * - 캡슐화를 위한 접근 제한자 public, private, protected를 제공한다.
 * - 은닉된 정보의 안전한 제공을 위해 Getter와 Setter를 제공한다(프로퍼티)
 */

namespace Ch05
{
    internal class _2_Encaps
    {
        static void Main1(string[] args)
        {
            //캡슐화로 취약코드 예방
            //초기화를 위해 생성자가 필요
            //// 순서
            //1 참조변수 생성
            //2 객체 생성
            //3 초기화
            //4 참초값 대입

            Account kb = new Account("국민은행", "1011-11-1412", "김유신", 10000); //생성과 호출이 동시에 일어남

            //기능
            kb.Deposit(3000);
            kb.Withdraw(5000);
            kb.Show();

            ////////////////////////Car\\\\\\\\\\\\\\\\\\\\\\
            Car bmw    = new Car("BMW", "White", 0);
            Car benz   = new Car("Benz", "White", 0);
            Car sonata = new Car("Sonata", "White", 0);

            bmw.SpeedUp(160);
            bmw.SpeedDown(10);
            bmw.Show();

            benz.SpeedUp(160);  
            benz.SpeedDown(10);
            benz.Show();

            // getter 실행
            Console.WriteLine("Sonata 객체 name : " + sonata.Name);

            // setter 실행
            sonata.Name = "EF소나타";
            sonata.Speed = -10;

            sonata.SpeedUp(150);
            sonata.SpeedDown(0);
            sonata.Show();
        }
    }
}