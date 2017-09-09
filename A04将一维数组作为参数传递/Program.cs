using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04将一维数组作为参数传递
{
    /// <summary>
    /// 描述
    ///在下面的示例中，先初始化一个字符串数组，然后将其作为参数传递给字符串的 PrintArray 方法。 
    ///该方法将显示数组的元素。 然后，调用 ChangeArray 和 ChangeArrayElement 方法，
    ///演示根据值发送数组参数不会阻止对数组元素的更改。 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 打印数组
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : "");
            }
            System.Console.WriteLine();
        }
        /// <summary>
        /// 改变数组顺序
        /// </summary>
        /// <param name="arr"></param>
        static void ChangeArray(string[] arr)
        {
            // The following attempt to reverse the array does not persist when
            // the method returns, because arr is a value parameter.
            
            //这里用ToArray方法重新创建了个数组所以到函数外面并没有改变数据
            //arr = (arr.Reverse()).ToArray();
             Array.Reverse(arr);
           
            // The following statement displays Sat as the first element in the array.
            System.Console.WriteLine("在 ChangeArray函数中: arr[0]的值是:{0} .", arr[0]);
        }
        /// <summary>
        /// 改变数组元素数值
        /// </summary>
        /// <param name="arr"></param>
        static void ChangeArrayElements(string[] arr)
        {
            // The following assignments change the value of individual array 
            // elements. 
            arr[0] = "Mon";
            arr[1] = "Tue";
            arr[2] = "Wed";
            arr[3] = "Thu";
            arr[4] = "Fri";
            arr[5] = "Sat";
            arr[6] = "sun";
            // The following statement again displays Sat as the first element
            // in the array arr, inside the called method.
            System.Console.WriteLine("在ChangeArrayElements函数中arr[0]的值是:{0}.", arr[0]);
        }

        static void Main(string[] args)
        {
            // Declare and initialize an array.
            string[] weekDays = {  "周一", "周二", "周三", "周四", "周五", "周六","周日"};
            System.Console.WriteLine("数组 weekDays传递变量前:");
            // Pass the array as an argument to PrintArray.
            PrintArray(weekDays);
            System.Console.WriteLine();

            // ChangeArray tries to change the array by assigning something new
            // to the array in the method. 
            ChangeArray(weekDays);
            System.Console.WriteLine();
            // Print the array again, to verify that it has not been changed.
            System.Console.WriteLine("数组 weekDays 在传递ChangeArray函数之后:");
            PrintArray(weekDays);
            //System.Console.WriteLine("数组 weekDays 在传递ChangeArray函数之后 数值并没有改变");
            System.Console.WriteLine();


            // ChangeArrayElements assigns new values to individual array
            // elements.
            ChangeArrayElements(weekDays);
            Console.WriteLine();
            // The changes to individual elements persist after the method returns.
            // Print the array, to verify that it has been changed.
            System.Console.WriteLine("数组 weekDays 在传递 ChangeArrayElements函数之后:");
            PrintArray(weekDays);


        }
    }
}
