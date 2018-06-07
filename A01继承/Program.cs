using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01继承
{
    class Program
    {
        static void Main(string[] args)
        {
            基类_人类 男人 = new 基类_人类("亚当", 100, 枚举_性别.男性);
            男人.方法_介绍自己();
            基类_人类 女人 = new 基类_人类("夏娃", 80, 枚举_性别.女性);
            Console.WriteLine("我叫:{0}",女人.属性_姓名);
            Console.WriteLine("现在{0}岁",女人.属性_年龄);
            Console.WriteLine("我是{0}", 女人.属性_性别);
            派生_中国人类 黄 = new 派生_中国人类("黄冲",35,枚举_性别.男性);//没有构造函数的派生类,用IDE修补生成的构造函数
            //关键字:base 无需赋值也能继承父类构造函数
            黄.方法_介绍自己();
            派生_中国人类 张 = new 派生_中国人类();
            张.属性_姓名 = "张";
            张.属性_年龄 = 33;
            张.属性_性别 = 枚举_性别.女性;
            张.方法_介绍自己();

        }
    }
}
