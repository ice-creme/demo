using System;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Login : Form
    {
        string Username = "admin";
        public string status ;
        public int Authority = 1;
        
        public Login()
        {
            InitializeComponent();
            username.Text = Username;
            code.Text = "123456";
            btnLogout.Enabled = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            Authority = 0;
            if (username.Text == Username)
            {
                if (code.Text == "123456")
                {
                    status = "登录成功";
                    label1.Text = status;
                    MessageBox.Show("登录成功");
                    username.Enabled = false;
                    code.Enabled = false;
                    btnLogin.Enabled = false;
                    Authority = 99;
                    btnLogout.Enabled = true;
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("密码错误");                   
                }
            }
            else
            {
                MessageBox.Show("该用户不存在");               
            }

        }       
        private void btnLogout_Click(object sender, EventArgs e)
        {

            status = "请登录用户";
            label1.Text = status;
            code.Text = "";
            username.Text = "";
            username.Enabled = true;
            code.Enabled = true;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void code_TextChanged(object sender, EventArgs e)
        {
            code.PasswordChar = '*';   //显示*
            
        }
    }
}
