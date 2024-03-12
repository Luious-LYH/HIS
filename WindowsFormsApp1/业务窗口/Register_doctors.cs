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
    public partial class Register_doctors : Form
    {
        public Register_doctors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql_select = "SELECT max(doc_id) FROM net.doctors";
            MySqlCommand cmd = Mysql.Con_mysql(sql_select);
            MySqlDataReader reader_id = cmd.ExecuteReader();
            int doc_id = 0;
            while (reader_id.Read())
            {
                doc_id = reader_id.GetInt32(0)+1;
            }
            reader_id.Close();
            string doc_Name = this.input_name.Text;
            string doc_pos=this.input_pos.Text;
            int doc_cost = 0;
            if (doc_pos.Equals("医师"))
            {
                doc_cost = 20;
            }
            if (doc_pos.Equals("主任医师"))
            {
                doc_cost = 40;
            }
            DateTime doc_date=this.input_date.Value;
            string doc_office = this.input_office.Text;
            if (doc_Name.Equals("") || doc_office.Equals("") || doc_pos.Equals(""))
                MessageBox.Show("信息不能为空");
            else
            {
                try
                {
                    string sql_insert = "insert into net.doctors values("+doc_id + "," +"\"" + doc_Name + "\"" + "," + doc_cost + "," + "\"" + doc_office + "\"" + "," + "\"" + doc_date + "\"" + "," + "\"" + doc_pos + "\"" + ")";
                    Console.WriteLine(sql_insert);
                    cmd = Mysql.Con_mysql(sql_insert);
                    cmd.ExecuteNonQuery();

                    sql_insert = $"insert into net.morning(doc_id) values({doc_id})";
                    Console.WriteLine(sql_insert);
                    cmd = Mysql.Con_mysql(sql_insert);
                    cmd.ExecuteNonQuery();

                    sql_insert = $"insert into net.evening(doc_id) values({doc_id})";
                    Console.WriteLine(sql_insert);
                    cmd = Mysql.Con_mysql(sql_insert);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"医师注册成功，医生号为{doc_id}");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message.ToString()+"数据库注册失败");
                }
            }

        }
    }
}
