using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02多态抽象类
{
    /// <summary>
    /// 猫的抽象类
    /// </summary>
    class Cat:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵叫!");
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override int Age
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
