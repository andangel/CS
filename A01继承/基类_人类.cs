using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01继承
{
    class 基类_人类
    {
        private string 字段_姓名;
        private int 字段_年龄;
        private 枚举_性别 字段性别;

        public string 属性_姓名
        {
            get
            {
                return 字段_姓名;
            }
            set
            {
                字段_姓名 = value;
            }
        }
        public int 属性_年龄 { get { return 字段_年龄; } set { 字段_年龄 = value; } }
        public 枚举_性别 属性_性别 { get { return 字段性别; } set { 字段性别 = value; } }
        public 基类_人类() { }
        public 基类_人类(string 参数姓名)
        {
            this.属性_姓名 = 参数姓名;
        }
        public 基类_人类(string 参数姓名, int 参数年龄):this(参数姓名)
        {
            this.属性_年龄 = 参数年龄;
        }
        public 基类_人类(string 参数姓名, int 参数年龄, 枚举_性别 参数性别) : this(参数姓名, 参数年龄)
        {
            this.属性_性别 = 参数性别;
        }
        public void 方法_介绍自己()
        {
            Console.WriteLine("我是人类,我叫{0},现在{1}岁,我是{2}",this.属性_姓名,this.属性_年龄,this.属性_性别);
        }
    }
}
