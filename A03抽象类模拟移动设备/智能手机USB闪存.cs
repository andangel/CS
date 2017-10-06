using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03抽象类模拟移动设备
{
    class 智能手机USB闪存:可移动存储设备
    {
        public override void 数据读取()
        {
            Console.WriteLine("手机读取数据!");
        }

        public override void 数据写入()
        {
            Console.WriteLine("手机写入数据!");
        }
    }
}
