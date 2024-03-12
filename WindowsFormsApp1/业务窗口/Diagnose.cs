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
    public partial class Diagnose : Form
    {
        List<string> listOnit1 = new List<string>();
        //输入key之后，返回的关键词
        List<string> listNew1 = new List<string>();
        List<string> listOnit2 = new List<string>();//1是疾病，2是药品
        List<string> listNew2 = new List<string>();

        public int flag = 8;//初始化
        public string name;
        public string sex;
        public string old;
        public string id;
        public DateTime time;
        public string office;
        public void write()
        {
            myNote.SelectionStart = flag;//要插入文本的位置，此时焦点已经在目标位置了，不需要设置
            myNote.SelectedText = name;//姓名
            flag += +name.Length + 5;

            myNote.SelectionStart = flag;
            myNote.SelectedText = sex;
            flag += sex.Length + 5;

            myNote.SelectionStart = flag;
            //myNote.SelectionStart = 8 + 3 + 5 + 1 + 5;
            myNote.SelectedText = old;
            flag+=old.Length + 7;

            myNote.SelectionStart = flag;
            //myNote.SelectionStart = 8 + 3 + 5 + 1 + 5 + 2 + 7;
            myNote.SelectedText = id;
            flag+=id.Length + 6;

            myNote.SelectionStart = flag;
            //myNote.SelectionStart = 8 + 3 + 5 + 1 + 5 + 2 + 7 + 8 + 6;
            myNote.SelectedText = time.ToString();
            flag+=time.ToString().Length + 10;

            myNote.SelectionStart = flag;
            //myNote.SelectionStart = 8 + 3 + 5 + 1 + 5 + 2 + 7 + 8 + 6 + 4 + 10;
            myNote.SelectedText = office;
            flag+=office.Length +48;

            myNote.SelectionStart = flag;
            //myNote.SelectionStart = 8 + 3 + 5 + 1 + 5 + 2 + 7 + 8 + 6 + 4 + 10 + 3 + 49;
            myNote.SelectionFont = new Font("楷体", 12, myNote.Font.Style);
        }
        public Diagnose()//开病例模板
        {
            InitializeComponent();
            myNote.LoadFile("..\\..\\Diagnose_lists\\模板.rtf");
        }
        private void open_Click(object sender, EventArgs e)
        {
            //创建一个打开文件对话框
            OpenFileDialog openFile1 = new OpenFileDialog();
            //限定打开文件的初始化文件目录
            openFile1.InitialDirectory = "..\\..\\Diagnose_lists";
            //筛选打开文件的类型为RTF格式
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";
            //判断用户是否从打开文件对话框中选择了一个文件
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile1.FileName.Length > 0)
            {
                myNote.LoadFile(openFile1.FileName);
            }
            //用ANSI编码格式保存txt文本避免出现乱码
            //myNote.LoadFile("D:\\CSharp\\notes\\test.txt", RichTextBoxStreamType.PlainText);
            //myNote.LoadFile("D:\\CSharp\\notes\\test.rtf", RichTextBoxStreamType.RichText);
        }
        //另存为
        private void save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认保存病历？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                myNote.SaveFile($"..\\..\\Diagnose_lists\\{id}_{name}.rtf");
                MessageBox.Show("保存成功");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"保存失败");
            }
            //自定义保存
/*            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.InitialDirectory = "E:\\VS\\Project\\WindowsFormsApp1\\Diagnose_lists";
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveFile1.FileName.Length > 0)
            {
                myNote.SaveFile(saveFile1.FileName);
            }*/
        }
        //注册链接跳转
        private void myNote_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
        //右键复制
        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(myNote.SelectedText);
        }
        //右键粘贴
        private void paste_Click(object sender, EventArgs e)
        {
            myNote.Paste();
        }
        //清空
        private void clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要清空MyNote中的所有内容？", "清空确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                myNote.Clear();
            }
        }
        //插入图片
        private void image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "*.jpg";
            openFileDialog1.Filter = "Image Files|*.jpg";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFileDialog1.FileName.Length > 0)
            {
                Image insertImage = Image.FromFile(openFileDialog1.FileName);
                Clipboard.SetImage(insertImage);
                myNote.Paste();
            }
        }
        //撤销
        private void unDo_Click(object sender, EventArgs e)
        {
            myNote.Undo();
        }
        //重做
        private void reDo_Click(object sender, EventArgs e)
        {
            myNote.Redo();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string[] lst_illness = this.comboBox1.Text.Split(' ');
            string illness =lst_illness[1];
            myNote.SelectedText=illness;
        }

        //下面是模糊搜索函数
        private void Diagnose_Load(object sender, EventArgs e)//调用combox方法
        {
            BindComboBox1();
            BindComboBox2();
        }
        private void BindComboBox1()
        {
            String sql_select = "SELECT id,name FROM net.icd10;";
            MySqlCommand cmd = Mysql.Con_mysql(sql_select);//列出编码和姓名
            Console.WriteLine(sql_select);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.listOnit1.Add(reader.GetString(0)+" "+reader.GetString(1));
            }
            reader.Close();
            /*
             * 1.注意用Item.Add(obj)或者Item.AddRange(obj)方式添加
             * 2.如果用DataSource绑定，后面再进行绑定是不行的，即便是Add或者Clear也不行
             */
            this.comboBox1.Items.AddRange(listOnit1.ToArray());
        }
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            //清空combobox
            this.comboBox1.Items.Clear();
            //清空listNew1
            listNew1.Clear();
            //遍历全部备查数据
            foreach (var item in listOnit1)
            {
                if (item.Contains(this.comboBox1.Text))
                {
                    //符合，插入listNew1
                    listNew1.Add(item);
                }
            }
            //combobox添加已经查到的关键词
            this.comboBox1.Items.AddRange(listNew1.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            this.comboBox1.SelectionStart = this.comboBox1.Text.Length;
            //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            Cursor = Cursors.Default;
            //自动弹出下拉框
            //this.comboBox1.DroppedDown = true;
        }
        //1是疾病搜寻，2是药品搜寻
        private void BindComboBox2()
        {
            String sql_select = "SELECT name,unit FROM net.medicines;";
            MySqlCommand cmd = Mysql.Con_mysql(sql_select);//列出编码和姓名
            Console.WriteLine(sql_select);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.listOnit2.Add(reader.GetString(0) + "(" + reader.GetString(1)+")");
            }
            reader.Close();
            /*
             * 1.注意用Item.Add(obj)或者Item.AddRange(obj)方式添加
             * 2.如果用DataSource绑定，后面再进行绑定是不行的，即便是Add或者Clear也不行
             */
            this.comboBox2.Items.AddRange(listOnit2.ToArray());
        }
        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            //清空combobox
            this.comboBox2.Items.Clear();
            //清空listNew1
            listNew2.Clear();
            //遍历全部备查数据
            foreach (var item in listOnit2)
            {
                if (item.Contains(this.comboBox2.Text))
                {
                    //符合，插入listNew1
                    listNew2.Add(item);
                }
            }
            //combobox添加已经查到的关键词
            this.comboBox2.Items.AddRange(listNew2.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            this.comboBox2.SelectionStart = this.comboBox2.Text.Length;
            //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            Cursor = Cursors.Default;
            //自动弹出下拉框
            //this.comboBox1.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string medicine = this.comboBox2.Text;
            myNote.SelectedText = medicine;
        }
    }
}
