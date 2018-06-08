using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
/// <summary>
/// 一切类型都能ToString()方法转换成字符串
/// </summary>
namespace A01StringBuilder字符串拼接避免造成大量内存垃圾
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            string str = null;
            bool on_off = true;
            int length = 110000;
            Stopwatch sw = new Stopwatch();//计时器
            sw.Start();//开始计时
            if (on_off)
            {
                for (int i = 0; i < length; i++)
                {
                    sb.Append(i);
                }
                Console.WriteLine(sw.Elapsed);//打印计时器时间
                Console.WriteLine(sb.ToString().Length);//打印结果Length是字符串属性,能获得字符串个数
            }
            else
            {
                //此方法会造成大量内存垃圾.因为string是引用类型.
                for (int i = 0; i < length; i++)
                {
                    str += i;
                }
                Console.WriteLine(sw.Elapsed);//打印计时器时间
                Console.WriteLine(str.Length);
            }
            sw.Stop();//计时器结束

            
        }
    }
}
