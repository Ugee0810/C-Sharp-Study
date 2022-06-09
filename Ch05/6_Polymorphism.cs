using Ch05.Sub5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 송환욱
 * 내용 : 다형성 실습하기 교재 p340
 * 강제 캐스팅, as연산 캐스팅, is연산
 * 
 * 다형성(_6_Polymorphism)
 * - 상속관계에서 부모 클래스의 기능이 자식 클래스에서 여러 기능으로 변하는 특성
 * - 생성된 객체의 타입선언을 부모 클래스 타입으로 선언하는 것
 */
/*
namespace Ch05
{
    internal class _6_Polymorphism
    {
        static void Main(string[] args)
        {
            //다양성을 적용한 객체 생성 : 클래스 타입 -> 부모 클래스 타입으로 선언
            //부모 클래스를 virtual, 아들 클래스를 override하여 덮어씌움
            Animal ani1 = new Tiger();
            Animal ani2 = new Eagle();
            Animal ani3 = new Shark();

            ani1.Move();
            ani2.Move();
            ani3.Move();


            //객체타입 강제 캐스팅
            Tiger tiger = (Tiger) ani1;
            //??? as ??? 연산 캐스팅
            Eagle eagle = ani2 as Eagle;
            Shark shark = (Shark) ani3;

            tiger.Hunt();
            eagle.Hunt();
            shark.Hunt();

            //is연산을 이용한 객체 타입 확인
            if (ani1 is Tiger)
            {
                Console.WriteLine("ani1은 Tiger입니다.");
            }

            if (ani2 is Eagle)
            {
                Console.WriteLine("ani2은 Eagle입니다.");
            }

            if (ani3 is Shark)
            {
                Console.WriteLine("ani3은 Shark입니다.");
            }
        }
    }
}
*/