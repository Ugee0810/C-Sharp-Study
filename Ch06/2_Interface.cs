using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/13
 * 이름 : 송환욱
 * 내용 : 인터페이스 실습하기 교재 p425
 */

namespace Ch06
{
    internal class _2_Interface
    {
        static void Main(string[] args)
        {
            //인터페이스로 공통 구조 설계 + 다형성
            IRemoteContol lg = new LGRemocon();
            IRemoteContol samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.PowerOff();
            lg.ChUp();
            lg.ChDown();
            lg.SoundUp();
            lg.SoundDown();

            samsung.PowerOn();
            samsung.PowerOff();
            samsung.ChUp();
            samsung.ChDown();
            samsung.SoundUp();
            samsung.SoundDown();

            //인터페이스를 활용한 다중 상속 -> 다형성 적용은 불가함
            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();
        }
    }
}
