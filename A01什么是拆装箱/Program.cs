using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace A01什么是拆装箱
{
    /*
     * 装箱:就是将值类型转换为引用类型.
     * 拆箱:将引用类型转换为值类型.
     * 什么时候发生拆装箱?
     *                 看两种类型是否存在继承关系.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            //object o = n;//装箱
            //int n2 = (int)o;//拆箱
            ArrayList arrayList = new ArrayList();//声明一个集合
            Stopwatch sw1 = new Stopwatch();//创建计时器对象
            sw1.Start();//开始计时
            for (int i = 0; i < 100000000; i++)
            {
                arrayList.Add(i);
            }
            Console.WriteLine("集合赋值整型,这里进行了一亿次装箱操作!");
            sw1.Stop();//结束计时
            Console.WriteLine("一共用了 {0} 秒!",sw1.Elapsed);
            List<int> iList = new List<int>();//申明一个泛型集合
            Stopwatch sw2 = new Stopwatch();//计时器
            sw2.Start();//开始计时
            for (int i = 0; i < 100000000; i++)
            {
                iList.Add(i);
            }
            Console.WriteLine("泛型集合赋值整形,这里进行了一亿次装箱操作!");
            sw2.Stop();//结束计时
            Console.WriteLine("一共用了 {0} 秒!", sw2.Elapsed);
        }
    }
}
