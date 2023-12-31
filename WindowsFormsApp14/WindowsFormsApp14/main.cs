﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using HPSocket;
using HPSocket.Tcp;

namespace WindowsFormsApp14
{
    public partial class main : Form
    {
        int saveDay = 0;
        int saveTime = 0;
        public main()
        {
            InitializeComponent();
            路径管理ToolStripMenuItem.Enabled = false;
            通讯ToolStripMenuItem.Enabled = false;
            参数设置ToolStripMenuItem.Enabled = false;
            myLED1.Ledvalue = MyLED.LEDstate.NG;
            myLED2.Ledvalue = MyLED.LEDstate.NG;
        }
        HTuple row3, col3;
        public HTuple hv_ExpDefaultWinHandle;
        HTuple hv_AcqHandle = null;
        public HObject ho_Image;
        int trigger = 1;//1拍照 2示教
        HTuple Width = new HTuple();
        HTuple Height = new HTuple();
        HTuple ModelID;
        bool cameraclose = true;
        int pos = 0;
        double[] TeachX = { 0,0,0,0,0,0,0,0,0,0,0,0 };
        double RorbotX =0;
        double NowPointX=0;
        double[] TeachY ={ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double RorbotY = 0;
        double NowPointY = 0;
        double[] TeachA = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double RorbotA = 0;
        double NowPointA = 0;
        double offsetX = 0;
        double offsetY = 0;
        double offsetA = 0;
        private Login login = new Login();
        private communicate comm = new communicate();
        private file_path path = new file_path();
        TcpServer tcpServer = new TcpServer();
        string msg = "";
        string IP;
        string Potr;
        string SendMsg;
        string Receivemsg;
        string ConnId;
        string Port;
        HTuple hv_WindowHandle = new HTuple();
        private HWindow Window;
        HObject empt;
        HTuple row1, col1, row2, col2, buttons;
        HTuple Angle, Score, HomMat2D;
        HObject rectangle, contours, imagereduce, Eraser, diffrence, ContoursAffinTrans;
        HObject ExpTmpOutVar = new HObject();
        string recievedStr;
        public Login Login
        {
            get { return this.login; }
            set { this.login = value; }
        }
        public communicate Communicate
        {
            get { return this.comm; }
            set { this.comm = value; }
        }
        public file_path file_Path
        {
            get { return this.path; }
            set { this.path = value; }
        }
        private void btnTakeImg_Click(object sender, EventArgs e)
        {
            if (cameraclose == true)
            {
                MessageBox.Show("相机未连接");
            }
            else
            {
                //trigger = 1;
                //Image Acquisition 01: Code generated by Image Acquisition 01 
                HOperatorSet.GrabImageStart(hv_AcqHandle, -1);
                HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
                //Image Acquisition 01: Do something
                HOperatorSet.GetImageSize(ho_Image, out Width, out Height);
                HOperatorSet.SetPart(Window, 0, 0, Height - 1, Width - 1);
                //显示图像
                HOperatorSet.DispObj(ho_Image, Window);
                if (path.useSave == 1)
                {
                    HalconDotNet.HOperatorSet.WriteImage(ho_Image, "bmp", 0, path.textImagePath.Text + DateTime.Now.ToString("hh-mm-ss"));
                    System.Threading.Thread.Sleep(10);
                }
                else
                {

                }
            }
        }
        //加载
        public void Form1_Load(object sender, EventArgs e)
        {
            Window = hWindowControl1.HalconWindow;
            //连接相机
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Image);
            //Image Acquisition 01: Code generated by Image Acquisition 01
            HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "rgb",
                -1, "false", "default", "[0] Integrated Camera", 0, -1, out hv_AcqHandle);
            HOperatorSet.SetFramegrabberParam(hv_AcqHandle, "brightness", 131);
            HOperatorSet.GrabImageStart(hv_AcqHandle, -1);
            logtext.Text = "相机连接成功"+"\r\n";
            myLED2.Ledvalue = MyLED.LEDstate.OK;
            //采集
            HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
            //适应窗口
            HOperatorSet.GetImageSize(ho_Image, out Width, out Height);
            HOperatorSet.SetPart(hWindowControl1.HalconWindow, 0, 0, Height, Width);
            //显示图像
            HOperatorSet.DispObj(ho_Image, Window);
            cameraclose = false;
            tcpServer.OnAccept += TcpServer_OnAccept;
            tcpServer.OnPrepareListen += TcpServer_OnPrepareListen;
            tcpServer.OnSend += TcpServer_OnSend;
            tcpServer.OnReceive += TcpServer_OnReceive;
            tcpServer.OnClose += TcpServer_OnClose;
        }

        private HandleResult TcpServer_OnAccept(IServer sender, IntPtr connId, IntPtr client)
        {
            ConnId = connId.ToString();
            this.Invoke(new Action(() =>
            {
                logtext.AppendText("连接成功！" + connId + "\r\n");
            }));
            
            return HandleResult.Ok;
        }

        private HandleResult TcpServer_OnClose(IServer sender, IntPtr connId, SocketOperation socketOperation, int errorCode)
        {
            tcpServer.Stop();
            return HandleResult.Ok;
        }

        private HandleResult TcpServer_OnReceive(IServer sender, IntPtr connId, byte[] data)
        {
            recievedStr = Encoding.Default.GetString(data);
            this.Invoke(new Action(() =>
            {
                logtext.AppendText("TcpServer_OnReceive." + "内容:" + recievedStr + "字节:" + data.Length + "\r\n");
            }));
            if (recievedStr == "1")
            {
                //trigger = 1;
                //Image Acquisition 01: Code generated by Image Acquisition 01 
                HOperatorSet.GrabImageStart(hv_AcqHandle, -1);
                HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
                //Image Acquisition 01: Do something
                HOperatorSet.GetImageSize(ho_Image, out Width, out Height);
                HOperatorSet.SetPart(Window, 0, 0, Height - 1, Width - 1);
                //显示图像
                HOperatorSet.DispObj(ho_Image, Window);
                if (path.useSave == 1)
                {
                    HalconDotNet.HOperatorSet.WriteImage(ho_Image, "bmp", 0, path.textImagePath.Text + DateTime.Now.ToString("hh-mm-ss"));
                    System.Threading.Thread.Sleep(10);
                }
                else
                {

                }
            }
            return HandleResult.Ok;
        }

        private HandleResult TcpServer_OnSend(IServer sender, IntPtr connId, byte[] data)
        {
            string sendStr = Encoding.Default.GetString(data);
            this.Invoke(new Action(() =>
            {
                logtext.AppendText("TcpServer_OnSend." + "内容:" + sendStr + "字节:" + data.Length+"\r\n");
            }));
            return HandleResult.Ok;
        }

        private HandleResult TcpServer_OnPrepareListen(IServer sender, IntPtr listen)
        {
            logtext.AppendText("监听成功！"+"\r\n");
            return HandleResult.Ok;
        }

        //


        public void tcpStar()
        {
            IP = comm.IP.Trim();
            Port = comm.Port;
            SendMsg = comm.SendMsg;
            Receivemsg = comm.Receivemsg;
            ConnId = comm.ConnId;
            if (IP == null || Port == null)
            {
                logtext.AppendText("连接失败，请检查通讯参数！" + "\r\n");
                this.myLED1.Ledvalue = MyLED.LEDstate.NG;
            }
            else
            {
                ushort Port = ushort.Parse(comm.Port);
                tcpServer.Address = IP.Trim();
                tcpServer.Port =Port;
                tcpServer.SendPolicy = HPSocket.SendPolicy.Direct;
                tcpServer.Start();
                tcpServer.GetListenAddress(out IP, out Port);
                this.myLED1.Ledvalue = MyLED.LEDstate.OK;
                //logtext.AppendText("连接成功!" + IP + ConnId + "\r\n");
            }


        }
        public void sendmsg()
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断相机是否关闭
            if (cameraclose == false && login.Authority == 99)
            {
                HOperatorSet.CloseFramegrabber(hv_AcqHandle);
                hWindowControl1.HalconWindow.DispObj(ho_Image);
            }
            else
            {
                
            }
            tcpServer.Stop();
            hv_WindowHandle.Dispose();
        }
        //关闭上位机
        protected override void OnClosing(CancelEventArgs e)
        {
            if (login.Authority == 99)
            {

            }
            else
            {
                MessageBox.Show("您没有权限关闭该软件，请登录或者联系管理员。");
                e.Cancel = true;
            }
        }
        //示教
        private void btnTeach_Click(object sender, EventArgs e)
        {
            if (pos > TeachX.Length)
            {
                TeachX.Append(RorbotX + NowPointX);
                TeachY.Append(RorbotY + NowPointY);
                TeachA.Append(TeachY[pos] / TeachX[pos]);
            }
            else
            {
                if (trigger == 2)
                {
                    TeachX[pos] = RorbotX + NowPointX;
                    TeachY[pos] = RorbotY + NowPointY;
                    TeachA[pos] = (TeachY[pos] / TeachX[pos])*180/Math.PI;//m2y-m1y/m2x-m1x

                }
            }
        }
        private void Offset()
        {
            if (trigger == 1)
            {
                NowPointX = NowPointX + RorbotX;
                NowPointY = NowPointY + RorbotY;
                NowPointA = Math.Round(Math.Atan(NowPointY / NowPointX) * 180 / Math.PI, 3);
                offsetX = NowPointX - TeachX[pos];
                offsetY = NowPointY - TeachY[pos];
                offsetA = NowPointA - TeachA[pos];
            }
            else if (trigger == 2)
            {
                TeachX[pos] = NowPointX + RorbotX;
                TeachY[pos] = NowPointY + RorbotY;
                TeachA[pos] = Math.Round(Math.Atan(NowPointY / NowPointX) * 180 / Math.PI, 3);
            }
            else
            {
                logtext.AppendText("trigger信号错误" + "\r\n");
            }
        }
        
        private void 连接相机ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cameraclose == true)
            {
                // Initialize local and output iconic variables 
                HOperatorSet.GenEmptyObj(out ho_Image);
                //Image Acquisition 01: Code generated by Image Acquisition 01
                HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "rgb",
                    -1, "false", "default", "[0] Integrated Camera", 0, -1, out hv_AcqHandle);
                HOperatorSet.SetFramegrabberParam(hv_AcqHandle, "brightness", 131);
                HOperatorSet.GrabImageStart(hv_AcqHandle, -1);
                HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
                HOperatorSet.DispObj(ho_Image, Window);
                cameraclose = false;
                MessageBox.Show("相机连接成功");
                logtext.Text = "相机连接成功";
                while (trigger == 2)
                {
                    ho_Image.Dispose();
                    HOperatorSet.GrabImage(out ho_Image, hv_AcqHandle);
                    HOperatorSet.DispObj(ho_Image,Window);
                }
                
            }
            else
            {
                MessageBox.Show("相机已连接");
            }
        }

        public void 通讯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comm.Tcplink += Comm_Tcplink;
            comm.Tcplink1 += Comm_Tcplink1;
            DialogResult dialogResult = comm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

            }           
        }

        private void Comm_Tcplink(bool topmost)
        {
            this.tcpStar();

        }
        private void Comm_Tcplink1(bool topmost)
        {
            string sendContent = comm.textSendmsg.Text;
            byte[] sendBytes = Encoding.Default.GetBytes(sendContent);
            IntPtr Id = (IntPtr)Convert.ToInt32(ConnId);
            tcpServer.Send(Id, sendBytes, sendBytes.Length);
            comm.textSendmsg.Text = string.Empty;
        }

        public void 参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Paramete_setting = new Paramete_setting();
            Paramete_setting.Show();
        }

        public void 用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = login.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

            }
            if (login.Authority == 99)
            {
                路径管理ToolStripMenuItem.Enabled = true;
                通讯ToolStripMenuItem.Enabled = true;
                参数设置ToolStripMenuItem.Enabled = true;
                
            }
            else
            {
                路径管理ToolStripMenuItem.Enabled = false;
                通讯ToolStripMenuItem.Enabled = false;
                参数设置ToolStripMenuItem.Enabled = false;
            }
        }

        public void 路径管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = path.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

            }
        }

        //定期删除文档
        private void DeleteFile(string fileDirect,int saveDay)
        {
            DateTime nowTime = DateTime.Now;
            string[] files = Directory.GetFiles(fileDirect, "*.txt", SearchOption.AllDirectories);  //获取该目录下所有 .txt文件
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                TimeSpan t = nowTime - fileInfo.CreationTime;  //当前时间  减去 文件创建时间
                int day = t.Days;
                if (day >= saveDay)   //保存的时间 ；  单位：天
                {
                    File.Delete(file);  //删除超过时间的文件
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            HObject ModelContours;
            
            HOperatorSet.ReadShapeModel(file_Path.textBox4.Text,out ModelID);
            HOperatorSet.FindShapeModel(ho_Image, ModelID, (new HTuple(-180)).TupleRad(), (new HTuple(180)).TupleRad(), 0.5, 1, 0.5, "least_squares", 0, 0.9, out row3, out col3, out Angle, out Score);
            HOperatorSet.GetShapeModelContours(out ModelContours, ModelID, 1);
            if (Score.TupleLength() == 0)
            {
                HOperatorSet.DispObj(ho_Image,Window);
            }
            else
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, row3, col3, Angle, out HomMat2D);
                HOperatorSet.AffineTransContourXld(ModelContours, out ContoursAffinTrans, HomMat2D);
                HOperatorSet.DispObj(ho_Image, Window);
                HOperatorSet.SetColor(Window, "green");
                HOperatorSet.DispObj(ContoursAffinTrans, Window);
            }
            
        }

        //定时器
        private void TimerDelete_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("hh-mm-ss") == "23-59-59")
            {
                TimerDelete.Start();
            }
            if (path.SaveDays.Text == "" || path.SaveDays.Text == 0.ToString())
            {
                path.SaveDays.Text = 100.ToString();
            }
            
            DeleteFile(System.Environment.CurrentDirectory ,Convert.ToInt32(path.SaveDays.Text));  //删除该目录下 超过 x天的文件
            TimerDelete.Stop();
        }
        //图片缩放
        private void hWindowControl1_HMouseWheel(object sender, HMouseEventArgs e)
        {
            HTuple Zoom, Row, Col, Button;
            HTuple Row0, Column0, Row00, Column00, Ht, Wt, r1, c1, r2, c2;
            if (e.Delta > 0)
            {
                Zoom = 1.5;
            }
            else
            {
                Zoom = 0.5;
            }
            HOperatorSet.GetMposition(Window, out Row, out Col, out Button);
            HOperatorSet.GetPart(Window, out Row0, out Column0, out Row00, out Column00);
            Ht = Row00 - Row0;
            Wt = Column00 - Column0;
            if (Ht * Wt < 32000 * 32000 || Zoom == 1.5)//普通版halcon能处理的图像最大尺寸是32K*32K。如果无限缩小原图像，导致显示的图像超出限制，则会造成程序崩溃
            {
                r1 = (Row0 + ((1 - (1.0 / Zoom)) * (Row - Row0)));
                c1 = (Column0 + ((1 - (1.0 / Zoom)) * (Col - Column0)));
                r2 = r1 + (Ht / Zoom);
                c2 = c1 + (Wt / Zoom);
                HOperatorSet.SetPart(Window, r1, c1, r2, c2);
                HOperatorSet.ClearWindow(Window);
                HOperatorSet.DispObj(ho_Image,Window);
            }
        }

        private void btnReadimg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.png";//图片路径
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
               HOperatorSet.ReadImage(out ho_Image,openFileDialog1.FileName);
               HOperatorSet.GetImageSize(ho_Image, out Width, out Height);
               HOperatorSet.SetPart(Window, 0, 0, Height - 1, Width - 1);
               HOperatorSet.DispObj(ho_Image, Window);
            }
        }

        private void hWindowControl1_HMouseMove(object sender, HMouseEventArgs e)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;
            //橡皮擦大小
            HTuple EraserSize = 20;
            //橡皮擦形状
            HTuple EraserType = "circle";
            
            HOperatorSet.GenEmptyObj(out empt);
            HTuple Rows = new HTuple();
            HTuple Cols = new HTuple();
            buttons = 0;
            Console.WriteLine("按下鼠标进行擦除功能，松开鼠标将结束");
            if (radioButton1.Checked == true)
            {

                while (buttons == 0)
                {
                    HOperatorSet.GetMbutton(Window, out row3, out col3, out buttons);
                    while (buttons == 1)
                    {
                        HOperatorSet.GetMposition(Window, out row3, out col3, out buttons);
                        label6.Text = buttons.ToString();
                        HOperatorSet.TupleConcat(Rows, row3, out Rows);
                        HOperatorSet.TupleConcat(Cols, col3, out Cols);
                        //生成橡皮擦擦过的区域
                        if (EraserType == "rectangle")
                        {
                            HOperatorSet.GenRectangle2(out Eraser, row3, col3, 0, EraserSize, EraserSize);

                        }
                        else
                        {

                            HOperatorSet.GenCircle(out Eraser, row3, col3, EraserSize);

                        }

                        HOperatorSet.Union2(empt, Eraser, out ExpTmpOutVar);
                        empt = ExpTmpOutVar;
                        HOperatorSet.SetRgba(Window, 255, 0, 0, 100);
                        HOperatorSet.DispObj(empt, Window);
                        //HOperatorSet.PaintRegion(empt,ho_Image,out empt,255,"Complex");                       

                    }
                    //HOperatorSet.Difference(imagereduce, empt, out diffrence);
                }
            }

        }

        private void btnmodle_Click(object sender, EventArgs e)
        {

            //新建窗口
            //HOperatorSet.OpenWindow(0,0, hWindowControl1.Width, hWindowControl1.Height, Window,"","",out hv_WindowHandle);
            //显示图片

            HOperatorSet.SetPart(Window, 0, 0, Height - 1, Width - 1);
            HOperatorSet.DispObj(ho_Image, Window);

            //绘制矩形
            HOperatorSet.DrawRectangle1(Window, out row1,out col1,out row2,out col2);
            HOperatorSet.SetColor(Window, "red");
            HOperatorSet.GenRectangle1(out rectangle, row1, col1, row2, col2);
            //提取轮廓
            HOperatorSet.GenContourRegionXld(rectangle,out contours, "border");
            //显示轮廓
            HOperatorSet.DispObj(contours, Window);
            //截图
            HOperatorSet.ReduceDomain(ho_Image,rectangle,out imagereduce);
            //显示截图
            HOperatorSet.ClearWindow(Window);
            HOperatorSet.DispObj(imagereduce, Window);
            //橡皮擦大小
            HTuple EraserSize = 20;
            //橡皮擦形状
            HTuple EraserType = "circle";
            HOperatorSet.SetRgba(Window, 255,0,0,100);
            HOperatorSet.GenEmptyObj(out empt);
            HTuple Rows = new HTuple();
            HTuple Cols = new HTuple();
            Console.WriteLine("按下鼠标进行擦除功能，松开鼠标将结束");
            
 
        }
        
        private void btnclose_Click(object sender, EventArgs e)
        {
            HObject ModelContours;
            HOperatorSet.CreateShapeModel(imagereduce,"auto", -0.39, 0.79, "auto", "auto", "use_polarity", "auto", "auto", out ModelID);
            HOperatorSet.FindShapeModel(ho_Image, ModelID, -180, 180, 0.5, 1, 0.5, "least_squares", 0, 0.9, out row3,out col3,out Angle, out Score);
            HOperatorSet.GetShapeModelContours(out ModelContours, ModelID,1);
            HOperatorSet.WriteShapeModel(ModelID, @"D\\"+ ModelID);
            HOperatorSet.CloseWindow(hv_WindowHandle);
        }

        private void hWindowControl1_HMouseDown(object sender, HMouseEventArgs e)
        {
            //buttons = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void hWindowControl1_HMouseUp(object sender, HMouseEventArgs e)
        {
            //buttons = 0;
        }

        private void hWindowControl1_HMouseWheel_1(object sender, HMouseEventArgs e)
        {

        }
    }
}
