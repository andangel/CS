using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace 序列化
{
    /// <summary>
    /// 将对象转换为二进制
    /// 作用:传输数据
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("zh", 100);
            //序列化一个对象
            using (FileStream fsWrite = new FileStream(@"./序列化.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWrite, p);
            }
            //反序列化
            Person pp;
            using (FileStream fsRead=new FileStream(@"./序列化.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                pp = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(pp.Name);
            Console.WriteLine(pp.Age);
        }
    }
}
