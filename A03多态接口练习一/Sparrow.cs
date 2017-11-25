using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多态接口练习一
{
    /// <summary>
    /// 麻雀
    /// </summary>
    class Sparrow:Birds,IFlyable
    {
        public void Flyable()
        {
            Console.WriteLine("麻雀会飞!");
        }
    }
}
