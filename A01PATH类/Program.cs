using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace A01PATH类
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\mscorlib.dll";
            Console.WriteLine("获取文件名:{0}",Path.GetFileName(path));
            Console.WriteLine("获取不包含后缀文件名:{0}",Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("获取后缀:{0}",Path.GetExtension(path));
            Console.WriteLine("获取文件夹路径",Path.GetDirectoryName(path));
        }
    }
}
