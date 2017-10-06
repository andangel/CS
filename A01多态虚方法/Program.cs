using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01多态虚方法
{
    /// <summary>
    /// 
    /// 在父类方法返回之前标记virtual
    /// 在子类同名方法标记override
    /// 这样子类就可以重写父类方法
    /// </summary>
    class Program
    {
        /// <summary>
        /// 虚方法的实现
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Chinese c1 = new Chinese("c1", 1);
            Chinese c2 = new Chinese("c2", 2);
            Japanese j1 = new Japanese("j1", 3);
            Japanese j2 = new Japanese("j2", 4);
            Koreans k1 = new Koreans("k1", 5);
            Koreans k2 = new Koreans("k2", 6);
            American a1 = new American("a1", 7);
            American a2 = new American("a2", 8);
            Person[] p = { c1, c2, j1, j2, k1, k2, a1, a2 };
            for (int i = 0; i < p.Length; i++)
            {
                p[i].Say();
            }
        }
    }
}
