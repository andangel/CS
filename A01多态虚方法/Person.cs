using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01多态虚方法
{
    class Person
    {
        private string _name;
        private int _age;

        public string Name {get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public Person() { }
        public Person(string name) => Name = name;
        public Person(string name, int age) : this(name) => Age = age;
        /// <summary>
        /// virtual标记虚方法,表示此方法可以被子类重写
        /// </summary>
        public virtual void Say() => Console.WriteLine("我叫:{0},现在:{1}岁,我是人类!",Name,Age);
    }
}
