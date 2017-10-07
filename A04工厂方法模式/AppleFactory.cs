using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04工厂方法模式
{
    class AppleFactory : ComputerFactory
    {
        public override Computer ComputerCreate()
        {
            return new Apple();
        }
    }
}
