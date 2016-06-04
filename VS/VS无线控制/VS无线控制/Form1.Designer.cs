namespace VS无线控制
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
            this.R = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            this.SuspendLayout();
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(165, 12);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(32, 29);
            this.R.TabIndex = 0;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(165, 48);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(32, 29);
            this.G.TabIndex = 1;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(165, 83);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(32, 29);
            this.B.TabIndex = 2;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "MODE：";
            // 
            // mode
            // 
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "UDP",
            "TCP Client",
            "TCP Server"});
            this.mode.Location = new System.Drawing.Point(50, 12);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(100, 20);
            this.mode.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prot：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "IP：";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(50, 65);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(81, 21);
            this.port.TabIndex = 16;
            this.port.Text = "8088";
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(5, 92);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(74, 28);
            this.link.TabIndex = 15;
            this.link.Text = "连接";
            this.link.UseVisualStyleBackColor = true;
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(50, 38);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(100, 21);
            this.ip.TabIndex = 14;
            this.ip.Text = "192.168.0.10";
            // 
            // trackBarR
            // 
            this.trackBarR.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarR.Location = new System.Drawing.Point(196, 12);
            this.trackBarR.Maximum = 128;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarR.Size = new System.Drawing.Size(124, 45);
            this.trackBarR.TabIndex = 21;
            this.trackBarR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(196, 48);
            this.trackBarG.Maximum = 128;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(124, 45);
            this.trackBarG.TabIndex = 22;
            this.trackBarG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(196, 83);
            this.trackBarB.Maximum = 128;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(124, 45);
            this.trackBarB.TabIndex = 23;
            this.trackBarB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 21);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 21);
            this.textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(326, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 21);
            this.textBox3.TabIndex = 26;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(5, 284);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(379, 21);
            this.test.TabIndex = 27;
            this.test.TextChanged += new System.EventHandler(this.test_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 28;
            this.button1.Text = "buttontest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 132);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.link);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Name = "Form1";
            this.Text = "无线控制";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button link;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

