using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04工厂方法模式
{
    abstract class Computer
    {
         public abstract void StartUp();
         public abstract void Run();
         public abstract void Stop();
    }
}
