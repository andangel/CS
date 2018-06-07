using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01继承
{
    class 派生_中国人类 : 基类_人类
    {

        
        /// <summary>
        /// 只读属性
        /// </summary>
        public string 属性_国籍 { get => "中国"; }

        public 派生_中国人类()
        {
        }
        public 派生_中国人类(string 参数姓名) : base(参数姓名)
        {
        }
        public 派生_中国人类(string 参数姓名, int 参数年龄) : base(参数姓名, 参数年龄)
        {
        }
        public 派生_中国人类(string 参数姓名, int 参数年龄, 枚举_性别 参数性别) : base(参数姓名, 参数年龄, 参数性别)
        {
        }
        /// <summary>
        /// new隐藏了父类的同名方法
        /// </summary>
        public new void 方法_介绍自己()
        {
            Console.WriteLine("国籍:{0},我叫:{1},现在:{2}岁,性别:{3}",this.属性_国籍, this.属性_姓名, this.属性_年龄, this.属性_性别);
        }
    }
}
