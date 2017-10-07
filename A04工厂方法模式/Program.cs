using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace A04工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入工厂模式编号:");
            Console.WriteLine("****************");
            Console.WriteLine("工厂模式");
            Console.WriteLine("1 苹果电脑工厂");
            Console.WriteLine("2 戴尔电脑工厂");
            Console.WriteLine("3 联想电脑工厂");
            Console.WriteLine("****************");
            //int key = Int32.Parse(Console.ReadLine().ToString());
            //string factoryType = ConfigurationManager.AppSettings["No" + key];
            int input = int.Parse(Console.ReadLine());
            ComputerFactory factory = null;
            switch (input)
            {
                case 1:
                    factory = new AppleFactory();
                    break;
                case 2:
                    factory = new DellFactory();
                    break;
                case 3:
                    factory = new LenovoFactory();
                    break;
                default:
                    break;
            }

            //ComputerFactory factory = (ComputerFactory)Assembly.Load("工厂模式").CreateInstance("工厂模式" + factoryType);
            Computer computer = factory.ComputerCreate();
            computer.StartUp();
            computer.Run();
            computer.Stop();
        }
    }
}
