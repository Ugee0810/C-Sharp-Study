using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9-1 IComparable 인터페이스 활용
//9-1-1(p426) 기본 클래스와 자료 생성
/*
namespace Book.Ch09
{
    internal class P426
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500},
                new Product() { Name = "사과"  , Price = 2400},
                new Product() { Name = "바나나", Price = 1000},
                new Product() { Name = "배"    , Price = 3000}
            };
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/

//9-1-2(p427) IComparable 인터페이스 상속
/*
namespace Book.Ch09
{
    internal class P426
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }
    }
}
*/

//9-1-3(p428) Icomparable 인터페이스의 메서드 생성
/*
namespace Book.Ch09
{
    internal class P426
    {
        class Product : IComparable
        {
            public string Name  { get; set; }
            public int    Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }

            public int CompareTo(object? obj)
            {
                throw new NotImplementedException();
            }
        }
    }
}
*/

//9-1-4(p429) CompareTo()메서드 구현 CompareTo() -> 규약
/*
namespace Book.Ch09
{
    internal class P426
    {
        class Product : IComparable
        {
            public string Name  { get; set; }
            public int    Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }

            public int CompareTo(object? obj)
            {
                return this.Price.CompareTo((obj as Product).Price);
            }
        }

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500},
                new Product() { Name = "사과"  , Price = 2400},
                new Product() { Name = "바나나", Price = 1000},
                new Product() { Name = "배"    , Price = 3000}
            };
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
*/

//9-1-5(p.429) 인터페이스 인스턴스화

namespace Book.Ch09
{
    internal class P426
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price   { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }

            public int CompareTo(object? obj)
            {
                return this.Price.CompareTo((obj as Product).Price);
            }
        }

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500},
                new Product() { Name = "사과"  , Price = 2400},
                new Product() { Name = "바나나", Price = 1000},
                new Product() { Name = "배"    , Price = 3000}
            };
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            //인터페이스는 실체가 없는 규칙이므로 인스턴스화 할 수 없습니다.
            //IComparable comparable = new IComparable();
        }
    }
}