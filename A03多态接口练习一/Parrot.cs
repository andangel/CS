using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多态接口练习一
{
    /// <summary>
    /// 鹦鹉
    /// </summary>
    class Parrot:Birds,IFlyable
    {
        public void Flyable()
        {
            Console.WriteLine("鹦鹉会飞!");
        }
    }
}
