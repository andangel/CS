using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03多态接口
{
    /// <summary>
    /// 不允许有访问修饰符 默认为Public
    /// 可以有方法 自动属性
    /// 接口不能被实例化
    /// 接口只能继承接口
    /// 一个类能继承一个类但可以继承多个接口
    /// </summary>
    interface IFlying
    {
        void 飞行();

    }
}
