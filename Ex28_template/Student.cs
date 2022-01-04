using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student:Person
    {
        private int id;  // 学籍番号

        /// <summary>
        /// 生徒
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">名前</param>
        /// <param name="l">寿命</param>
        /// <param name="we">体重</param>
        /// <param name="i">学籍番号</param>
        public Student(DateTime bd, string n, int l = 0 , float we = 0,int i = 0) : base(bd, n, l, we)
        {
            this.id = i;
        }

        new public void SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"学籍番号は{id}です。");
        }

    }
}
