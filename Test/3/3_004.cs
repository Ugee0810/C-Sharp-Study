using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/16
 * 이름 : 송환욱
 * 내용 : 클래스 변수 연습문제
 */

namespace Test._3
{
    class Student
    {
        public static int studentId;
        private string name;
        private string major;
        private int grade;

        public Student(string name, string major, int grade)
        {
            studentId++; //Student가 실행될 때 마다 클래스 변수 증가
            this.name = name;
            this.major = major;
            this.grade = grade;
        }

        public void StudentInfo()
        {
            Console.WriteLine("==========");
            Console.WriteLine("학번 : " + studentId);
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전공 : " + major);
            Console.WriteLine("학년 : " + grade);
            Console.WriteLine("----------");
        }
    }

    internal class _3_004
    {
        static void Main1(string[] args)
        {
            Student.studentId = 20201000;

            Student kim = new Student("김유신", "국문과", 1);
            kim.StudentInfo();

            Student lee = new Student("이순신", "경제학과", 1);
            lee.StudentInfo();

            Student lim = new Student("임꺽정", "경영학과", 1);
            lim.StudentInfo();
        }
    }
}
