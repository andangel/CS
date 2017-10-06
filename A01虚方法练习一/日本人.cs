using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01虚方法练习一
{
    class 日本人:人类
    {
        public 日本人() { }
        public 日本人(string name) : base(name) { }
        public 日本人(string name, int age) : base(name, age) { }
        public override void Say()
        {
            Console.WriteLine("我是日本人,叫{0}今年{1}岁", this.Nmae, this.Age);
        }
    }
}
