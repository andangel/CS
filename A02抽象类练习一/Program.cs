using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02抽象类练习一
{
    class Program
    {
        static void Main(string[] args)
        {
            形状 c1 = new 长方形(20, 13.1);
            Console.WriteLine(c1.求面积());
            Console.WriteLine(c1.求周长());
            形状 s1 = new 三角形();
            
        }
    }
}
