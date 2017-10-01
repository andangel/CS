using System;
using System.Collections.Generic;

namespace A03List泛型集合
{
    /*
     * 泛型集合的好处是避免拆装箱
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> iList = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10
            };
            PrinList(iList);
            iList.Reverse();
            PrinList(iList);
            iList.Remove(10);
            PrinList(iList);
            int[] iArray= iList.ToArray();
            PrinArray(iArray);

        }
       static void PrinList(List<int> list)
        {
            Console.WriteLine("===========泛型集合===========");
            foreach (var item in list)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine("===========这里结束==========");
        }
        static void PrinArray(int[] array)
        {
            Console.WriteLine("===========数组类型===========");
            foreach (var item in array)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine("===========这里结束==========");
        }
    }
}
