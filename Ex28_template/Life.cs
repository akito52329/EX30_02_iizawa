using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life:Thing
    {
        readonly protected string _name;
        readonly protected DateTime _birthDay = new DateTime();
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        public string name
        {
            get { return _name; }
        }
        public Life(DateTime bd ,string n, int l = 0,float we = 0,float  wi = 0, float h = 0, float d = 0 ):base(n,l,we,wi,h,d)
        {
            this._name = n;
            this._birthDay = bd;
        }

        protected DateTime lifeCalculate(DateTime dateTime,int lifeSpan)
        {
            return dateTime.AddDays(lifeSpan);            
        }
    }
}
