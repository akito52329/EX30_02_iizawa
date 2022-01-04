using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal : Life
    {
        public Animal(DateTime bd, string n, int l = 0, float we = 0) : base(bd, n, l, we)
        {

        }
    }
}
