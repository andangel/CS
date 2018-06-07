using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace A03类的继承
{
    
    class Person
    {
        /// <summary>
        /// 字段
        /// </summary>
       private string _name;
       private int _age;

        /// <summary>
        /// 属性
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int AGE
        {
            get {
                return _age;}
            set {
                _age = value; }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public Person() { }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, int age) : this(name)
        {
            this.AGE = age;
        }

        /// <summary>
        /// 自我介绍
        /// </summary>
        public void Introduce()
        {
            Console.WriteLine("我是:{0} 现在{1}岁 ", this.Name,this.AGE);
        }
        //析构函数
        ////程序结束时执行,主要用于释放资源
        //~Person()
        //{
        //    Console.WriteLine("我是析构函数!程序结束时运行,主要用于释放资源.");
        //}
        public void Say()
        {
            Console.WriteLine("我是基类人类!");
        }
    }

}
