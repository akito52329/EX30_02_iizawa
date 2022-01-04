using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Plant : Life
    {
        public Plant(DateTime bd, string n, int l = 0, float we = 0, float wi = 0, float h = 0, float d = 0) : base(bd, n, l,we,wi, h, d)
        {
        }
    }
}
