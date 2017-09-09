using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A03类的继承
{
    //析构函数
    //当程序结束时执行
    class Program
    {
        static void Main(string[] args)
        {
            Person huang = new Person();
            huang.Name = "黄";
            huang.AGE = 18;
            huang.Gender = Gender.男;
            huang.自我介绍();
        }
    }
}
