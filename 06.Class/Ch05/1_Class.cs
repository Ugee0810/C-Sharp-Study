using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/08
 * 이름 : 송환욱
 * 내용 : 클래스와 객체 실습 교재 p203
 * 메모 : 클래스와 객체
 * - 클래스는 객체를 생성하는 구조체이며, 필드와 메서드로 구분된다.
 * - 객체는 클래스의 실제 인스턴스이며, new 연산자로 생성한다.
 */

namespace Ch05
{
    internal class _1_Class
    {
        static void Main1(string[] args)
        {
            //Car 객체 생성
            Car sonata = new Car();

            //객체 초기화(데이터를 사용하기 위해)
            sonata.name  = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;

            //객체 기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();

            Car bmw = new Car();

            bmw.name = "BMW";
            bmw.color = "Black";
            bmw.speed = 0;

            bmw.SpeedUp(100);
            bmw.SpeedDown(20);
            bmw.Show();

            //Account 객체 생성
            Account kb = new Account();

            kb.bank = "국민은행";
            kb.id = "1011-11-1412";
            kb.name = "김유신";
            kb.balance = 10000;

            kb.Deposit(250000);
            kb.Withdraw(2310);
            kb.Show();

            Account toss = new Account();

            toss.bank = "토스뱅크";
            toss.id = "1234-4564-4525";
            toss.name = "송환욱";
            toss.balance = 1000000;

            toss.Deposit(900000);
            toss.Withdraw(1);
            toss.Show();
        }
    }
}