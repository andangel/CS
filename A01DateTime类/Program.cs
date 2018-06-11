using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01DateTime类
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t1 = new DateTime(2018, 06, 11, 12, 12, 30);//创建一个对象并赋时间指
            Console.WriteLine(t1);//2018/6/11 12:12:30
            //t1.Now 思考一下为什么对象不能用类的方法呢? public static DateTime Now { get; }
            DateTime t2 = DateTime.Now;//datetime类的now方法.获取当前时间,now静态方法
            Console.WriteLine(t2);
            TimeSpan span=t2 - t1;//时间差类
            int days = span.Days;//获得天数差时
            double totalDays = span.TotalDays;//总天数的差时
            Console.WriteLine(span);
            
        }
    }
}
