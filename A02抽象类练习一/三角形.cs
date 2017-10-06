using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02抽象类练习一
{
    class 三角形:形状
    {
        /// <summary>
        /// 底*高/2
        /// </summary>
        /// <returns></returns>
        public override double 求面积(double 底,double 高)
        {
            return (底 * 高) / 2;
        }
        /// <summary>
        /// 三边的和
        /// </summary>
        /// <returns></returns>
        public override double 求周长(double 边1,double 边2,double 边3)
        {
            return 边1 + 边2 + 边3;
        }
    }
}
