using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 使用Rank属性显示数组的维数
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array:
            int[,] theArray = new int[5, 10];
            System.Console.WriteLine("这个数组有 {0} 维度.", theArray.Rank);

        }
    }
}
