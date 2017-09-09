using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01类的基本语法
{
    enum Gender
    {
        男=1,女=2, 未知的=0
    }
    class Person
    {
        //字段
        string _name;
        int _age;
        Gender _gender;
        //构造函数
        public Person()
        {
            
        }
        public Person(string name)
        {
            //this.Name = name;
            if (string.Empty == name)
            {
                this._name = "姓名为空";
            }
            else
            {
                this._name = name;
            }
        }
        public Person(string name, Gender gender):this(name)
        {
            if (gender<=0)
            {
                this._gender = 0;
            }
            else
            {
                this._gender = gender;
            }
        }
        //构造函数重载
        public Person(string name, Gender gender,int age):this(name,gender)
        {
            if (age <= 0)
            {
                this._age = 1;
            }
            else
            {
                this._age = age;
            }

        }
        //属性
        //只有get方法设置为只读属性,在构造函数里做条件限制
        public string Name
        { get {
                return _name;
              }
          //set {
          //      _name = value;
          //    }
        }
        //=>(lambda 运算符),不直观
        public int Age { get => _age; /*set => _age = value;*/ }
        
        //internal 内部类型或成员访问修饰符

        internal Gender Gender {
            get {
                return _gender;
            }
             }
        
        //方法
        /// <summary>
        /// 输出对象数据.
        /// </summary>
       public void PrintContents()
        {
            Console.WriteLine("我叫{0},性别{1},今年{2}岁",this.Name,this.Gender,this.Age);
        }
        
    }
}
