namespace WindowsFormsApp1
{
    partial class Register_lists
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_lists));
            this.label1 = new System.Windows.Forms.Label();
            this.patient_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.patient_old = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.doctor_name = new System.Windows.Forms.ComboBox();
            this.check_way = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_cost = new System.Windows.Forms.Label();
            this.list_date = new System.Windows.Forms.DateTimePicker();
            this.list_time = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.patient_sexs = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(317, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "挂号界面";
            // 
            // patient_name
            // 
            this.patient_name.Location = new System.Drawing.Point(337, 69);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(156, 25);
            this.patient_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "完成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(249, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "患者姓名：";
            // 
            // patient_old
            // 
            this.patient_old.Location = new System.Drawing.Point(337, 104);
            this.patient_old.Name = "patient_old";
            this.patient_old.Size = new System.Drawing.Size(156, 25);
            this.patient_old.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(249, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "结账方式：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(249, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "看病医师：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(249, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "患者年龄：";
            // 
            // doctor_name
            // 
            this.doctor_name.FormattingEnabled = true;
            this.doctor_name.Location = new System.Drawing.Point(337, 248);
            this.doctor_name.Name = "doctor_name";
            this.doctor_name.Size = new System.Drawing.Size(156, 23);
            this.doctor_name.TabIndex = 15;
            this.doctor_name.SelectedIndexChanged += new System.EventHandler(this.doctor_name_SelectedIndexChanged);
            // 
            // check_way
            // 
            this.check_way.FormattingEnabled = true;
            this.check_way.Items.AddRange(new object[] {
            "手机支付",
            "现金"});
            this.check_way.Location = new System.Drawing.Point(337, 329);
            this.check_way.Name = "check_way";
            this.check_way.Size = new System.Drawing.Size(156, 23);
            this.check_way.TabIndex = 16;
            this.check_way.Text = "手机支付";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(249, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "所需费用:";
            // 
            // list_cost
            // 
            this.list_cost.AutoSize = true;
            this.list_cost.BackColor = System.Drawing.Color.Transparent;
            this.list_cost.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_cost.Location = new System.Drawing.Point(333, 288);
            this.list_cost.Name = "list_cost";
            this.list_cost.Size = new System.Drawing.Size(39, 20);
            this.list_cost.TabIndex = 18;
            this.list_cost.Text = "0元";
            // 
            // list_date
            // 
            this.list_date.Location = new System.Drawing.Point(337, 170);
            this.list_date.Name = "list_date";
            this.list_date.Size = new System.Drawing.Size(156, 25);
            this.list_date.TabIndex = 19;
            this.list_date.ValueChanged += new System.EventHandler(this.list_date_ValueChanged);
            // 
            // list_time
            // 
            this.list_time.FormattingEnabled = true;
            this.list_time.Items.AddRange(new object[] {
            "8:00~12:00",
            "14:00~18:00"});
            this.list_time.Location = new System.Drawing.Point(337, 208);
            this.list_time.Name = "list_time";
            this.list_time.Size = new System.Drawing.Size(156, 23);
            this.list_time.TabIndex = 21;
            this.list_time.SelectedIndexChanged += new System.EventHandler(this.list_time_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(234, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "挂号时间段：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(249, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "挂号日期：";
            // 
            // patient_sexs
            // 
            this.patient_sexs.FormattingEnabled = true;
            this.patient_sexs.Items.AddRange(new object[] {
            "男",
            "女"});
            this.patient_sexs.Location = new System.Drawing.Point(337, 138);
            this.patient_sexs.Name = "patient_sexs";
            this.patient_sexs.Size = new System.Drawing.Size(156, 23);
            this.patient_sexs.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(278, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "性别：";
            // 
            // Register_lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patient_sexs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.list_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_date);
            this.Controls.Add(this.list_cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.check_way);
            this.Controls.Add(this.doctor_name);
            this.Controls.Add(this.patient_old);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patient_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "Register_lists";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patient_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patient_old;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox doctor_name;
        private System.Windows.Forms.ComboBox check_way;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label list_cost;
        private System.Windows.Forms.DateTimePicker list_date;
        private System.Windows.Forms.ComboBox list_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox patient_sexs;
        private System.Windows.Forms.Label label9;
    }
}