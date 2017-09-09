using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02查找字符串字符位置
{
    class Program
    {
        static void Main(string[] args)
        {
            //IndexOf找出字符串里最早出现字符的位置
            string str = "窗前明月光,疑似地上霜,举头望明月,低头思故乡." +
                "人生得意须尽欢，莫使金樽空对月。天生我材必有用，千金散尽还复来。";
            Console.WriteLine(str.IndexOf("光"));//查找字符串 光 这个字符的位置

            for (int i = 0; i < str.Length; i++)
            {

                if (str.IndexOf("明", i) != -1)
                {
                   
                    Console.WriteLine(str.IndexOf("明", i));
                }
            }
        }
    }
}
