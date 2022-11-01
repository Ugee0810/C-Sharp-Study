using Ch05.ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    internal class Ex
    {
        static void Main1(string[] args)
        {
            Animal dog = new Animal("Dog", 30, 6.5, 4);
            Animal cat = new Animal("Cat", 25, 5.5, 4);
            Animal cow = new Animal("Cow", 150, 160, 4);

            dog.Show();
            cat.Show();
            cow.Show();
        }
    }
}