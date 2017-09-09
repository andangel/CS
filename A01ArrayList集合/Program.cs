using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合对象
            ArrayList list = new ArrayList();
            //添加单个元素
            list.Add(1001);
            list.Add(true);
            list.Add("hello");
            list.Add(1.34159);
            list.Add(true);
            //添加集合元素
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            //插入元素
            list.Insert(5, "插入的值");
            Console.WriteLine("集合里有:{0}元素", list.Count);
            Console.WriteLine("*********************");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("*********************");
            Console.WriteLine("删除第一次遇到的true元素");
            list.Remove(true);//删除第一次遇到的元素
            Console.WriteLine("集合里还有:{0}元素",list.Count);
            Console.WriteLine("根据下标删除第二个true元素");
            list.RemoveAt(3);//根据下标删除第二个true值
            Console.WriteLine("集合里还有:{0}元素", list.Count);
            list.RemoveRange(0, 3);
            Console.WriteLine("集合里还有:{0}元素", list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("*********************");
            list.Reverse();//反转
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("*********************");
            if (list.Contains("插入的值"))//判断是否存在元素
            {
                list.Remove("插入的值");
                list.Sort();//升序排列,未能比较数组中的两个元素,所以要同样数据类型,否则抛异常
            }
            else
            {
                Console.WriteLine("不存在");
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("*********************");
            //list.Clear();//删除所有元素



        }
    }
}
