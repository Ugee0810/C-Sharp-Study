﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P176
    {
        static void Main1(string[] args)
        {
            //별 피라미드(2)
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j <10 - i; j++)
                {
                    Console.Write(' ');
                }
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }
        }
    }
}