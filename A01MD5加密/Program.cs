using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace A01MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //md5(123,32) = 
            //202cb962ac59075b964b07152d234b70
            //202CB962AC59075B964B07152D234B70
            //md5(123,16) = ac59075b964b0715

          string s=  GetMD5("123");
          Console.WriteLine(s);
        }
        static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();//MD5是一个抽象类,无法实例化,可以使用其的静态方法模拟一个对象.
            byte[] buffer = Encoding.Default.GetBytes(str);//md5.ComputeHash返回值是字节数组
            byte[] md5buffer = md5.ComputeHash(buffer);//返回一个加密好的字节数组
            //将字节数组转换成字符串
            //字节数组转换字符串三种方式
            //1.将字节数组中每个元素按照指定编码格式解析成字符串
            //return Encoding.Default.GetString(md5buffer);//最后结果乱码
            //2.直接将数组ToString();//返回的是命名空间
            //3.将字节数组中没个元素ToString();
            StringBuilder sb = new StringBuilder();
            //string的缺点是每次字符串变量的内容发生了改变时，都必须重新分配内存
            //StringBuilder通过分配一个缓存，就是一个工作区来解决这些问题，在工作区中队字符串应用StringBuilder类的相关方法。
            //包括添加，删除，移除，插入和替换字符等等。执行完之后，将调用ToString方法把工作区中的内容转换为一个字符串，
            //方便赋给一个字符串变量。这样StringBuilder会提升一些性能。
            for (int i = 0; i < md5buffer.Length; i++)
            {
                sb.Append(md5buffer[i].ToString("X2"));//X参数就能将十进制字符串转换成十六进制
                //X2会输出0X0A
               
            }
            return str = sb.ToString();
        }
    }
}
