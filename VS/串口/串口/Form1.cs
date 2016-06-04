using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串口
{
    public partial class Form1 : Form
    {
        UInt32 sendLen = 0;
        UInt32 readLen = 0;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            foreach(string s in SerialPort.GetPortNames())
            {
                端口cbox.Items.Add(s);
            }
            端口cbox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "串口";
            波特率cbox.Items.Add("9600");
            波特率cbox.Items.Add("115200");
            波特率cbox.SelectedIndex = 1;
            readtext.ReadOnly = true;
            readtext.ScrollBars = ScrollBars.Both;
            EnabledSend(false);
            sendHex.Checked = true;
            readHex.Checked = true;
            newLine.Checked = true;

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);



        }
        private void EnabledSend(bool s)
        {
            sendbut.Enabled = sendtext.Enabled = s;
        }
        
        private void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buff = new byte[1024];
            int len = serialPort1.Read(buff, 0, 1024);

            if (!readHex.Checked)
            {
                readtext.Text += buff.ToString();   
            }else
            {
                string str=string .Empty;
                string str2;
                
                

                for (int l = 0; l < len; l++)
                {
                    str2 = Convert.ToString(buff[l], 16);
                    str+= (str2.Length == 1 ? "0" + str2 : str2) + " ";
                }

                readtext.Text += str;
            }
            readtext.SelectionStart = readtext.Text.Length;//设置光标位置
            readtext.ScrollToCaret();//滚动到光标处
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            端口cbox.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                端口cbox.Items.Add(s);
            }
            端口cbox.SelectedIndex = 0;

        }

        private void sendbut_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];
            //if(serialPort1.IsOpen)
            //{
                if (sendtext.Text != "")
                {
                    sendLen += (UInt32)sendtext.Text.Length;
                    slen.Text = sendLen.ToString();
                    if (!sendHex.Checked)
                    {
                        try
                        {
                        if (newLine.Checked)
                            sendtext.Text += "\r\n";
                            serialPort1.WriteLine(sendtext.Text);

                        
                        }
                        catch
                        {
                            MessageBox.Show("发送失败", "错误");
                            serialPort1.Close();
                            buts = false;
                            连接but.Text = "连接";
                            EnabledSend(false);
                        }

                    }
                    else
                    {
                        try
                        {
                            for (int i = 0; i < (sendtext.Text.Length - sendtext.Text.Length % 2) / 2; i++)
                            {
                                data[0] = Convert.ToByte(sendtext.Text.Substring(i * 2, 2), 16);
                                serialPort1.Write(data, 0, 1);
                            }
                            if(sendtext.Text.Length%2!=0)
                            {
                                data[0] = Convert.ToByte(sendtext.Text.Substring(sendtext.Text.Length - 1, 1), 16);
                                serialPort1.Write(data, 0, 1);
                            }
                            if(newLine.Checked)
                            serialPort1.WriteLine("\r\n");

                    }
                        catch
                        {
                            MessageBox.Show("发送失败", "错误");
                            serialPort1.Close();
                            buts = false;
                            连接but.Text = "连接";
                            EnabledSend(false);
                        }
                    }
                }
           // }

        }
        bool buts = false;
        private void 连接but_Click(object sender, EventArgs e)
        {
            buts = !buts;
            if (buts == true)
            {
                try
                {
                    serialPort1.PortName = 端口cbox.Text; 
                    serialPort1.BaudRate = Convert.ToInt32(波特率cbox.Text, 10);
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();
                    连接but.Text = "断开";
                    EnabledSend(true);
                }
                catch
                {
                    MessageBox.Show("端口错误", "错误");
                }
            }else
            {
                try
                {
                    serialPort1.Close();
                    连接but.Text = "连接";
                    EnabledSend(false);
                }
                catch
                {
                    throw;
                }
            }
            

        }

        private void clearReadbuf_Click(object sender, EventArgs e)
        {
            readtext.Text = "";
        }
    }
}
