using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[기본 예제 6-6]인스턴스 생성 개수 확인

namespace Book.Ch06
{
    internal class P283_287
    {
        //인스턴스 생성 개수 확인
        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = counter + 1;
                this.id = counter;
                this.name = name;
                this.price = price;
            }
        }

        static void Main1(string[] args)
        {
            Product productA = new Product("감자", 3000);
            Product productB = new Product("고구마", 2000);

            Console.WriteLine(productA.id + " : " + productA.name);
            Console.WriteLine(productB.id + " : " + productB.name);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");
        }
    }
}
