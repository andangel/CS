using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01类的基本语法Test
{
    class Program
    {
        //写一个Ticket类,有一个距离属性(本属性只读,在构造方法中赋值),
        //不能为负数,有一个价格属性,价格属性只读,
        //并且根据距离distance计算价格Price (1元/公里):
        //0-100公里      票价不打折
        //101-200公里    总额打9.5折
        //201-300公里    总额打9折
        //300公里以上    总额打8折
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket(301);
            ticket.Settlement();
            Console.ReadKey();
        }
    }
}
