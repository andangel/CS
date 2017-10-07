using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04工厂方法模式
{
    class Apple : Computer
    {
        public override void Run()
        {
            Console.WriteLine("测试苹果电脑性能!");
        }

        public override void StartUp()
        {
            Console.WriteLine("苹果电脑运行正常!");
        }

        public override void Stop()
        {
            Console.WriteLine("关闭苹果电脑!");
        }
    }
}
