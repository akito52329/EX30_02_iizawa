using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Fish : Animal
    {
        private bool eat;
        /// <summary>
        /// 魚
        /// </summary>
        /// <param name="bd">生まれた日</param>
        /// <param name="n">魚の種類</param>
        /// <param name="l">寿命</param>
        /// <param name="e">食べれるかどうか</param>
        public Fish(DateTime bd, string n, int l = 0, bool e = true) : base(bd, n,l)
        {
            this.eat = e;
        }

        public string EatCheak(bool canEat)
        {
            string c = null;
            if(canEat)
            {
                c = "食べれます";
            }
            else
            {
                c = "食べれません";
            }
            return c;
        }

        new public void SelfIntroduction()
        {
            Console.WriteLine($"この魚は、{name}という名前です。{EatCheak(eat)}。寿命は{lifeSpan}年と言われています。");
        }
    }
}
