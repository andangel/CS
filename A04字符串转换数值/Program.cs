using System;

namespace A04字符串转换数值
{
    class Program
    {
        static void Main(string[] args)
        {
            int numVal = -1;//为何不是0而是-1？
            bool repeat = true;//判断循环开关

            while (repeat)
            {
                Console.WriteLine("输入一个（-2,147,483,648 至 +2,147,483,647 ）范围内的数字.");

                string input = Console.ReadLine();

                // ToInt32 can throw FormatException or OverflowException.
                try
                {
                    numVal = Convert.ToInt32(input);//将字符串转换int类型
                }
                catch (FormatException e)
                {
                    Console.WriteLine("输入字符串不是一串数字。 ");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("这数值不是 Int32类型范围之内的数.");
                }
                finally
                {
                    if (numVal < Int32.MaxValue)
                    {
                        Console.WriteLine("numVal新的的值是 {0}", numVal + 1);
                    }
                    else
                    {
                        Console.WriteLine("numVal 不能超出其当前值。");
                    }
                }
                Console.WriteLine("继续? Y/N");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }
            Console.WriteLine("按任意键退出.");
            Console.ReadKey();

        }
    }
}
