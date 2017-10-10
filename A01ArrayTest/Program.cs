using System;

namespace Test
{

    class Program
    {
        static void Change2dDArray(int[,] array)
        {
            int value = 1;
            if (array.Rank == 2)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = value;
                        value++;

                    }
                }
            }
            else
            {
                Console.WriteLine("这不是一个二维数组.");
            }
        }
        static void Print2DArray(int[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" {0} ",arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
            int[,] array = new int[10,10];
            Change2dDArray(array);
            Print2DArray(array);
            

        }
    }
}
