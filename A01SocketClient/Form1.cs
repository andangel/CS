using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace A01SocketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket socketSend;
        
        private void button1_Click(object sender, EventArgs e)
        {
            //创建负责通信的Socket
             socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //获取文本框内的IP地址
            IPAddress ip = IPAddress.Parse(textServer.Text);
            //获取文本框内的端口号,并转换为int类型
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textPort.Text));
            socketSend.Connect(point);
            ShowMsg("连接成功!");
        }
        public void ShowMsg(string log)
        {
            textLog.AppendText(log + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textMsg.Text.Trim();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            socketSend.Send(buffer);
            textLog.AppendText(System.DateTime.Now.ToString("hh:mm:ss")+"\r\n" + str);
        }
    }
}
