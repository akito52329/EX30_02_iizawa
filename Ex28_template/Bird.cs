using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird(DateTime bd, string n, int l = 0, float we = 0) : base(bd, n, l, we)
        {

        }
    }
}
