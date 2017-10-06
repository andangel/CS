using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02多态抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.Bark();
            cat.Bark();
        }
    }
}
