using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03交错数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //下面声明一个具有三个元素的一维数组，其中每个元素都是一维整数数组： 
            int[][] jaggedArray = new int[3][];
            //必须初始化 jaggedArray 的元素后才可使用它。 可按下方操作初始化元素： 
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];
            //每个元素都是一维整数数组。 第一个元素是由 5 个整数组成的数组，第二个是由 4 个整数组成的数组，而第三个是由 2 个整数组成的数组。 
            //也可使用初始化表达式通过值来填充数组元素，这种情况下不需要数组大小。 例如:
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };
            //还可在声明数组时将其初始化，如： 花括号后面有分号
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
            };
            //可以使用下面的缩写形式。 请注意：不能从元素初始化中省略 new 运算符，因为不存在元素的默认初始化： 
            int[][] jaggedArray3 =
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
            };
            //交错数组是数组的数组，因此其元素为引用类型且被初始化为 null。 
            //可以如下例所示访问个别数组元素： 
            // Assign 77 to the second element ([1]) of the first array ([0]):
            jaggedArray3[0][1] = 77;

            // Assign 88 to the second element ([1]) of the third array ([2]):
            jaggedArray3[2][1] = 88;
            //可以混合使用交错数组和多维数组。 下面声明和初始化一个包含大小不同的三个二维数组元素的一维交错数组。
            int[][,] jaggedArray4 = new int[3][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };
            //可以如本例所示访问个别元素，示例显示第一个数组的元素 [1,0] 的值（值为 5）： 
            System.Console.Write("访问{0}\n", jaggedArray4[0][1, 0]);
            //方法 Length 返回包含在交错数组中的数组的数目。 例如，假定已声明了前一个数组，则此行： 
            System.Console.WriteLine(jaggedArray4.Length);
            Console.WriteLine();
            
            //本例生成一个数组，该数组的元素为数组自身。 每一个数组元素都有不同的大小。 
            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("元素({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
