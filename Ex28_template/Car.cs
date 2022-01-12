using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Car: Thing
    {
        public Car(string n, int l = 0, string c = null, float we = 0, float wi = 0, float h = 0, float d = 0) : base(n, l, c,we, wi, h, d)
        {

        }

        new public void SelfIntroduction()
        {
            Console.WriteLine($"{name}の自動車です。");
            Color();
        }
    }
}
