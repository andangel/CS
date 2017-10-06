using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01虚方法练习一
{
    class 中国人:人类
    {
        public 中国人() { }
        public 中国人 (string name):base(name){}
        public 中国人 (string name ,int age):base(name,age){}
        public override void Say()
        {
            Console.WriteLine("我是中国人,叫{0}今年{1}岁", this.Nmae, this.Age);
        }
    }
}
