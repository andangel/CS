using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace A02SocketServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;//IPAddress.Parse(txtServer.Text);
                //创建端口号对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textPort.Text));
                socketWatch.Bind(point);
                ShowMsg("开始监听");
                //监听队列
                socketWatch.Listen(10);
                //等待客户连接并创建负责通讯的socket 但是会造成进程假死并且只有一个用户能连接
                // Socket socketSend = socketWatch.Accept();
                // ShowMsg("来自:" + socketSend.RemoteEndPoint.ToString() + "连接!");

                //开启新线程执行Listen函数
                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch (Exception)
            {
                
                throw;
            }

        }
        void Listen( object o )//被线程执行的函数如果有参数的话必须是object类型
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                try
                {
                    //等待客户连接并创建负责通讯的socket
                    Socket socketSend = socketWatch.Accept();
                    ShowMsg("来自:" + socketSend.RemoteEndPoint.ToString() + "连接!");
                    //开启一个新线程不停的接收客户端发来的数据
                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch (Exception)
                {
                    
                    throw;
                }

            }

        }
        /// <summary>
        /// 服务器端不停的接受客户端发过来的消息
        /// </summary>
        /// <param name="o"></param>
        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    //客户端连接成功后,服务器应该接受客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //实际接受到的有效字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch (Exception)
                {
                    
                    throw;
                }

                
            }
        }

       public  void ShowMsg(string log)
        {
            textLog.AppendText(log + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程检测
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
