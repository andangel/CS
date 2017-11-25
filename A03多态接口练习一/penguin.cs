using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多态接口练习一
{
    /// <summary>
    /// 企鹅
    /// </summary>
    class Penguin:Birds,IFlyable
    {
        public void Flyable()
        {
            Console.WriteLine("企鹅不会飞!");
        }
    }
}
