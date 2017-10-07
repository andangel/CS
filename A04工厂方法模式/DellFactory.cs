using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04工厂方法模式
{
    class DellFactory : ComputerFactory
    {
        public override Computer ComputerCreate()
        {
            return new Dell();
        }
    }
}
