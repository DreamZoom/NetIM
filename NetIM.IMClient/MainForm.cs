using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetIM.Client;
using System.Net;
using System.Net.Sockets;

namespace NetIM.IMClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        NetIM.Client.IMClient client = null;
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            EndPoint point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2254);
            client = new Client.IMClient(point);
            client.Connected += client_Connected;
            client.DataReceived += client_DataReceived;
            client.Connect();
           
        }

        void client_DataReceived(object sender, SuperSocket.ClientEngine.DataEventArgs e)
        {
            richTextBox1.AppendText(Encoding.UTF8.GetString(e.Data));
        }

        void client_Connected(object sender, EventArgs e)
        {
            richTextBox1.AppendText("连接成功\t\n");
            byte[] bytes = Encoding.UTF8.GetBytes("何来lo哈哈哈哈哈哈哈哈哈哈h");
            client.Send(bytes, 0, bytes.Length);
        }
    }
}
