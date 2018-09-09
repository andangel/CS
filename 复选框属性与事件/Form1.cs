using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
 * 思路步骤
 * 1.需要在窗体加载完成时获取所有的CheckBox
 *      使用name(如果控件很多时是噩梦)
 *      可以利用Controls获取控件集合
 * 2.对这些CheckBox完成事件赋值
 */
namespace 复选框属性与事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            #region 演示代码 快捷键Ctrl+k+S
            //if (CheckBox1.Checked)
            //{
            //    MessageBox.Show("复选框1被选中");
            //}
            //else
            //{
            //    MessageBox.Show("复选框1没选中");
            //} 
            #endregion
        }
        List<CheckObject> checkList;
        void GetCheckBoxState(CheckBox check)
        {
            string text = check.Text;
            bool isChecked = check.Checked;
            //对象初始化,注意是局部变量赋值给类方法.
            CheckObject co = new CheckObject()
            {
                Text = text,
                IsChecked = isChecked
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化check列表
            checkList = new List<CheckObject>();
            //获取Controls集合内的CheckBox对象
            for (int i = 0; i < this.Controls.Count; i++)
            {
                CheckBox cb = this.Controls[i] as CheckBox;
                // cb.Text ="复选框 "+(i+1).ToString();
                cb.CheckedChanged += CheckObjectCheckedChanged;
            }
        }
        /// <summary>
        /// 对象改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckObjectCheckedChanged(object sender, EventArgs e)
        {
            //类型转换
            CheckBox cb = (CheckBox)sender;
            GetCheckBoxState(cb);
        }
    }
}
