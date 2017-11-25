using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03多态接口
{
    class SuperMan:Person,IFlying
    {



        public void 飞行()
        {
            Console.WriteLine("我是超人我能飞行");
        }
    }
}
