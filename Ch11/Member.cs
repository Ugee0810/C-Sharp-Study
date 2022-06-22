using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11
{
    class Member
    {
        //필드
        private string uid;
        private string name;
        private string hp;
        private int age;

        //생성자
        public Member(string uid, string name, string hp, int age)
        {
            this.Uid = uid;
            this.Name = name;
            this.Hp = hp;
            this.Age = age;
        }

        //프로퍼티
        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public string Hp { get => hp; set => hp = value; }
        public int Age { get => age; set => age = value; }
    }
}
