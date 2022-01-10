using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal : Life
    {
        private string habitat;//生息地
        public Animal(DateTime bd, string n, int l = 0, string c = null, float we = 0, string h = "全国") : base(bd, n, l, c, we)
        {
            habitat = h;
        }

        public void Habitat()
        {
            Console.WriteLine($"{habitat}で生息しています。");
        }
    }
}
