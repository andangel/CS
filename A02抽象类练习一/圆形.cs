using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02抽象类练习一
{
    class 圆形:形状
    {
        public override double 求面积()
        {
            throw new NotImplementedException();
        }

        public override double 求周长()
        {
            throw new NotImplementedException();
        }
    }
}
