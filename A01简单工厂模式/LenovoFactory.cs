using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01简单工厂模式
{
    class LenovoFactory : ComputerFactory
    {
        public override void Brand()
        {
            Console.WriteLine("联想!");
        }
    }
}
