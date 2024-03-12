using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Statistical_select : Form
    {
        public Statistical_select()
        {
            InitializeComponent();
            Label_slipe.fontSlide(this.label_introduction);
        }

        private void button1_Click(object sender, EventArgs e)//查询
        {
            try
            {
                DateTime start = this.date_start.Value;
                DateTime end = this.date_end.Value;
                string sql_select = "SELECT * FROM net.lists where UNIX_TIMESTAMP(list_date)>=UNIX_TIMESTAMP(" + "\""+start+"\""+")"+ "and UNIX_TIMESTAMP(list_date)<=UNIX_TIMESTAMP(" + "\"" + end + "\"" + ")";
                string list_id = this.input_list.Text;
                string list_patient=this.input_patient.Text;
                string list_doctor=this.input_doctor.Text;
                //可选条件加入sql语句查询
                if (!string.IsNullOrEmpty(list_id))
                {
                    sql_select += $"and list_id={Convert.ToInt32(list_id)}";
                }

                if (!string.IsNullOrEmpty(list_patient))
                {
                    sql_select += $"and patient_name=\"{list_patient}\"";
                }

                if (!string.IsNullOrEmpty(list_doctor))
                {
                    //string doc_select = "SELECT doc_id FROM net.doctors where doc_name = " + "\"" + list_doctor + "\"";
                    string doc_select = $"SELECT doc_id FROM net.doctors where doc_id ={list_doctor}" ;
                    MySqlCommand cmds = Mysql.Con_mysql(doc_select);
                    MySqlDataReader reader_id = cmds.ExecuteReader();
                    int doc_id = 0;
                    while (reader_id.Read())
                    {
                        doc_id = reader_id.GetInt32(0);
                    }
                    reader_id.Close();
                    sql_select += $"and doc_id={Convert.ToInt32(doc_id)}";
                }



                Console.WriteLine(sql_select);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"查询出错了");
            }
            }
        private void button2_Click(object sender, EventArgs e)//退号删除
        {
            DialogResult result = MessageBox.Show("是否确认删除单号？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                //定义计数值
                int count = 0;
                try
                {
                    //for循环，dataGridView1.SelectedRows.Count为鼠标选中行的数目，一次for循环删除一行数据
                    if (!(dataGridView1.SelectedRows.Count > 0))
                    {
                        MessageBox.Show("所选为空,请通过表格最前方选中整行!");
                        return;
                    }
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        //获得i行的编号
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value);
                        Console.WriteLine(id);
                        //编写数据库删除代码，这里还用到了动态变量，用于改变每次id值
                        string sql_del = $"delete from lists where list_id = {id}";
                        //创建MySqlCommand类用于SQL语句的执行
                        MySqlCommand cmd = Mysql.Con_mysql(sql_del);
                        //定义x接收返回值SQL语句返回值，为0则为执行失败
                        int x = cmd.ExecuteNonQuery();
                        //执行判断
                        if (x == 0)
                        {
                            MessageBox.Show("删除失败");
                            return ;
                        }
                        //若成功则计数值+1
                        count = count + 1;
                        Console.WriteLine(x);
                    }
                    //若计数值等于选中行的数目，代表成功完成所有行的删除
                    if (count == dataGridView1.SelectedRows.Count)
                    {
                        MessageBox.Show("删除成功");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    //这里的button1是刷新界面，因人而异，可忽略
                    button1.PerformClick();
                    //关闭数据库连接
                }
            }
        }
    }
}
