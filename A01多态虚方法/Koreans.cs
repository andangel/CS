using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01多态虚方法
{
    /// <summary>
    /// 韩国人类
    /// </summary>
    class Koreans:Person
    {
        public Koreans() { }
        public Koreans(string name) : base(name) { }
        public Koreans(string name, int age) : base(name, age) { }
        /// <summary>
        /// override 表示可以重写父类的虚方法
        /// </summary>
        public override void Say() {
            Console.WriteLine("我叫:{0},现在:{1}岁,我是韩国人!", Name, Age);
        }
    }
}
