using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03类的继承
{
    enum 性别
    {
         男性, 女性
    }

    class Chinese:Person
    {
        //子类私有字段
        private 性别 _gender;
        /// <summary>
        /// 子类属性
        /// </summary>
        public  性别 Gender { get => _gender; set => _gender = value; }
        public Chinese() { }
        /// <summary>
        /// 显示调用父类构造函数
        /// </summary>
        /// <param name="name"></param>
        public Chinese(string name) : base(name) { }

        public Chinese(string name, int age) : base(name,age){ }

        public Chinese(string name, int age, 性别 gender) : base(name, age) { this.Gender = gender; }


        /// <summary>
        /// 方法与父类方法同名，nwe隐藏基类方法
        /// 
        /// </summary>
        public new void Introduce()
        {
            Console.WriteLine("我叫 {0}，我今年 {1} 岁, 我是 {2}", this.Name, this.AGE, this.Gender);
        }
        public void Say()
        {
            Console.WriteLine("我是中国人!");
        }
    }
}
