using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A05将多维数组作为参数传递
{
    class Program
    {
        static void Print2DArray(int[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //在函数中对数据进行更改 函数外的数组是会跟着变化的.因为输出传递的是引用
                    var sum = arr[i, j];//取得数组元素值
                    arr[i, j] = sum+10;
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);

                }
                Console.WriteLine();
            }
        }
            static void Main(string[] args)
        {
            //描述
            //在下列示例中，初始化一个整数的二维数组，并将其传递至 Print2DArray 方法。 该方法将显示数组的元素。 
            // Pass the array as an argument.
            Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });

            // Keep the console window open in debug mode.
            //System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();


        }
    }
}
