using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wifiwave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        byte[] GetData;
        UdpClient Search = new UdpClient(0);
        IPAddress lasttarget;
        IPAddress[] ips;
        uint wave;
        Timer t = new Timer();

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData = Encoding.Default.GetBytes("GetData()");
            dataBox.BackColor = Color.Black;
            dataBox.ForeColor = Color.Green;
            dataBox.ReadOnly = true;
            dataBox.ScrollBars = ScrollBars.Both;
           



             Search.Send(GetData, GetData.Length, "255.255.255.255", 2333);

            new Task(() =>
            {
                while (true)
                {
                    try
                    {
                        IPEndPoint p = new IPEndPoint(IPAddress.Any, 0);
                        byte[] buff = Search.Receive(ref p);
                        lasttarget = p.Address;
                        

                        string value = Encoding.Default.GetString(buff);
                        int pos = value.IndexOf("Data:");
                        if (pos != -1)
                        {
                            BinaryReader br = new BinaryReader(new MemoryStream(buff),Encoding.Default);
                            br.BaseStream.Seek(pos += 5, SeekOrigin.Begin);
                            wave = br.ReadByte();
                            wave <<= 8;
                            wave |= br.ReadByte();

                            Invoke(new MethodInvoker(() =>
                            {
                                waveval.Text = wave.ToString();

                                ipadd.Text = lasttarget.ToString();
                                dataBox.Text += value;
                                dataBox.SelectionStart = dataBox.Text.Length;
                                dataBox.ScrollToCaret();
                            }));
                        }

                        

                        

                        



                    }
                    catch { }
                }
            }).Start();

            
            t.Interval = 200;
            t.Tick += new EventHandler((object s, EventArgs ex) =>
              {
                  Search.Send(GetData, GetData.Length, new IPEndPoint(lasttarget.Address|0xff000000, 2333));

              });
            

        }
        IPAddress[] getIPAddress()
        {
            List<IPAddress> iplist = new List<IPAddress>();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                //判断是否为以太网卡
                //Wireless80211         无线网卡    Ppp     宽带连接
                //Ethernet              以太网卡   
                //这里篇幅有限贴几个常用的，其他的返回值大家就自己百度吧！
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet || adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    if (adapter.Speed < 0) continue;
                    //获取以太网卡网络接口信息
                    IPInterfaceProperties ip = adapter.GetIPProperties();
                    //获取单播地址集
                    UnicastIPAddressInformationCollection ipCollection = ip.UnicastAddresses;
                    foreach (UnicastIPAddressInformation ipadd in ipCollection)
                    {
                        //InterNetwork    IPV4地址      InterNetworkV6        IPV6地址
                        //Max            MAX 位址
                        if (ipadd.Address.AddressFamily == AddressFamily.InterNetwork)
                            //判断是否为ipv4
                            iplist.Add(ipadd.Address);//获取ip
                    }
                }
            }
            return iplist.ToArray();
        }

        bool bust = false;
        private void getdatabut_Click(object sender, EventArgs e)
        {
            bust = !bust;
            if(bust==true)
            {
                getdatabut.Text = "停止获取";
                Search.Send(GetData, GetData.Length, "255.255.255.255", 2333);
                t.Start();

            }
            else
            {
                getdatabut.Text = "获取数据";
                t.Stop();
            }
            

        }
    }
}