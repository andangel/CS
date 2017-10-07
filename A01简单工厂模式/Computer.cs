using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01简单工厂模式
{
   abstract class Computer
    {
        public abstract void Start();
        public abstract void Run();
        public abstract void Stop();
    }
}
