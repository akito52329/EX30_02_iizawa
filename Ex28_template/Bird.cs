using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        /// <summary>
        /// 鳥
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">鳥の種類</param>
        /// <param name="l">寿命</param>
        /// <param name="c">色</param>
        /// <param name="we">体重</param>
        /// <param name="h">生息地</param>
        public Bird(DateTime bd, string n, int l = 0, string c = null,float we = 0,string h = "全国") : base(bd, n, l, c, we, h)
        {

        }

        new public void SelfIntroduction()
        {
            Console.WriteLine($"この鳥は、{name}という名前です。");
            Habitat();
            Color();
        }
    }
}
