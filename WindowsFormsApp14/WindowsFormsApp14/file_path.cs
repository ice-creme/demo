using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class file_path : Form
    {
        public int useSave = 0;
        public file_path()
        {

            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                useSave = 1;
                string filename = textImagePath.Text;
                if (Directory.Exists(filename)|| filename=="")
                {
                    MessageBox.Show("目录已存在或为空！");
                }
                else
                {
                    Directory.CreateDirectory(filename);
                    
                }
            }
            else
            {
                useSave = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择文件所在文件夹目录";  //提示的文字
            if (folder.ShowDialog() == DialogResult.OK)
            {
                textImagePath.Text = folder.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.shm|*.*";//模板路径
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("模板读取失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.mat|*.*";//模板路径
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("标定文件读取失败");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
