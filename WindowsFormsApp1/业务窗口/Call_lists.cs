using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Call_lists : Form
    {
        public SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例

        public int length = 0;
        Stack<int> s_id = new Stack<int>();
        Stack<string> s_name = new Stack<string>();
        Stack<string> s_sex = new Stack<string>();
        Stack<string> s_office = new Stack<string>();
        Stack<int> s_old = new Stack<int>();

        public string list_id;
        public string patient_name;
        public string patient_sex;
        public string doc_offic;
        public string patient_old;
        public DateTime time;
        public Call_lists()
        {
            InitializeComponent();
            string sql = "SELECT list_id,patient_name,doc_offic,patient_sex,patient_old FROM net.lists order by list_id desc";
            MySqlCommand cmd = Mysql.Con_mysql(sql);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s_id.Push(reader.GetInt32(0));
                s_name.Push(reader.GetString(1));
                s_office.Push(reader.GetString(2));
                s_sex.Push(reader.GetString(3));
                s_old.Push(reader.GetInt32(4));
            }
            reader.Close();
            length = s_id.Count;
            if (length > 0)
            {
                list_id = s_id.Pop().ToString();
                patient_name = s_name.Pop();
                doc_offic = s_office.Pop();
                patient_sex = s_sex.Pop();
                patient_old = s_old.Pop().ToString();
                time = DateTime.Now;
                //上面是用来传递的参数，下面是叫号设计窗口
                this.label_list.Text = list_id;
                this.label_name.Text = patient_name;
                this.label_office.Text = doc_offic;
                this.label_sex.Text = patient_sex;
                length -= 1;
            }
            else
            {
                Console.WriteLine("暂时无人就诊");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)//叫号
        {
            if (this.label_list.Text.Equals("暂无")){
                MessageBox.Show("暂无挂号人员");
                return;
            }
            //SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
            voice.Rate = 0; //设置语速,[-10,10]
            voice.Volume = 100; //设置音量,[0,100]
            voice.SpeakAsync("请单号为"+ this.label_list.Text+"的"+ this.label_name.Text+"前往"+ this.label_office.Text+"就诊!");  //播放指定的字符串,这是异步朗读

            //下面的代码为一些SpeechSynthesizer的属性，看实际情况是否需要使用
            /*            voice.Dispose();  //释放所有语音资源
                        voice.SpeakAsyncCancelAll();  //取消朗读
                        voice.Speak("Hellow Word");  //同步朗读
                        voice.Pause();  //暂停朗读
                        voice.Resume(); //继续朗读*/

        }

        private void button2_Click(object sender, EventArgs e)//接诊结束，换下一个
        {
            if (length == 0)
            {
                MessageBox.Show("暂无挂号人员");
                this.label_list.Text = "暂无";
                this.label_name.Text = "暂无";
                this.label_office.Text = "暂无";
                this.label_sex.Text = "暂无";
            }
            else
            {
                voice.SpeakAsyncCancelAll();
                list_id = s_id.Pop().ToString();
                patient_name = s_name.Pop();
                doc_offic = s_office.Pop();
                patient_sex = s_sex.Pop();
                patient_old = s_old.Pop().ToString();
                time = DateTime.Now;

                this.label_list.Text = list_id;
                this.label_name.Text = patient_name;
                this.label_office.Text = doc_offic;
                this.label_sex.Text = patient_sex;
                length -= 1;
                button1.PerformClick();
            }
        }
        private void button3_Click(object sender, EventArgs e)//开病例
        {
            if (length == 0)
            {
                MessageBox.Show("暂无挂号人员");
                this.label_list.Text = "暂无";
                this.label_name.Text = "暂无";
                this.label_office.Text = "暂无";
                this.label_sex.Text = "暂无";
            }
            else
            {
                Diagnose diagnose = new Diagnose();
                diagnose.name = patient_name;
                diagnose.sex = patient_sex;
                diagnose.old = patient_old;
                diagnose.id = list_id;
                diagnose.time = time;
                diagnose.office = doc_offic;
                diagnose.write();
                diagnose.Show();
            }
        }
    }
}
