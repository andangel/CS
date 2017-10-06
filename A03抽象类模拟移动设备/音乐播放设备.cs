using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03抽象类模拟移动设备
{
    class 音乐播放设备:可移动存储设备
    {
        public override void 数据读取()
        {
            Console.WriteLine("MP3在读取数据!");
        }

        public override void 数据写入()
        {
            Console.WriteLine("MP3在写入数据!");
        }
        public void 播放音乐()
        {
            Console.WriteLine("MP3播放音乐媒体!");
        }
    }
}
