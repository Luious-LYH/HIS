using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql;
namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.textBox2.UseSystemPasswordChar = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = this.textBox1.Text;
            string userPassword = this.textBox2.Text;
            if (userName.Equals("") || userPassword.Equals(""))
            {
                MessageBox.Show("用户名密码不能为空");
            }
            else
            {
                try
                {
                    string sq1_se1 = "select count(*) from net.login where user_id = \"" + userName + "\" and user_pasw= \"" + userPassword + "\"";
                    MySqlCommand com = Mysql.Con_mysql(sq1_se1);//调用mysql的类
                    if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                    {
                        Welcome welcome = new Welcome();
                        welcome.Show();
                        welcome.TxtPrint(userName);//传递参数给welcome
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message.ToString() + "打开数据库失败");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Register_users r_users = new Register_users();
            r_users.Show();
        }
    }
}
