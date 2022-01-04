using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 物体
    /// </summary>
    class Thing
    {
        readonly public string name;
        protected int lifeSpan;
        private float weight;
        private float width;
        private float height;
        private float depth;

        public Thing(string n = null, int l = 0, float we = 0, float wi = 0, float h = 0, float d = 0)
        {
            name = n;
            lifeSpan = l;
            width = wi;
            weight = we;
            height = h;
            depth = d;

        }
    }
}