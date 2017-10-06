using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02多态抽象类
{
    /// <summary>
    /// 狗的抽象类
    /// </summary>
    class Dog:Animal
    {
       
        public override void Bark()
        {
            Console.WriteLine("狗狗汪汪叫!");
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
