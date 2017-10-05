using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01多态虚方法
{
    /// <summary>
    /// 日本人类
    /// </summary>
    class Japanese:Person
    {
        public Japanese() { }
        public Japanese(string name) : base(name) { }
        public Japanese(string name, int age) : base(name, age) { }
        /// <summary>
        /// override 表示可以重写父类的虚方法
        /// </summary>
        public override void Say()
        {
            Console.WriteLine("我叫:{0},现在:{1}岁,我是日本人!", Name, Age);
        }
    }
}
