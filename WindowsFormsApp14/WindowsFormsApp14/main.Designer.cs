
namespace WindowsFormsApp14
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTakeImg = new System.Windows.Forms.Button();
            this.btnTeach = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.路径管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接相机ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.btnReadimg = new System.Windows.Forms.Button();
            this.logtext = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.连接相机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerDelete = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myLED1 = new MyLED.MyLED();
            this.myLED2 = new MyLED.MyLED();
            this.hWindowControl3 = new HalconDotNet.HWindowControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnmodle = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTakeImg
            // 
            this.btnTakeImg.Location = new System.Drawing.Point(1335, 45);
            this.btnTakeImg.Name = "btnTakeImg";
            this.btnTakeImg.Size = new System.Drawing.Size(141, 62);
            this.btnTakeImg.TabIndex = 1;
            this.btnTakeImg.Text = "单次采集";
            this.btnTakeImg.UseVisualStyleBackColor = true;
            this.btnTakeImg.Click += new System.EventHandler(this.btnTakeImg_Click);
            // 
            // btnTeach
            // 
            this.btnTeach.Location = new System.Drawing.Point(1335, 113);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(141, 62);
            this.btnTeach.TabIndex = 17;
            this.btnTeach.Text = "示教当前点位";
            this.btnTeach.UseVisualStyleBackColor = true;
            this.btnTeach.Click += new System.EventHandler(this.btnTeach_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户登录ToolStripMenuItem,
            this.路径管理ToolStripMenuItem,
            this.通讯ToolStripMenuItem,
            this.参数设置ToolStripMenuItem,
            this.连接相机ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户登录ToolStripMenuItem
            // 
            this.用户登录ToolStripMenuItem.Name = "用户登录ToolStripMenuItem";
            this.用户登录ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.用户登录ToolStripMenuItem.Text = "用户登录";
            this.用户登录ToolStripMenuItem.Click += new System.EventHandler(this.用户登录ToolStripMenuItem_Click);
            // 
            // 路径管理ToolStripMenuItem
            // 
            this.路径管理ToolStripMenuItem.Name = "路径管理ToolStripMenuItem";
            this.路径管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.路径管理ToolStripMenuItem.Text = "路径管理";
            this.路径管理ToolStripMenuItem.Click += new System.EventHandler(this.路径管理ToolStripMenuItem_Click);
            // 
            // 通讯ToolStripMenuItem
            // 
            this.通讯ToolStripMenuItem.Name = "通讯ToolStripMenuItem";
            this.通讯ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.通讯ToolStripMenuItem.Text = "通讯";
            this.通讯ToolStripMenuItem.Click += new System.EventHandler(this.通讯ToolStripMenuItem_Click);
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.参数设置ToolStripMenuItem.Text = "参数设置";
            this.参数设置ToolStripMenuItem.Click += new System.EventHandler(this.参数设置ToolStripMenuItem_Click);
            // 
            // 连接相机ToolStripMenuItem1
            // 
            this.连接相机ToolStripMenuItem1.Name = "连接相机ToolStripMenuItem1";
            this.连接相机ToolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.连接相机ToolStripMenuItem1.Text = "连接相机";
            this.连接相机ToolStripMenuItem1.Click += new System.EventHandler(this.连接相机ToolStripMenuItem1_Click);
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(0, 0);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(1288, 867);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(1288, 867);
            this.hWindowControl1.HMouseMove += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseMove);
            this.hWindowControl1.HMouseDown += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseDown);
            this.hWindowControl1.HMouseUp += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseUp);
            this.hWindowControl1.HMouseWheel += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseWheel_1);
            // 
            // btnReadimg
            // 
            this.btnReadimg.Location = new System.Drawing.Point(1335, 181);
            this.btnReadimg.Name = "btnReadimg";
            this.btnReadimg.Size = new System.Drawing.Size(141, 62);
            this.btnReadimg.TabIndex = 19;
            this.btnReadimg.Text = "读取图像";
            this.btnReadimg.UseVisualStyleBackColor = true;
            this.btnReadimg.Click += new System.EventHandler(this.btnReadimg_Click);
            // 
            // logtext
            // 
            this.logtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logtext.Location = new System.Drawing.Point(1500, 485);
            this.logtext.Name = "logtext";
            this.logtext.Size = new System.Drawing.Size(412, 492);
            this.logtext.TabIndex = 20;
            this.logtext.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1500, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(412, 442);
            this.dataGridView1.TabIndex = 21;
            // 
            // 连接相机ToolStripMenuItem
            // 
            this.连接相机ToolStripMenuItem.Name = "连接相机ToolStripMenuItem";
            this.连接相机ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // TimerDelete
            // 
            this.TimerDelete.Enabled = true;
            this.TimerDelete.Tick += new System.EventHandler(this.TimerDelete_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 970);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "通讯";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 969);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "camera";
            // 
            // myLED1
            // 
            this.myLED1.Ledvalue = MyLED.LEDstate.OK;
            this.myLED1.Location = new System.Drawing.Point(55, 955);
            this.myLED1.MinimumSize = new System.Drawing.Size(20, 20);
            this.myLED1.Name = "myLED1";
            this.myLED1.NGColor = System.Drawing.Color.Red;
            this.myLED1.OKcolor = System.Drawing.Color.Lime;
            this.myLED1.Size = new System.Drawing.Size(41, 40);
            this.myLED1.TabIndex = 24;
            // 
            // myLED2
            // 
            this.myLED2.Ledvalue = MyLED.LEDstate.OK;
            this.myLED2.Location = new System.Drawing.Point(203, 955);
            this.myLED2.MinimumSize = new System.Drawing.Size(20, 20);
            this.myLED2.Name = "myLED2";
            this.myLED2.NGColor = System.Drawing.Color.Red;
            this.myLED2.OKcolor = System.Drawing.Color.Lime;
            this.myLED2.Size = new System.Drawing.Size(41, 40);
            this.myLED2.TabIndex = 24;
            // 
            // hWindowControl3
            // 
            this.hWindowControl3.BackColor = System.Drawing.Color.Black;
            this.hWindowControl3.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl3.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl3.Location = new System.Drawing.Point(550, 634);
            this.hWindowControl3.Name = "hWindowControl3";
            this.hWindowControl3.Size = new System.Drawing.Size(320, 240);
            this.hWindowControl3.TabIndex = 0;
            this.hWindowControl3.WindowSize = new System.Drawing.Size(320, 240);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 833);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 804);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hWindowControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 804);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1335, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "选择相机：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1338, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 23);
            this.comboBox1.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(1310, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 198);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "增益：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "曝光：";
            // 
            // btnmodle
            // 
            this.btnmodle.Location = new System.Drawing.Point(1335, 529);
            this.btnmodle.Name = "btnmodle";
            this.btnmodle.Size = new System.Drawing.Size(141, 62);
            this.btnmodle.TabIndex = 29;
            this.btnmodle.Text = "创建模板";
            this.btnmodle.UseVisualStyleBackColor = true;
            this.btnmodle.Click += new System.EventHandler(this.btnmodle_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1335, 609);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(141, 62);
            this.btnclose.TabIndex = 30;
            this.btnclose.Text = "保存模板";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1338, 692);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "涂抹";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1313, 718);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "label6";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1335, 812);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(141, 62);
            this.btnRun.TabIndex = 30;
            this.btnRun.Text = "执行程序";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1000);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnmodle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnReadimg);
            this.Controls.Add(this.btnTakeImg);
            this.Controls.Add(this.btnTeach);
            this.Controls.Add(this.myLED1);
            this.Controls.Add(this.myLED2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logtext);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "上位机";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTakeImg;
        private System.Windows.Forms.Button btnTeach;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户登录ToolStripMenuItem;
        private System.Windows.Forms.Button btnReadimg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 连接相机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接相机ToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem 路径管理ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 通讯ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        public HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Timer TimerDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyLED.MyLED myLED1;
        private MyLED.MyLED myLED2;
        private HalconDotNet.HWindowControl hWindowControl2;
        private HalconDotNet.HWindowControl hWindowControl3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnmodle;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RichTextBox logtext;
        private System.Windows.Forms.Button btnRun;
    }
}

