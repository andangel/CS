using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02里氏转换
{
    class Korean:Person
    {
        public new void Say()
        {
            Console.WriteLine("我是韩国人!");
        }
    }
}
