using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02HashTable键值对集合
{
    /// <summary>
    /// Hash table键值对 字典
    /// 键值对集合当中是根据键去找值
    /// 键一定是唯一的
    /// 键和值可以是任意类型
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个键值对集合对象
            Hashtable ht = new Hashtable();
            //循环添加
            for (int i = 1; i <= 10; i++)
            {
                ht.Add(i, i);
            }
            ht.Add(true, "正确");
            ht.Add(false, "错误");
            ht[100]=("我是的插入");
            if (ht.ContainsKey(1))//判断键是否存在
            {
                //如果有1这个键则修改其的值
                ht[1] = ("我是修改了下标1的值");
            }
            else
            {
                Console.WriteLine("这个键不存在");
            }
            //循环输出
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是{0}值是{1}",item,ht[item]);
            }
            //ht.clear();清空键值对
            ht.Remove(100);//删除数据
        }
    }
}
