using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Worker:Person
    {   
        private int income;//収入

        /// <summary>
        /// 労働者
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">名前</param>
        /// <param name="l">寿命</param>
        /// <param name="we">体重</param>
        /// <param name="i">収入</param>
        public Worker(DateTime bd, string n, int l = 0, string c = null, float we = 0, int i = 0) : base(bd, n, l, c, we)
        {
            this.income = i;
        }

        new public void SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"収入は{income}円です。");
        }
    }
}
