using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01简单工厂模式
{
    /// <summary>
    /// 电脑工厂
    /// </summary>
    abstract class ComputerFactory
    {
        public abstract Computer ComputerCreate();

        public abstract void Brand();
    }
}
