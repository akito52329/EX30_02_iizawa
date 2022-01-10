using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person:Animal
    {
        private float weight;

        public Person(DateTime bd, string n, int l = 0,string c = null,float we = 0) : base(bd, n, l, c,we)
        {
            this.weight = we;

        }

        public bool BirthdayCheck(DateTime dateTime)
        {
            DateTime today = DateTime.Today;

            return  dateTime.Month == today.Month && dateTime.Day == today.Day;
        }
        public String Birthday(bool day)
        {
            string s = "";
            if(day)
            {
                s = "です。祝ってください。";
            }
            else
            {
                s = "ではありません。";
            }
            return s;
        }
        public int AgeCalculate(DateTime dateTime)
        {
            int age = 0;
            DateTime today = DateTime.Now;
            age = today.Year - dateTime.Year;

            if (dateTime > today.AddYears(-age))
            {
                age -= 1;
            }
            return age;
        }

        public void SelfIntroduction()
        {
            Console.WriteLine($"私の名前は{name}です、年齢は{AgeCalculate(_birthDay)}です。誕生日は{_birthDay.Month}月{_birthDay.Day}日で、今日は誕生日{Birthday(BirthdayCheck(_birthDay))}");
        }

    }
}
