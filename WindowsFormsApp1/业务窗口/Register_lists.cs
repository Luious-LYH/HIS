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
namespace WindowsFormsApp1
{
    public partial class Register_lists : Form
    {
        public string doc_name;
        public string[] mywords;
        public Register_lists()
        {
            InitializeComponent();
        }
    private void button1_Click(object sender, EventArgs e)//插入数据库(list_id,doc_id,list_cost,list_date,patient_name,patient_sex,doc_office,check_way
        {
            string patient_name=this.patient_name.Text;
            string patient_sex=this.patient_sexs.Text;
            int patients_old = 0;
            try
            {
                patients_old = int.Parse(this.patient_old.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"请输入整数");
            }
            
            string doc_name = this.doctor_name.Text;
            string[] mywords = doc_name.Split(')');
            doc_name = mywords[1];
            string str_cost = this.list_cost.Text;
            int lists_cost= int.Parse(str_cost.Substring(0,str_cost.Length-1));
            string check_way=this.check_way.Text;
            
            //生成账单号
            #region
            string sql_select = "SELECT max(list_id) FROM net.lists;";
            MySqlCommand cmd = Mysql.Con_mysql(sql_select);
            MySqlDataReader reader_id=cmd.ExecuteReader();
            int list_id=0 ;
            while (reader_id.Read())
            {
                 list_id = reader_id.GetInt32(0)+1;
            }
            reader_id.Close();
            #endregion

            //查询医生id,科室
            #region//
            sql_select = "SELECT doc_id,doc_office FROM net.doctors where doc_name = "+"\""+doc_name+"\"";
            cmd = Mysql.Con_mysql(sql_select);
            reader_id = cmd.ExecuteReader();
            int doc_id = 0;
            string doc_office = "null";
            while (reader_id.Read())
            {
                 doc_id = reader_id.GetInt32(0);
                 doc_office = reader_id.GetString(1);
            }
            reader_id.Close() ;
            #endregion
            DateTime datetime=this.list_date.Value;

/*            Console.WriteLine(lists_cost);
            Console.WriteLine(patient_name);
            Console.WriteLine(patients_old);
            Console.WriteLine(doc_name);
            Console.WriteLine(list_id);
            Console.WriteLine(doc_id);
            Console.WriteLine(doc_office);
            Console.WriteLine(datetime);*/
            try
            {
                string sql_insert = "insert into net.lists(list_id,doc_id,list_cost,patient_name,patient_sex,patient_old,doc_offic,check_way,list_date) values(" + list_id  + "," +  doc_id + "," + lists_cost  + "," + "\""
                    + patient_name + "\"" + "," + "\"" + patient_sex + "\"" + "," + patients_old  + "," + "\"" + doc_office + "\"" + "," + "\"" + check_way + "\"" + "," + "\"" + datetime + "\"" + ")";
                //Console.WriteLine(sql_insert);
                cmd = Mysql.Con_mysql(sql_insert);
                cmd.ExecuteNonQuery();
                MessageBox.Show( "挂号成功\n您的单号为:"+list_id);
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message.ToString() + "挂号失败");
            }

        }

        private void doctor_name_SelectedIndexChanged(object sender, EventArgs e)//选择了不同医生
        {
            doc_name = this.doctor_name.Text;
            mywords= doc_name.Split(')');
            Console.WriteLine(mywords.Length);
            Console.WriteLine(mywords.ToString());
            try
            {
                doc_name = mywords[1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(doc_name);
            string sql = "SELECT doc_cost FROM net.doctors where doc_name =" + "\"" + doc_name + "\"";//列出医生的费用
            MySqlCommand cmd = Mysql.Con_mysql(sql);
            MySqlDataReader reader=cmd.ExecuteReader();
            while (reader.Read())
            { 
                this.list_cost.Text = reader.GetString(0)+"元";
            }
            reader.Close();

        }

        private void list_time_SelectedIndexChanged(object sender, EventArgs e)//时间段改变
        {
            this.doctor_name.Items.Clear();
            this.doctor_name.Text = null;
            this.list_cost.Text = null;
            DateTime date = this.list_date.Value;
            string lists_date = date.DayOfWeek.ToString();
            Console.WriteLine(lists_date);
            string lists_time = this.list_time.Text;
            string sql_select;
            if (lists_time.Equals("8:00~12:00"))
            {
                sql_select = $"SELECT doc_name,doc_position FROM net.doctors INNER JOIN net.morning on doctors.doc_id=morning.doc_id where({lists_date}=1);";
            }
            else
            {
                sql_select = $"SELECT doc_name,doc_position FROM net.doctors INNER JOIN net.evening on doctors.doc_id=evening.doc_id where({lists_date}=1);";
            }
            //Console.WriteLine(sql_select);
            MySqlCommand cmd = Mysql.Con_mysql(sql_select);//列出值班的不同医生
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.doctor_name.Items.Add("(" + reader.GetString(1) + ")" + reader.GetString(0));
            }
            reader.Close();
        }

        private void list_date_ValueChanged(object sender, EventArgs e)//日期改变
        {
            this.doctor_name.Items.Clear();
            this.doctor_name.Text = null;
            this.list_cost.Text = null;
            if (!string.IsNullOrEmpty(this.list_time.Text))
            {
                this.doctor_name.Items.Clear();
                DateTime date = this.list_date.Value;
                string lists_date = date.DayOfWeek.ToString();
                //Console.WriteLine(lists_date);
                string lists_time = this.list_time.Text;
                string sql_select;
                if (lists_time.Equals("8:00~12:00"))
                {
                    sql_select = $"SELECT doc_name,doc_position FROM net.doctors INNER JOIN net.morning on doctors.doc_id=morning.doc_id where({lists_date}=1);";
                }
                else
                {
                    sql_select = $"SELECT doc_name,doc_position FROM net.doctors INNER JOIN net.evening on doctors.doc_id=evening.doc_id where({lists_date}=1);";
                }
                //Console.WriteLine(sql_select);
                MySqlCommand cmd = Mysql.Con_mysql(sql_select);//列出值班的不同医生
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.doctor_name.Items.Add("(" + reader.GetString(1) + ")" + reader.GetString(0));
                }
                reader.Close();

            }
            else
            {
                return;
            }
        }
    }
}
