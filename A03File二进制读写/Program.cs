using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace A03File二进制读写
{
    class Program
    {
        /// <summary>
        /// File类缺点,只能读取小文件,因为每次他都一下子全将文件读出
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = "RadeMe.txt";
            string txt=null;
            if (File.Exists(path))//如果文件存在
            {
                txt = Encoding.Default.GetString(File.ReadAllBytes(path));//二进制读取文件
                Console.WriteLine("读取的文件:");
                Console.WriteLine(txt);
            }
            else
            {
                Console.WriteLine("文件不存在!");
            }




            byte[] by= Encoding.UTF8.GetBytes(txt);//转换为utf8
            File.WriteAllBytes("RadeMe1.txt",by);//二进制写入
            Console.WriteLine("复制的文件:");
            Console.WriteLine(txt);

            File.WriteAllLines("RadeMe2.txt", new string[] { "床前明月光", "举头望明月" });//行的形式写入
            Console.WriteLine("读取文件所有行:");
            string[] str= File.ReadAllLines("RadeMe2.txt");//打开一个文本文件读取所有行
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            File.WriteAllText("RadeMe2.txt", "写入一行!");
            Console.WriteLine("指定utf8读取文件所有行:");
            string str2 = File.ReadAllText("RadeMe2.txt", Encoding.UTF8);
            Console.WriteLine(str2);

            Console.WriteLine();
            File.AppendAllText(@"RadeMe3", "追加文本.txt");



        }
    }
}
