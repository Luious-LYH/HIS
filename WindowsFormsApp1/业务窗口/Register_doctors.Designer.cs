namespace WindowsFormsApp1
{
    partial class Register_doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_doctors));
            this.label1 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.input_office = new System.Windows.Forms.TextBox();
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.input_pos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(290, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "医师注册界面";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(346, 120);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(156, 25);
            this.input_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 350);
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
            this.label2.Location = new System.Drawing.Point(280, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名：";
            // 
            // input_office
            // 
            this.input_office.Location = new System.Drawing.Point(346, 224);
            this.input_office.Name = "input_office";
            this.input_office.Size = new System.Drawing.Size(156, 25);
            this.input_office.TabIndex = 6;
            // 
            // input_date
            // 
            this.input_date.Location = new System.Drawing.Point(346, 270);
            this.input_date.MaxDate = new System.DateTime(2022, 4, 12, 0, 0, 0, 0);
            this.input_date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(156, 25);
            this.input_date.TabIndex = 8;
            this.input_date.Value = new System.DateTime(2022, 4, 12, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(257, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "生日日期:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(265, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "值班室：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(280, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "职位：";
            // 
            // input_pos
            // 
            this.input_pos.FormattingEnabled = true;
            this.input_pos.Items.AddRange(new object[] {
            "医师",
            "主任医师"});
            this.input_pos.Location = new System.Drawing.Point(346, 172);
            this.input_pos.Name = "input_pos";
            this.input_pos.Size = new System.Drawing.Size(156, 23);
            this.input_pos.TabIndex = 15;
            // 
            // Register_doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input_pos);
            this.Controls.Add(this.input_office);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label1);
            this.Name = "Register_doctors";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_office;
        private System.Windows.Forms.DateTimePicker input_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox input_pos;
    }
}