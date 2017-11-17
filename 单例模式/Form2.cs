using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 单例模式
{
    public partial class Form2 : Form
    {
        //全局唯一的单例字段
        public static Form2 FrmSingle=null;

        //public Form2() 将构造函数私有化
        private Form2()
        {
            InitializeComponent();
        }
        //创建窗口的静态方法
        public static Form2 Getsingle()
        {
           // Form2 frm2 = new Form2();
            //return frm2;
            if (FrmSingle == null||FrmSingle.IsDisposed)//有bug 第二次创建程序崩溃
            //bug解决思路:C#的自动回收机制。关闭窗体。它就设为IsDisposed为true，表示该窗口占用的resource已经释放了。但是这时候系统可能还没有收集。只是标识这个该收集了。至于什么时候收集就是系统决定的了。所以你去判断的时候它不为空，就不会创建新的。但是它已经把所有的资源释放了。所以这套机制就不让你去访问啊。因为它不一定什么时候就被回收了。那就是null了。 
            {
                FrmSingle = new Form2();
            }
            return FrmSingle;
        }
    }
}
