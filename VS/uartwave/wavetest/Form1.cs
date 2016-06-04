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

namespace wavetest
{
    public partial class Form1 : Form
    {
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

        int i = 0;
        Timer t = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "超声波";
            波特率cbox.Items.Add("115200");
            波特率cbox.SelectedIndex = 0;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);
            waveval.Text = "0";

            t.Interval = 200;

            t.Tick += new EventHandler((object s, EventArgs ex) =>
              {
                  sendCmd(1);
                  if (RecvFlag == 1)
                  {
                      RecvFlag = 0;
                      UInt16 cm = packbuff[0];
                      cm <<= 8;
                      cm |= packbuff[1];
                      waveval.Text = cm.ToString();
                  }



                  
              });



            //new Task(() =>
            //{
            //    while (!this.IsDisposed)
            //    {
            //        try
            //        {

            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }

            //    }
            //}).Start();


        }

        private void sendCmd(byte cmd)
        {
            byte [] data = new byte[7];
            data[0] = 0x55;
            data[1] = 0x00;
            data[2] = 0x00;
            data[3] = cmd;
            data[4] = 0x00;
            data[5] = 0x00;
            data[6] = 0x00;

            serialPort1.Write(data,0,7);


        }
        uint RecvFlag=0;
        uint recvmode = 0;
        UInt16 packlen = 0;
        uint count;
        const uint maxpacklen=1024;
        byte[] packbuff = new byte[maxpacklen];
        uint recvcmd;
        byte[] RecvCheck=new byte[1];//校验

        private void portDataReceived(object sender,SerialDataReceivedEventArgs e)
        {
            
            byte[] buf = new byte[1024];
            int len = serialPort1.Read(buf, 0, 1024);
            for (uint l = 0; l < len; l++)
            {
                switch (recvmode)
                {
                    case 0:
                        if (buf[l] == 0x55)
                            recvmode = 1;
                        break;
                    case 1:
                        packlen = buf[l];
                        count = 0;
                        RecvCheck[0] = 0;
                        recvmode = 2;
                        break;
                    case 2:
                        packlen <<= 8;
                        packlen |= buf[l];
                        if (packlen > maxpacklen)
                            recvmode = 0;
                        else recvmode = 3;
                        break;
                    case 3:
                        recvcmd = buf[l];
                        recvmode = 4;
                        break;
                    case 4:
                        packbuff[count] = buf[l];
                        RecvCheck[0] += buf[l];
                        count++;
                        if (count >= packlen)
                            recvmode = 5;

                        break;
                    case 5:
                        if(buf[l]!=RecvCheck[0])
                        {
                            recvmode = 0;
                            RecvFlag = 0;//接收失败
                        }
                        else
                        {
                            recvmode = 6;
                        }
                        break;
                    case 6:
                        RecvFlag = 1;//接收成功
                        recvmode = 0;
                        break;
                }
            }
            


        }

        bool buts = false;
        private void 连接but_Click(object sender, EventArgs e)
        {
            
            buts = !buts;
            if (buts == true)
            {
                
                try
                {
                    连接but.Text = "断开";
                    serialPort1.PortName = 端口cbox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(波特率cbox.Text, 10);
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();
                    t.Start();
                    

                }
                catch 
                {
                    MessageBox.Show("端口错误","错误");
                }



            }
            else
            {
                try
                {
                    serialPort1.Close();
                    连接but.Text = "连接";
                    t.Stop();
                }
                catch
                {

                    throw;
                }
                
            }
        }

        private void 端口cbox_MouseClick(object sender, MouseEventArgs e)
        {
            端口cbox.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                端口cbox.Items.Add(s);
            }
            端口cbox.SelectedIndex = 0;
        }
    }
}
