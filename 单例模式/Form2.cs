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
            if (FrmSingle == null)//有bug 第二次创建程序崩溃
            {
                FrmSingle = new Form2();
            }
            return FrmSingle;
        }
    }
}
