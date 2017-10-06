using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03抽象类模拟移动设备
{
    class Program
    {
        /// <summary>
        /// 多态模拟移动设备插入电脑读写数据 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            可移动存储设备 MP3 = new 音乐播放设备();
            可移动存储设备 音乐播器 = new 音乐播放设备();
            可移动存储设备 USBFlashDisk = new 通用闪存();
            可移动存储设备 U盘 = new 通用闪存();
            可移动存储设备 MobileHardDisk = new 移动硬盘设备();
            可移动存储设备 移动硬盘 = new 移动硬盘设备();
            可移动存储设备 PhoneUSBFlashDisk = new 智能手机USB闪存();
            可移动存储设备 手机闪存 = new 智能手机USB闪存();
            计算机 Computer = new 计算机();
            //Computer.通用串行总线读取(PhoneUSBFlashDisk);
            //Computer.通用串行总线写入(PhoneUSBFlashDisk);
            Computer.设备 = 移动硬盘;
            Computer.通用串行总线读取();
        }
    }
}
