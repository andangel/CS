using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02多态抽象类
{
    /// <summary>
    /// 抽象类无法被实例化但能被子类继承
    /// abstract 抽象类与抽象方法关键字
    /// 抽象方法没有方法体
    /// 父类函数无法实现则用抽象类
    /// </summary>
   abstract class  Animal
   {
       /// <summary>
       /// 字段
       /// 虽然抽象类不能实例化自己但可以给子类继承
       /// </summary>
       string _name;
       int _age;
       /// <summary>
       /// 构造函数(非抽象成员)
       /// 给子类继承
       /// </summary>
       public Animal() { }
       public Animal(string name) {
           this.Name = name;
       }
       public Animal(int age) {
           this.Age = age;
       }
       /// <summary>
       /// 抽象属性
       /// </summary>
       public abstract string Name { get; set; }
       public abstract int Age { get; set; }
       /// <summary>
       /// 抽象方法
       /// </summary>
       public abstract void Bark();

   }
}
