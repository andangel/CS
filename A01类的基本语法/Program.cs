using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01类的基本语法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xiaobai = new Person("");//实例化对象
                                          //xiaobai.Name = "小白";
                                          // xiaobai.Gender = Gender.男;
                                          //  xiaobai.Age = 18;
            xiaobai.PrintContents();
            Person xiaohong = new Person("小红", Gender.女, 17);
            xiaohong.PrintContents();
        }
    }
}
