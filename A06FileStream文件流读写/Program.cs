using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace A06FileStream文件流读写
{
    class Program
    {
        static void Main(string[] args)
        {
            string soucre = @"C:\Windows\Media\flourish.mid";
            string target = @"./"+ Path.GetFileName(soucre);
            ;
            CopyFile(soucre, target);
        }
        static void CopyFile(string soucre, string target)
        {
            //负责读取流
            using (FileStream fsRead =new FileStream(soucre,FileMode.OpenOrCreate,FileAccess.Read))
            {
                //负责写入流
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] by = new byte[1024 * 1024 * 2];
                    int readLength = 0;
                    //循环读取文件,每次2mb,再写入
                    while (true)
                    {
                        //返回实际读取到的字节数
                        readLength = fsRead.Read(by, 0, by.Length);
                        if (readLength==0)
                        {
                            break;
                        }
                        fsWrite.Write(by, 0, readLength);
                    }


                }
            }
        }
    }
}
