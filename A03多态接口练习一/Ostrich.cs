using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多态接口练习一
{
    /// <summary>
    /// 鸵鸟
    /// </summary>
    class Ostrich:Birds,IFlyable
    {
        public void Flyable()
        {
            Console.WriteLine("鸵鸟不会飞!");
        }
    }
}
