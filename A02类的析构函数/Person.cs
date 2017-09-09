using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

enum Gender {
    未知,男,女
}
namespace A03类的继承
{
    
    class Person
    {
        string _name;
        int _age;
        Gender _gender;

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
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public Person() { }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, int age) : this(name)
        {
            this.AGE = age;
        }
        public Person(string name, int age, Gender gender) : this(name, age)
        {
            this.Gender = gender;
        }
        public void 自我介绍()
        {
            Console.WriteLine("我叫:{0}今年:{1}岁,性别:{2}",this.Name,this.AGE,this.Gender);
        }
        //析构函数
        //程序结束时执行,主要用于释放资源
        ~Person()
        {
            Console.WriteLine("我是析构函数!程序结束时运行,主要用于释放资源.");
        }
    }

}
