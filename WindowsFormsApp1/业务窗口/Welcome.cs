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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            Label_slipe.fontSlide(this.welcome_intro);
        }
        public void TxtPrint(string str)
        {
            title.Text = "欢迎来到挂号系统,"+str+"用户！";
        }

        private void button6_Click(object sender, EventArgs e)//退出应用
        {
            DialogResult result = MessageBox.Show("是否确认关闭？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }

        }

        private void button5_Click(object sender, EventArgs e)//医师注册
        {
            Register_doctors r_doctors = new Register_doctors();
            r_doctors.Show();
        }

        private void button1_Click(object sender, EventArgs e)//挂号
        {
            Register_lists r_lists = new Register_lists();
            r_lists.Show();
        }

        private void button2_Click(object sender, EventArgs e)//统计查询退号
        {
            Statistical_select s_lists=new Statistical_select();
            s_lists.Show();
        }
        protected override void OnClosing(CancelEventArgs e)//右上角关闭
        {
            DialogResult result = MessageBox.Show("是否确认关闭？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = result != DialogResult.Yes;
            base.OnClosing(e);
            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
                Label_slipe.slideTimer.Stop();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)//医师排班
        {
            Arrange_doctors arrange_doc=new Arrange_doctors();
            arrange_doc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Call_lists call_lists = new Call_lists();
            call_lists.Show();
        }
    }
}
