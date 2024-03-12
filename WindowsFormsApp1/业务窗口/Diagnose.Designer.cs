namespace WindowsFormsApp1
{
    partial class Diagnose
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
            this.components = new System.ComponentModel.Container();
            this.myNote = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.unDo = new System.Windows.Forms.Button();
            this.reDo = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myNote
            // 
            this.myNote.BackColor = System.Drawing.Color.White;
            this.myNote.ContextMenuStrip = this.contextMenuStrip1;
            this.myNote.EnableAutoDragDrop = true;
            this.myNote.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myNote.Location = new System.Drawing.Point(12, 41);
            this.myNote.Name = "myNote";
            this.myNote.Size = new System.Drawing.Size(748, 392);
            this.myNote.TabIndex = 0;
            this.myNote.Tag = "";
            this.myNote.Text = "\n\n";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy,
            this.paste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(108, 24);
            this.copy.Text = "复制";
            this.copy.Click += new System.EventHandler(this.image_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(108, 24);
            this.paste.Text = "粘贴";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(12, 5);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(71, 30);
            this.open.TabIndex = 1;
            this.open.Text = "打开";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(655, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(105, 30);
            this.save.TabIndex = 3;
            this.save.Text = "完成保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // unDo
            // 
            this.unDo.Location = new System.Drawing.Point(101, 5);
            this.unDo.Name = "unDo";
            this.unDo.Size = new System.Drawing.Size(71, 30);
            this.unDo.TabIndex = 4;
            this.unDo.Text = "撤销";
            this.unDo.UseVisualStyleBackColor = true;
            this.unDo.Click += new System.EventHandler(this.unDo_Click);
            // 
            // reDo
            // 
            this.reDo.Location = new System.Drawing.Point(189, 5);
            this.reDo.Name = "reDo";
            this.reDo.Size = new System.Drawing.Size(71, 30);
            this.reDo.TabIndex = 5;
            this.reDo.Text = "重做";
            this.reDo.UseVisualStyleBackColor = true;
            this.reDo.Click += new System.EventHandler(this.reDo_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(280, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(71, 30);
            this.clear.TabIndex = 6;
            this.clear.Text = "清空";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(370, 5);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(82, 30);
            this.image.TabIndex = 7;
            this.image.Text = "插入图片";
            this.image.UseVisualStyleBackColor = true;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.insert.Location = new System.Drawing.Point(563, 448);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(71, 25);
            this.insert.TabIndex = 8;
            this.insert.Text = "插入";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(69, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "疾病搜寻：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 448);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(210, 483);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(334, 23);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.TextUpdate += new System.EventHandler(this.comboBox2_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(69, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "药品搜寻：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(563, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "插入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Diagnose
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(795, 518);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.image);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.reDo);
            this.Controls.Add(this.unDo);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Controls.Add(this.myNote);
            this.Name = "Diagnose";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Diagnose_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox myNote;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button unDo;
        private System.Windows.Forms.Button reDo;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button image;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}