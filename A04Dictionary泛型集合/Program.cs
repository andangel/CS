using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04Dictionary泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "刘一");
            dic.Add(2, "陈二");
            dic.Add(3, "张三");
            dic.Add(4, "李四");
            dic.Add(5, "王五");
            dic.Add(6, "赵六");
            dic.Add(7, "孙七");
            dic.Add(8, "周八");
            dic.Add(9, "吴九");
            dic.Add(10, "郑十");
            foreach (KeyValuePair<int,string> kv in dic)
            {
                Console.WriteLine("键={0} 值={1}",kv.Key,kv.Value);
            }
        }
    }
}
