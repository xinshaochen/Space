namespace 串口
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.连接but = new System.Windows.Forms.Button();
            this.端口cbox = new System.Windows.Forms.ComboBox();
            this.波特率cbox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.readtext = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendtext = new System.Windows.Forms.TextBox();
            this.sendbut = new System.Windows.Forms.Button();
            this.sendHex = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearReadbuf = new System.Windows.Forms.Button();
            this.readHex = new System.Windows.Forms.CheckBox();
            this.newLine = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.slen = new System.Windows.Forms.Label();
            this.rlen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "波特率：";
            // 
            // 连接but
            // 
            this.连接but.Location = new System.Drawing.Point(6, 88);
            this.连接but.Name = "连接but";
            this.连接but.Size = new System.Drawing.Size(39, 23);
            this.连接but.TabIndex = 3;
            this.连接but.Text = "连接";
            this.连接but.UseVisualStyleBackColor = true;
            this.连接but.Click += new System.EventHandler(this.连接but_Click);
            // 
            // 端口cbox
            // 
            this.端口cbox.FormattingEnabled = true;
            this.端口cbox.Location = new System.Drawing.Point(65, 18);
            this.端口cbox.Name = "端口cbox";
            this.端口cbox.Size = new System.Drawing.Size(60, 20);
            this.端口cbox.TabIndex = 4;
            this.端口cbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // 波特率cbox
            // 
            this.波特率cbox.FormattingEnabled = true;
            this.波特率cbox.Location = new System.Drawing.Point(65, 52);
            this.波特率cbox.Name = "波特率cbox";
            this.波特率cbox.Size = new System.Drawing.Size(60, 20);
            this.波特率cbox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readtext);
            this.groupBox1.Location = new System.Drawing.Point(172, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收区";
            // 
            // readtext
            // 
            this.readtext.Location = new System.Drawing.Point(6, 12);
            this.readtext.Multiline = true;
            this.readtext.Name = "readtext";
            this.readtext.Size = new System.Drawing.Size(316, 77);
            this.readtext.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sendtext);
            this.groupBox2.Location = new System.Drawing.Point(172, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 95);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送区";
            // 
            // sendtext
            // 
            this.sendtext.Location = new System.Drawing.Point(6, 12);
            this.sendtext.Multiline = true;
            this.sendtext.Name = "sendtext";
            this.sendtext.Size = new System.Drawing.Size(316, 77);
            this.sendtext.TabIndex = 1;
            // 
            // sendbut
            // 
            this.sendbut.Location = new System.Drawing.Point(506, 179);
            this.sendbut.Name = "sendbut";
            this.sendbut.Size = new System.Drawing.Size(39, 23);
            this.sendbut.TabIndex = 8;
            this.sendbut.Text = "发送";
            this.sendbut.UseVisualStyleBackColor = true;
            this.sendbut.Click += new System.EventHandler(this.sendbut_Click);
            // 
            // sendHex
            // 
            this.sendHex.AutoSize = true;
            this.sendHex.Location = new System.Drawing.Point(506, 157);
            this.sendHex.Name = "sendHex";
            this.sendHex.Size = new System.Drawing.Size(84, 16);
            this.sendHex.TabIndex = 9;
            this.sendHex.Text = "发送16进制";
            this.sendHex.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.端口cbox);
            this.groupBox3.Controls.Add(this.波特率cbox);
            this.groupBox3.Controls.Add(this.连接but);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 117);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口设置";
            // 
            // clearReadbuf
            // 
            this.clearReadbuf.Location = new System.Drawing.Point(506, 78);
            this.clearReadbuf.Name = "clearReadbuf";
            this.clearReadbuf.Size = new System.Drawing.Size(39, 23);
            this.clearReadbuf.TabIndex = 11;
            this.clearReadbuf.Text = "清空";
            this.clearReadbuf.UseVisualStyleBackColor = true;
            this.clearReadbuf.Click += new System.EventHandler(this.clearReadbuf_Click);
            // 
            // readHex
            // 
            this.readHex.AutoSize = true;
            this.readHex.Location = new System.Drawing.Point(506, 56);
            this.readHex.Name = "readHex";
            this.readHex.Size = new System.Drawing.Size(84, 16);
            this.readHex.TabIndex = 12;
            this.readHex.Text = "接收16进制";
            this.readHex.UseVisualStyleBackColor = true;
            // 
            // newLine
            // 
            this.newLine.AutoSize = true;
            this.newLine.Location = new System.Drawing.Point(506, 135);
            this.newLine.Name = "newLine";
            this.newLine.Size = new System.Drawing.Size(72, 16);
            this.newLine.TabIndex = 13;
            this.newLine.Text = "发送新行";
            this.newLine.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "S:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "R:";
            // 
            // slen
            // 
            this.slen.AutoSize = true;
            this.slen.Location = new System.Drawing.Point(24, 196);
            this.slen.Name = "slen";
            this.slen.Size = new System.Drawing.Size(35, 12);
            this.slen.TabIndex = 16;
            this.slen.Text = "00000";
            // 
            // rlen
            // 
            this.rlen.AutoSize = true;
            this.rlen.Location = new System.Drawing.Point(89, 196);
            this.rlen.Name = "rlen";
            this.rlen.Size = new System.Drawing.Size(35, 12);
            this.rlen.TabIndex = 17;
            this.rlen.Text = "00000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 215);
            this.Controls.Add(this.rlen);
            this.Controls.Add(this.slen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newLine);
            this.Controls.Add(this.readHex);
            this.Controls.Add(this.clearReadbuf);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sendHex);
            this.Controls.Add(this.sendbut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button 连接but;
        private System.Windows.Forms.ComboBox 端口cbox;
        private System.Windows.Forms.ComboBox 波特率cbox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sendbut;
        private System.Windows.Forms.CheckBox sendHex;
        private System.Windows.Forms.TextBox readtext;
        private System.Windows.Forms.TextBox sendtext;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clearReadbuf;
        private System.Windows.Forms.CheckBox readHex;
        private System.Windows.Forms.CheckBox newLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label slen;
        private System.Windows.Forms.Label rlen;
    }
}

