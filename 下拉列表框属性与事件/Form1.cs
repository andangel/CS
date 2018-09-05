using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 下拉列表框属性与事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //text 属性获取的数据为控件上显示的内容
            //selectedItem是获取当前选择的对象
           
           object obj= ComboBox1.SelectedItem;
            MessageBox.Show(obj.ToString());
        }

        Dictionary<string, string[]> dic = new Dictionary<string, string[]>();
        
            private void Form1_Load(object sender, EventArgs e)
        {

            //添加一个元素
            //ComboBox1.Items.Add("俄语");
            //添加一组数组(初始化器)
            // ComboBox1.Items.AddRange(new string[] { "福建", "江西", "浙江", "上海","江苏" });
            //默认选择第一个
            //ComboBox1.SelectedIndex = 0;


            dic.Add("福建省", new string[] { "福州", "厦门", "莆田", "泉州", "漳州", "龙岩", "三明", "南平", "宁德" });
            dic.Add("江西省", new string[]{"南昌市","赣州市","吉安市","萍乡市","宜春市","新余市","景德镇市","抚州市","九江市","上饶市","鹰潭市" });
            dic.Add( "浙江省",new string[]{ "杭州","宁波","温州","绍兴","湖州","嘉兴","金华","衢州","舟山","台州","丽水" });

            foreach (var item in dic.Keys)
            {
                ComboBox1.Items.Add(item);
            }
            //默认选择第一个
            ComboBox1.SelectedIndex = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //因为我们不希望被修改所以不用Text
            string text = ComboBox1.Text;
            MessageBox.Show(text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           object obj=  ComboBox1.SelectedValue;
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空列表数据
            ComboBox2.Items.Clear();
            //将字典的数组添加进来
            ComboBox2.Items.AddRange(dic[ComboBox1.SelectedItem.ToString()]);
            //
            ComboBox2.SelectedIndex = 0;
        }
    }
}
