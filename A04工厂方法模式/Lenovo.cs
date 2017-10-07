using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04工厂方法模式
{
    class Lenovo : Computer
    {
        public override void Run()
        {
            Console.WriteLine("测试联想电脑性能!");
        }

        public override void StartUp()
        {
            Console.WriteLine("联想电脑运行正常!");
        }

        public override void Stop()
        {
            Console.WriteLine("关闭联想电脑!");
        }
    }
}
