using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01虚方法练习一
{
    class Program
    {
        static void Main(string[] args)
        {
            中国人 c1 = new 中国人("c1", 1);
            中国人 c2 = new 中国人("c2", 2);
            美国人 a1 = new 美国人("a1", 3);
            美国人 a2 = new 美国人("a2", 4);
            日本人 j1 = new 日本人("j1", 5);
            日本人 j2 = new 日本人("j2", 6);
            人类[] r = { c1, c2, j1, j2, a1, a2 };
            for (int i = 0; i < r.Length ; i++)
            {
                r[i].Say();
            }

        }
    }
}
