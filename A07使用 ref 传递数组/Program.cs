using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A07使用ref传递数组
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 与所有 ref 参数一样，数组类型的 ref 参数必须由调用方明确赋值。 因此，不需要由被调用方明确赋值。 
             * 可以将数组类型的 ref 参数更改为调用的结果。 例如，可以为数组赋以 null 值，或将其初始化为另一个数组。
             */
            // Initialize the array:
            int[] theArray = { 1, 2, 3, 4, 5 };

            // Pass the array using ref:
            FillArray(ref theArray);

            // Display the updated array:
            System.Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            {
                System.Console.Write(theArray[i] + " ");
            }

            // Keep the console window open in debug mode.
            //System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
        static void FillArray(ref int[] arr)
        {
            // Create the array on demand:
            if (arr == null)
            {
                arr = new int[10];
            }
            // Fill the array:
            arr[0] = 1111;
            arr[4] = 5555;
        }

    }
}
