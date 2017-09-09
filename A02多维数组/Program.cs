using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02多维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明多维数组格式 数据类型[,]多少个逗号声明多少维的数组
            //数组可具有多个维度。 例如，以下声明创建一个具有四行二列的2维数组。 
            int[,] array = new int[4, 2];


            //以下声明创建一个具有三个维度（4、2 和 3）的数组。 
            int[,,] array1 = new int[4, 2, 3];
            //数组初始化
            //声明后即可初始化数组，如以下示例所示。 
            
            // 声明二维数组
            int[,] array2D = new int[,] 
            { 
              //[0,0][0,1]
                { 11, 22 },
              //[1,0][1,1]
                { 33, 44 },
              //[2,0][2,1]
                { 55, 66 },
              //[3,0][3,1]
                { 77, 88 }
            };
            foreach (var item in array2D)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
            // 声明4行2列的元素数组
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // 声明3行2列元素数组
            string[,] array2Db = new string[3, 2] 
            { 
                { "one", "two" }, 
                { "three", "four" },
                { "five", "six" }
            };
            //GetLength:数组维度
            for (int i = 0; i < array2Db.GetLength(0); i++)
            {
                for (int j = 0; j < array2Db.GetLength(1); j++)
                {
                    Console.Write("{0}\t",array2Db[i,j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array2Db.Length/ array2Db.Rank; i++)
            {
                //arr[0,0]
                //arr[0,1]
                //arr[1,0]
                //arr[1,1]
                for (int j = 0; j < array2Db.Rank; j++)
                {
                    Console.WriteLine("{0}",array2Db[i,j]);
                }
            }
            // 声明三维数组4行3列
            int[,,] array3D = new int[,,] { 
                { 
                    { 1, 2, 3 }, 
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 }, 
                    { 10, 11, 12 }
                }
            };
            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] { 
                { 
                    { 1, 2, 3 }, 
                    { 4, 5, 6 }
                },
                { { 7, 8, 9 }, 
                  { 10, 11, 12 }
                }
            };

            // Accessing array elements.
            System.Console.WriteLine(array2D[0, 0]);
            System.Console.WriteLine(array2D[0, 1]);
            System.Console.WriteLine(array2D[1, 0]);
            System.Console.WriteLine(array2D[1, 1]);
            System.Console.WriteLine(array2D[3, 0]);
            System.Console.WriteLine(array2Db[1, 0]);
            System.Console.WriteLine(array3Da[1, 0, 1]);
            System.Console.WriteLine(array3D[1, 1, 2]);



        }
    }
}
