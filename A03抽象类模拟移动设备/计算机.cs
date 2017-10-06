using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03抽象类模拟移动设备
{
    class 计算机
    {
        private 可移动存储设备 _USB设备;
        public 可移动存储设备 USB设备
        {
            get { return _USB设备; }
            set { _USB设备 = value; }
        }
        public void 通用串行总线读取()
        {
            USB设备.数据读取();
        }
        public void 通用串行总线写入()
        {
            USB设备.数据写入();
        }

    }
}
