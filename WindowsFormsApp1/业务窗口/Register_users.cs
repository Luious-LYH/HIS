using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql;
namespace WindowsFormsApp1
{
    public partial class Register_users : Form
    {
        public Register_users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = this.textBox1.Text;
            string userPassword = this.textBox2.Text;
            string userPassword2 = this.textBox3.Text;
            if (userName.Equals("") || userPassword.Equals(""))
            {
                MessageBox.Show("用户名密码不能为空");
            }
            else if (userPassword !=userPassword2)
            {
                MessageBox.Show("前后两次密码不一致");
            }
            else
            {
                try
                {
                    string sql_code = "insert into net.login values( \"" + userName +"\""+ ","+ "\"" + userPassword +"\"" + ")";
                    MySqlCommand cmd = Mysql.Con_mysql(sql_code) ;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("注册成功");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message.ToString() + "数据库注册失败");
                }
            }
        }
    }
}
