using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03类的继承
{
    class Program
    {
        /// <summary>
        /// 1.集成的单根性：
        ///     子类只能有一个父类
        ///     子类不集成父类的构造函数。
        /// 2.集成的传递性：
        ///     子类继承父类的属性，方法，并不集成父类私有字段。
        ///     子类不集成父类的构造函数。
        ///创建子类对象的时候,子类内部创建类父类对象,所以父类必须要有无参构造函数
        ///1.父类里写上无参构造函数
        ///或
        ///2.子类里利用BASE显示调用父类构造函数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Chinese huang = new Chinese("huang", 18,性别.男性);
            huang.Introduce();
            
        }
    }
}
