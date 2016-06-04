namespace wavetest
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
            this.waveval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.端口cbox = new System.Windows.Forms.ComboBox();
            this.波特率cbox = new System.Windows.Forms.ComboBox();
            this.连接but = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // waveval
            // 
            this.waveval.Location = new System.Drawing.Point(224, 6);
            this.waveval.Name = "waveval";
            this.waveval.Size = new System.Drawing.Size(115, 21);
            this.waveval.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wave :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.端口cbox);
            this.groupBox3.Controls.Add(this.波特率cbox);
            this.groupBox3.Controls.Add(this.连接but);
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 117);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口设置";
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
            // 端口cbox
            // 
            this.端口cbox.FormattingEnabled = true;
            this.端口cbox.Location = new System.Drawing.Point(65, 18);
            this.端口cbox.Name = "端口cbox";
            this.端口cbox.Size = new System.Drawing.Size(60, 20);
            this.端口cbox.TabIndex = 4;
            this.端口cbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.端口cbox_MouseClick);
            // 
            // 波特率cbox
            // 
            this.波特率cbox.FormattingEnabled = true;
            this.波特率cbox.Location = new System.Drawing.Point(65, 52);
            this.波特率cbox.Name = "波特率cbox";
            this.波特率cbox.Size = new System.Drawing.Size(60, 20);
            this.波特率cbox.TabIndex = 5;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 126);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waveval);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox waveval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox 端口cbox;
        private System.Windows.Forms.ComboBox 波特率cbox;
        private System.Windows.Forms.Button 连接but;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

