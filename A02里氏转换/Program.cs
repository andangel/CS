using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02里氏转换
{
    class Program
    {
        /// <summary>
        /// 里氏转换
        /// 1.子类可以赋值给父类:如果需要父类作为参数,可以给个子类代替
        /// 2.父类中装的是子类对象,可以父类对象强转为子类对象
        /// 3.is:如果转换成功返回true,否则返回false
        /// 4.as:如果转换成功返回一个对象,否则返回null
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Chinese huang = new Chinese("黄", 18, 性别.男性);
            //Person huang =new Chinese("黄", 18, 性别.男性);//这里用父类new对象在下面调用方法会把父类方法一起调用一遍
            if (huang is Person)
            {
                huang.Introduce();
            }
            else { Console.WriteLine("转换失败"); }
            
            if (huang as Person!=null)
            {
                huang.Introduce();
            }

            Person[] pers = new Person[10];
            Random r = new Random();
            for (int i = 0; i < pers.Length; i++)
            {
                int rNumber = r.Next(1,8);
                switch (rNumber)
                {
                    case 1: pers[i]=new American();
                        break;
                    case 2: pers[i] = new Chinese();
                        break;
                    case 3:pers[i] = new Englisher();
                        break;
                    case 4:pers[i] = new Germans();
                        break;
                    case 5:pers[i] = new Japanese();
                        break;
                    case 6:pers[i] = new Korean();
                        break;
                    case 7: pers[i] = new Person();
                        break;
                    case 8:pers[i] = new Russians();
                        break;
                }

            }
            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i] is American)
                {
                    ((American)pers[i]).Say();
                }
                else if (pers[i] is Chinese)
                {
                    ((Chinese)pers[i]).Say();
                }
                else if (pers[i] is Englisher)
                {
                    ((Englisher)pers[i]).Say();

                }
                else if (pers[i] is Germans)
                {
                    ((Germans)pers[i]).Say();

                }
                else if (pers[i] is Japanese)
                {
                    ((Japanese)pers[i]).Say();

                }
                else if (pers[i] is Korean)
                {
                    ((Korean)pers[i]).Say();

                }
                else if (pers[i] is Russians)
                {
                    ((Russians)pers[i]).Say();

                }
                else
                {
                    pers[i].Say();
                }
            }
        }
    }
}
