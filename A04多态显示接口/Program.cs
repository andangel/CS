using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04多态显示接口
{
    /// <summary>
    /// 显示时间接口就是为了解决方法重命名问题
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Birds();
            fly.Flyable();
            Birds bird = new Birds();
            bird.Flyable();
        }
    }
    public class Birds:IFlyable
    {
        public void Flyable()
        {
            Console.WriteLine("鸟会飞!");
        }
        void IFlyable.Flyable()
        {
            Console.WriteLine("我是接口的飞!");
        }
        
    }
    public interface IFlyable
    {
         void Flyable();
    }
}
