using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01装箱和取消装箱
{
    /*
    装箱是将值类型转换为 object 类型或由此值类型实现的任何接口类型的过程。 
    当 CLR 对值类型进行装箱时，会将该值包装到 System.Object 内部，再将后者存储在托管堆上。 
    取消装箱将从对象中提取值类型。 装箱是隐式的；取消装箱是显式的。 
    装箱和取消装箱的概念是类型系统 C# 统一视图的基础，其中任一类型的值都被视为一个对象。 
    */
    class Program
    {
        static void Main(string[] args)
        {
            //下例将整型变量 i 进行了装箱并分配给对象O
            int i = 123;
            // 装箱 i.
            object o = i;
            o = 123;
            i = (int)o;  // 取消装箱
        }
    }
}
