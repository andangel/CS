using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多态接口练习一
{
    /// <summary>
    /// 麻雀会飞 鹦鹉会飞 鸵鸟不会飞 企鹅不会飞 直升飞机会飞
    ///
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Birds[] bird = new Birds [10];
            Random r = new Random();
            for (int i = 0; i < bird.Length; i++)
            {
                int rNumber = r.Next(1,4);
                switch (rNumber)
                 {
                    case 1: bird[i]=new Sparrow();
                        break;
                    case 2: bird[i] = new Penguin();
                        break;
                    case 3:bird[i] = new Parrot();
                        break;
                    case 4:bird[i] = new Ostrich();
                        break;
                }
            }
            for (int i = 0; i < bird.Length; i++)
            {
                if (bird[i] is Sparrow)
                {
                    ((Sparrow)bird[i]).Flyable();
                }
                else if (bird[i] is Penguin)
                {
                    ((Penguin)bird[i]).Flyable();
                }
                else if (bird[i] is Parrot)
                {
                     ((Parrot)bird[i]).Flyable();
                }
                else if (bird[i] is Ostrich)
                {
                    ((Ostrich)bird[i]).Flyable();
                }
            }
        }
    }
}
