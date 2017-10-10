using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数组使用foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# 还提供 foreach 语句。 该语句提供一种简单、明了的方法来循环访问数组或任何可枚举集合的元素。 
             * foreach 语句按数组或集合类型的枚举器返回的顺序处理元素，该顺序通常是从第 0 个元素到最后一个元素。 
             * 例如，以下代码创建一个名为 numbers 的数组，并使用 foreach 语句循环访问该数组： 
             */
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            Console.WriteLine("输出一维数组.");
            foreach (int i in numbers)
            {
                System.Console.Write("{0} ", i);
            }
            Console.WriteLine();
            //借助多维数组，你可以使用相同的方法来循环访问元素，例如：
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            // Or use the short form:
            // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            Console.WriteLine("输出多维数组.");
            foreach (int i in numbers2D)
            {
                System.Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
