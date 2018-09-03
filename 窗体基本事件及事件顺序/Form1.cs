using System;
using System.Windows.Forms;

namespace 窗体基本事件及事件顺序
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            //初始化窗体基本信息
            //如果将代码卸载Init方法后,可能引发事件顺序错乱
            InitializeComponent();


            //如果在面板里删除Load事件可以通过手动绑定事件如下
            //this.Load+=FormMain_Load;
            //代码自动生成的Load事件是带有Private
            //代码自动生成的事件绑定在InitializeComponent()内.
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //窗体第一次被初始化.(窗体标题,窗体大小,是否允许最大化,最小化)
            this.Text = "这是由Load事件修改的窗体标题";
        }
        //使用任务管理器对软件结束时,不会触发改事件,因为事件只能处理程序内部消息
        
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //后
            //可以利用断点来分析顺序
            //执行完Closing后再执行此事件
            //
            MessageBox.Show("Closed事件", "2", MessageBoxButtons.OK);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //前
            //当我点击事件按钮时,先执行此事件.
            //如果需要执行清理.销毁对象,代码卸载此处更合适.
            MessageBox.Show("Closing事件","1", MessageBoxButtons.OK);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Close()先执行Closing事件再执行Closed事件
            this.Close();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            //窗体修改事件
            //this.Width = 600;
            //this.Height =500;
            this.Text = string.Format("当前窗体宽:{0},高:{1}", this.Width,this.Height);
        }
    }
}
