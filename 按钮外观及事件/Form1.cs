using System;
using System.Drawing;
using System.Windows.Forms;

namespace 按钮外观及事件
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //改变按钮1位置
            Button1.Location = new Point(675, 499);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Text="要让字体自适应DPI只需创建一个manifest配置清单";
            Button1.Text = "关闭";
            Button1.Font = new Font("微软雅黑", 26, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            Button1.ForeColor = SystemColors.HotTrack;
            Button2.Text = "开始";
            Button2.Font = new Font("微软雅黑", 26, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            Button2.ForeColor = SystemColors.HotTrack;
        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            //右键中键其他键
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("右键!");
            }
            toolStripStatusLabel1.Text = string.Format("X:{0},Y:{1},button:{2},Clockes:{3}",e.X.ToString(), e.Y.ToString(),e.Button,e.Clicks);

        }
    }
}
