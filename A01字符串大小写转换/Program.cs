using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01字符串大小写转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你喜欢的语言:");
            string lessonOne = Console.ReadLine();
           lessonOne= lessonOne.ToUpper();//转换成大写
            Console.WriteLine("请输入你喜欢的语言:");
            string lessonTwo = Console.ReadLine();
           lessonTwo= lessonTwo.ToUpper();
            if (lessonOne==lessonTwo)
            {
                Console.WriteLine("你们喜欢的语言相同");
            }
            else
            {
                Console.WriteLine("你们喜欢的语言不同");
            }
            Console.ReadKey();
        }
    }
}
