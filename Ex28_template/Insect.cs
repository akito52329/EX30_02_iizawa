using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Insect : Animal
    {
        private string season;
        /// <summary>
        /// 昆虫
        /// </summary>
        /// <param name="bd">成虫になった日</param>
        /// <param name="n">虫の種類</param>
        /// <param name="l">寿命</param>
        /// <param name="s">季節</param>
        public Insect(DateTime bd, string n, int l = 0, string s = null) : base(bd, n, l)
        {
            this.season = s;
        }

        new public void SelfIntroduction()
        {
            Console.WriteLine($"この虫は、{name}という名前です。{season}の虫です。寿命は{lifeSpan}日といわれています。" +
                $"例えば、{_birthDay.Month}月{_birthDay.Day}日に成虫になったら{lifeCalculate(_birthDay,lifeSpan).Month}月{lifeCalculate(_birthDay, lifeSpan).Day}日死にます。");
        
        }
    }
}
