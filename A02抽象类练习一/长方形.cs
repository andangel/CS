using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02抽象类练习一
{
    class 长方形:形状
    {
        public 长方形() { }

        public 长方形(double 长, double 宽)
        {
            this.L = 长;
            this.W = 宽;
        }
        /// <summary>
        /// (长+宽)*2
        /// </summary>
        /// <returns></returns>
        public override double 求面积()
        {
            return (this.L + this.W) * 2;
        }
        /// <summary>
        /// 长*宽
        /// </summary>
        /// <returns></returns>
        public override double 求周长()
        {
            return (this.L * this.W);
        }
    }
}
