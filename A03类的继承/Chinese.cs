using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03类的继承
{
    enum Gender
    {
         男性, 女性
    }

    class Chinese:Person
    {
        //子类私有字段
        private Gender _gender;
        /// <summary>
        /// 子类属性
        /// </summary>
        public  Gender Gender {
            get
            {
                return _gender;
            }
            set {
                _gender = value;
            }
        }
        public Chinese() { }
        /// <summary>
        /// 显示调用父类构造函数
        /// </summary>
        /// <param name="name"></param>
        public Chinese(string name) : base(name) { }

        public Chinese(string name, int age) : base(name,age){ }

        public Chinese(string name, int age, Gender gender) : base(name, age)
        {
            this.Gender = gender;
        }


        /// <summary>
        /// 方法与父类方法同名，nwe隐藏基类方法
        /// 
        /// </summary>
        public new void Introduce()
        {
            Console.WriteLine("我叫 {0}，我今年 {1} 岁, 我是 {2}", this.Name, this.AGE, this.Gender);
        }
        public new void Say()
        {
            Console.WriteLine("我是衍生类中国人类!");
        }
    }
}
