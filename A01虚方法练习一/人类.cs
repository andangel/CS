using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01虚方法练习一
{
    class 人类
    {
        string _name;
        int _age;
        public string Nmae
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public 人类() { }
        public 人类(string name)
        {
            this.Nmae = name;
        }
        public 人类(string name, int age)
            : this(name)
        {
            this.Age = age;
        }
        public virtual void Say()
        {
            Console.WriteLine("我是人类,叫{0}今年{1}岁",this.Nmae,this.Age);
        }

    }
}
