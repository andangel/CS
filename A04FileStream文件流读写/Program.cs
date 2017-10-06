using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace A04FileStream文件流读写
{
    /// <summary>
    /// FileStream与File区别(FileStream是操作大文件)
    /// File是将数据全部读到内存
    /// FileStream是将数据分成多个块读写
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string path = "./File.txt";
            //1.创建FileStream对象
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read);
            //2.申明字节数组,限制每次读取的内存大小
            byte[] buffer = new byte[1024 * 1024*1];
            //3.FileStream对象使用Read方法将文件写入字节数组,从哪里开始到哪里写书
            //返回值r作为接下来编码转换的长度,
            int r= fs.Read(buffer, 0, buffer.Length);
            //将字节数组中每一个元素按照指定编码格式转换成字符串
            string s = Encoding.Default.GetString(buffer, 0, r);
            //关闭流
            fs.Close();
            //释放流占用内存资源
            fs.Dispose();
            //输出
            Console.WriteLine(s);
        }
    }
}
