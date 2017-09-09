using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03数值转换成字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            // 将整形转换
            // hold any value an int can hold, and more!
            int num = 2147483647;
            long bigNum = num;

            //将数值转换为字符串
            int numVal = Int32.Parse("-105");
            Console.WriteLine(numVal);

            // TryParse如果转换成功 返回true
            // 并将结果存储在j中。
            if (Int32.TryParse("111", out int j))
                Console.WriteLine(j);
            else
                Console.WriteLine("字符串不能被解析.");

            //利用try在输入输出不正确的时候保证不程序崩溃
            //输出：输入字符串的格式不正确。 
            try
            {
                int m = Int32.Parse("abc");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
