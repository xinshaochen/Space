using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS无线控制
{

    struct oasc
    {
        

    }
    public partial class Form1 : Form
    {
        
        TcpClient client = null;//TcpClient 实例
        NetworkStream stream = null;//网络流
        bool o = false;
        public Form1()
        {
            InitializeComponent();
            enableui(false);
        } 
        void enableui(bool enable)
        {
            R.Enabled = B.Enabled = G.Enabled = enable;
            trackBarR.Enabled = trackBarG.Enabled = trackBarB.Enabled = enable;
        }
        private void link_Click(object sender, EventArgs e)
        {
            o = !o;
            if (o)
            {


                IPAddress remoteIP = IPAddress.Parse(ip.Text);
                int remotePort = int.Parse(port.Text);

                while (true)
                {

                    client = new TcpClient();

                    try
                    {
                        client.Connect(remoteIP, remotePort);//连接远程主机
                        link.Text = "断开";
                        enableui(true);
                        Task.Run(() =>
                        {
                            while (client.Client.Connected)
                            {
                                try
                                {
                                    byte[] buff = new byte[1024];
                                    int len = client.Client.Receive(buff);
                                    Invoke(new MethodInvoker(() =>
                                    {
                                        //readbox.Text += System.Text.Encoding.Default.GetString(buff);
                                    }));
                                }
                                catch
                                {
                                    return;
                                }
                                Thread.Sleep(1);
                            }
                        });
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("连接超时，服务器没有响应！");
                        return;
                    }

                    return;
                }
            }
            else
            {
                link.Text = "连接";
                enableui(false);
                if (stream != null)
                {
                    stream.Close();//关闭网络流
                }
                client.Close();//关闭客户端

            }

        }
        int color=0x00;
        
        bool ro = false;
        private void R_Click(object sender, EventArgs e)
        {
            ro = !ro;
            if (ro) color |= 0x01;
            else color &= 0xfe;
            string sendString = null;
            byte[] sendData = null;
            sendString += (char)color;
            sendData = Encoding.Default.GetBytes(sendString);

            stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);
        }
        bool go = false;
        private void G_Click(object sender, EventArgs e)
        {
            go = !go;
            if (go) color |= 0x02;
            else color &= 0xfd;
            string sendString = null;
            byte[] sendData = null;
            sendString += (char)color;
            sendData = Encoding.Default.GetBytes(sendString);

            stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);
        }
        bool bo = false;
        private void B_Click(object sender, EventArgs e)
        {
            bo = !bo;
            if (bo) color |= 0x04;
            else color &= 0xfb;
            string sendString = null;
            byte[] sendData = null;
            sendString += (char)color;
            sendData = Encoding.Default.GetBytes(sendString);

            stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);
        }
        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //sendData[0] = (byte)trackBarR.Value;

            //stream = client.GetStream();
            //stream.Write(sendData, 0, sendData.Length);
            //textBox1.Text = trackBarR.Value.ToString();

        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //sendData[1] = (byte)trackBarG.Value;

            //stream = client.GetStream();
            //stream.Write(sendData, 0, sendData.Length);
            //textBox2.Text = trackBarG.Value.ToString();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //sendData[2] = (byte)trackBarB.Value;

            //stream = client.GetStream();
            //stream.Write(sendData, 0, sendData.Length);
            //textBox3.Text = trackBarB.Value.ToString();
        }



        private void test_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = null;
            byte[] sendData = null;
            int[] o = new int[32];
            o[0] = 0x30;
            for (int i = 0; i < 32; i++)
            {
                o[i] = 0x30 + i;
            }
            foreach (int i in o)
            {
                str += (char)i;

            }
            test.Text = str;

            sendData = Encoding.Default.GetBytes(str);

            stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);

            int[] oi = new int[32];
            int s = 0;
            foreach (int i in "1234567890")
            {
                oi[s] = i;
                s++; 
            }
        }


        byte[] sendData = new byte[3];
        byte[] sendDataBuff = new byte[3];
        int i;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sendData[0] = (byte)trackBarR.Value;
            sendData[1] = (byte)trackBarG.Value;
            sendData[2] = (byte)trackBarB.Value;
            

            if ((sendData[0] != sendDataBuff[0]) || (sendData[1] != sendDataBuff[1]) || (sendData[2] != sendDataBuff[2]))
            {
                textBox1.Text = sendData[0].ToString();
                textBox2.Text = sendData[1].ToString();
                textBox3.Text = sendData[2].ToString();
                stream = client.GetStream();
                stream.Write(sendData, 0, sendData.Length);

                i = 0;

                sendDataBuff[0] = sendData[0];
                sendDataBuff[1] = sendData[1];
                sendDataBuff[2] = sendData[2];
            }else
            {
                if (i <= 5)
                {
                    i++;
                    stream = client.GetStream();
                    stream.Write(sendData, 0, sendData.Length);
                }
            }
            //stream.Flush();

        }
    }
}
