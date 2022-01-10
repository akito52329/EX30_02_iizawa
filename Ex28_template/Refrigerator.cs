using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    /// <summary>
    /// 冷蔵庫
    /// </summary>
    class Refrigerator: Thing
    {
        private int money;//値段
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">製造メーカー</param>
        /// <param name="l">寿命</param>
        /// <param name="we">縦</param>
        /// <param name="wi">横</param>
        /// <param name="h">高さ</param>
        /// <param name="d">重さ</param>
        /// <param name="c">色</param>
        /// <param name="m">金額</param>
        public Refrigerator(string n, int l = 0, string c = null, float we = 0, float wi = 0, float h = 0, float d = 0, int m = 0) : base(n, l, c, we, wi, h, d)
        {
            money = m;
        }

        public void SelfIntroduction()
        {
            
            Console.WriteLine($"{name}の冷蔵庫です。料金は{money}円です。");
            base.Color();
            base.Volume();
        }
    }
}
