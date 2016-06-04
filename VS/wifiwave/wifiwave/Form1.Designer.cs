namespace wifiwave
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
            this.label1 = new System.Windows.Forms.Label();
            this.waveval = new System.Windows.Forms.TextBox();
            this.ipadd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.getdatabut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wave :";
            // 
            // waveval
            // 
            this.waveval.Location = new System.Drawing.Point(261, 12);
            this.waveval.Name = "waveval";
            this.waveval.Size = new System.Drawing.Size(115, 21);
            this.waveval.TabIndex = 2;
            // 
            // ipadd
            // 
            this.ipadd.Location = new System.Drawing.Point(53, 60);
            this.ipadd.Name = "ipadd";
            this.ipadd.Size = new System.Drawing.Size(115, 21);
            this.ipadd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "地址:";
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(53, 87);
            this.dataBox.Multiline = true;
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(317, 64);
            this.dataBox.TabIndex = 6;
            // 
            // getdatabut
            // 
            this.getdatabut.Location = new System.Drawing.Point(305, 58);
            this.getdatabut.Name = "getdatabut";
            this.getdatabut.Size = new System.Drawing.Size(65, 23);
            this.getdatabut.TabIndex = 7;
            this.getdatabut.Text = "获取数据";
            this.getdatabut.UseVisualStyleBackColor = true;
            this.getdatabut.Click += new System.EventHandler(this.getdatabut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 161);
            this.Controls.Add(this.getdatabut);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waveval);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox waveval;
        private System.Windows.Forms.TextBox ipadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.Button getdatabut;
    }
}

