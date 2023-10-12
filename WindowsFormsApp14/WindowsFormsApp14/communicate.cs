using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HPSocket;
using HPSocket.Tcp;

namespace WindowsFormsApp14
{
    public partial class communicate : Form
    {

        public string IP = "127.0.0.1";
        public string msg = "";
        public string Port = "3001";
        public string SendMsg;
        public string Receivemsg;
        public string ConnId;
        //声明委托
        public delegate void tcplink(bool topmost);
        public delegate void tcplink1(bool topmost);

        public communicate()
        {
            IP = "127.0.0.1";           
            Port = "2000";
            SendMsg = "";
            Receivemsg = "";
            InitializeComponent();
        }
        //声明实例
        public event tcplink Tcplink;
        public event tcplink Tcplink1;
        public void btnclient_Click(object sender, EventArgs e)
        {
            Tcplink(true);//执行委托实例
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Tcplink1(true);
        }
    }
}
