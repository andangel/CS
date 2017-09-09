using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A06使用ref和out传递数组
{
    class Program
    {
        static void FillArray(out int[] arr)
        {
            // Initialize the array:
            arr = new int[5] { 1, 2, 3, 4, 5 };
        }

        static void Main(string[] args)
        {
            /*
             * 与所有 out 参数一样，在使用数组类型的 out 参数前必须先为其赋值；即必须由被调用方为其赋值。
             * 示例
               在此示例中，在调用方（theArray 方法）中声明数组 Main，并在 FillArray 方法中初始化此数组。 然后，数组元素将返回调用方并显示。 
            */
            int[] theArray; // Initialization is not required

            // Pass the array to the callee using out:
            FillArray(out theArray);

            // Display the array elements:
            System.Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            {
                System.Console.Write(theArray[i] + " ");
            }

            // Keep the console window open in debug mode.
           // System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();


        }
    }
}
