using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cat : Animal
    {
        private bool domesticate;//飼い猫かどうか
        /// <summary>
        /// 猫
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">猫の種類</param>
        /// <param name="l">寿命</param>
        /// <param name="c">色</param>
        /// <param name="we">体重</param>
        /// <param name="d">飼い猫かどうか</param>
        public Cat(DateTime bd, string n, int l = 0, string c = null, float we = 0 ,bool d = true) : base(bd, n, l, c, we)
        {
            domesticate = d;
        }

        private string DomesticateCat(bool d)
        {
            string home = null;
            if(d)
            {
                home = "飼い猫です";
            }
            else
            {
                home = "野良猫です";
            }

            return home;
        }

        new public void SelfIntroduction()
        {
            Console.WriteLine($"この猫は、{name}という種類の猫で、{DomesticateCat(domesticate)}。");
        }
    }
}
