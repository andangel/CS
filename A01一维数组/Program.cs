using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01一维数组
{
    /// <summary>
    /// 数值多种初始化方式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //此数组包含从 array[0] 到 array[4] 的元素。 new 运算符用于创建数组并将数组元素初始化为其默认值。 在此示例中，所有数组元素都将被初始化为零。
            //告诉程序要创建一个长度为5的数组，因为没有赋值，程序自动将其赋值0
            int[] array = new int[5];
            
            //可以在声明时初始化数组，在这种情况下，无需秩说明符，因为它已由初始化列表中的元素数目提供。
            //虽然没有告诉程序要创建多少长度的数组，由于直接赋值，程序就由赋值的元素个数创建数组长度。
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };

            //声明时初始化数组，可以使用以下快捷方式：
            int[] array2 = { 1, 3, 5, 7, 9 };
            string[] weekDays2 = { "sun周日", "Mon周一）", "Tue周二", "Wed周三", "Thu周四", "Fri周五", "Sat周六" };

            //可以在不初始化的情况下声明数组变量，但必须使用 new 运算符向此变量分配数组。 例如: 
            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };   // 正确写法
            //array3 = {1, 3, 5, 7, 9};   // 错误写法

            //循环打印一维数组
            //length:元素总数
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write("{0} ",array3[i]);
                
            }
            Console.WriteLine();
        }
    }
}
