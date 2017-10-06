using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04只允许子类访问修饰符
{
    class Person {
        protected string _name;
        private int _age;

        public int Age { 
            get {return _age;}
            set { _age = value; }
        }
        protected string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
    class Chinaes:Person
    {
        public void Test()
        {
            _name = "子类内部可以访问!";
            Name = "标记protected的方法子类也可以访问";
        }
    }
    class Program
    {
    /// <summary>
    /// protected
    /// 受保护的
    /// 可以在当前内部及子类总访问
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            
        }
    }
}
