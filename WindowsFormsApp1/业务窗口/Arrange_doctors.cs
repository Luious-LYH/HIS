using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Arrange_doctors : Form
    {
        public static int count = 0;


        public Arrange_doctors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//查询排班
        {
            string sql_select = "select * from net.morning";
            string se_week = this.select_week.Text;
            string se_date = this.select_date.Text;
            if (!string.IsNullOrEmpty(se_week))
            {
                sql_select = $"select doc_id,{se_week} from net.morning";
            }

            if (!string.IsNullOrEmpty(se_date))
            {
                if (string.IsNullOrEmpty(se_week))
                {
                    MessageBox.Show("请先选择星期后查询.");
                    return;
                }
                else
                {
                    if (se_date.Equals("8:00~12:00"))
                    {
                        sql_select = $"select doc_id,{se_week} from net.morning where {se_week}=1";
                    }
                    else
                    {
                        sql_select = $"select doc_id,{se_week} from net.evening where {se_week}=1";
                    }
                }

            }
            MySqlCommand cmd = Mysql.Con_mysql(sql_select);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "lists");

            if (ds == null)
            {
                MessageBox.Show("没有数据");
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)//添加排班
        {
            string changes_docid = this.change_doctor.Text;
            string changes_week = this.change_week.Text;
            string changes_date = this.change_date.Text;
            if (change_date.Equals("8:00~12:00"))
            {
                Console.WriteLine("hh");
            }
            else
            {
                Console.WriteLine("gggg");
                Console.WriteLine(changes_date);
            }
            string sql_update;
            if (string.IsNullOrEmpty(changes_docid) || string.IsNullOrEmpty(changes_week) || string.IsNullOrEmpty(changes_date))
            {
                MessageBox.Show("添加排班信息不能为空");
                return;
            }
            int doc_id = int.Parse(changes_docid);
            string sq1_se1 = $"select count(*) from net.doctors where doc_id = {doc_id}";
            MySqlCommand com = Mysql.Con_mysql(sq1_se1);//调用mysql的类
            if (Convert.ToInt32(com.ExecuteScalar()) > 0)
            {
                try
                {
                    if (!string.IsNullOrEmpty(changes_date))
                    {
                        if (string.IsNullOrEmpty(changes_week))
                        {
                            MessageBox.Show("请先选择星期后再修改.");
                            return;
                        }
                        else
                        {
                            if (changes_date.Equals("8:00~12:00"))
                            {
                                sql_update = $"UPDATE net.morning SET {changes_week} =1 WHERE(doc_id ={doc_id})";
                                MySqlCommand cmd = Mysql.Con_mysql(sql_update);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("修改早班成功");
                                button4.PerformClick();
                            }
                            else
                            {
                                sql_update = $"UPDATE net.evening SET {changes_week} =1 WHERE(doc_id ={doc_id})";
                                MySqlCommand cmd = Mysql.Con_mysql(sql_update);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("修改排班成功");
                                button5.PerformClick();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+"修改排班失败");
                }

            }
            else
            {
                MessageBox.Show("所添加医生号不存在");
            }

        }

        private void button3_Click(object sender, EventArgs e)//删除排班
        {
            string changes_docid = this.change_doctor.Text;
            string changes_week = this.change_week.Text;
            string changes_date = this.change_date.Text;
            string sql_update;
            if (string.IsNullOrEmpty(changes_docid) || string.IsNullOrEmpty(changes_week) || string.IsNullOrEmpty(changes_date))
            {
                MessageBox.Show("删除排班信息不能为空");
                return;
            }
            int doc_id = int.Parse(changes_docid);
            string sq1_se1 = $"select count(*) from net.doctors where doc_id = {doc_id}";
            MySqlCommand com = Mysql.Con_mysql(sq1_se1);//调用mysql的类
            if (Convert.ToInt32(com.ExecuteScalar()) > 0)
            {
                try
                {
                    if (!string.IsNullOrEmpty(changes_date))
                    {
                        if (string.IsNullOrEmpty(changes_week))
                        {
                            MessageBox.Show("请先选择星期后再修改.");
                            return;
                        }
                        else
                        {
                            if (changes_date.Equals("8:00~12:00"))
                            {
                                sql_update = $"UPDATE net.morning SET {changes_week} =0 WHERE(doc_id ={doc_id})";
                                MySqlCommand cmd = Mysql.Con_mysql(sql_update);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("删除排班成功");
                                button4.PerformClick();
                            }
                            else
                            {
                                sql_update = $"UPDATE net.evening SET {changes_week} =0 WHERE(doc_id ={doc_id})";
                                MySqlCommand cmd = Mysql.Con_mysql(sql_update);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("删除排班成功");
                                button5.PerformClick();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "修改排班失败");
                }

            }
            else
            {
                MessageBox.Show("所删除医生号不存在");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql_select = "select * from net.morning";
            MySqlCommand cmd = Mysql.Con_mysql(sql_select);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "lists");

            if (ds == null)
            {
                MessageBox.Show("没有数据");
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql_select = "select * from net.evening";
            MySqlCommand cmd = Mysql.Con_mysql(sql_select);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "lists");

            if (ds == null)
            {
                MessageBox.Show("没有数据");
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
