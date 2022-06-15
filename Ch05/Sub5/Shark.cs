using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub5
{
    class Shark : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Shark Swim...");
        }

        public void Hunt()
        {
            Console.WriteLine("Shark Hunt...");
        }

    }
}
