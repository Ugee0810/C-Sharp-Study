﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/16
 * 이름 : 송환욱
 * 내용 : 인터페이스 연습문제
 */

namespace Test._3
{
    interface Buyer
    {
        public abstract void Buy();
    }

    interface Seller
    {
        public abstract void Sell();
    }

    class Customers : Buyer, Seller
    {
        public void Sell()
        {
            Console.WriteLine("판매하기");
        }
        
        public void Buy()
        {
            Console.WriteLine("구매하기");
        }
    }

    internal class _3_010
    {
        static void Main1(string[] args)
        {
            Buyer  buyer  = new Customers();
            Seller seller = new Customers();

            buyer.Buy();
            seller.Sell();
        }
    }
}
