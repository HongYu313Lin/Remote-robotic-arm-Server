using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using XYZrobot;
using System.Threading;
using System.Diagnostics;
namespace TCPIPServer
{
    public partial class TCP : Form
    {
        XYZrobot.XYZrobot robotarm;
        public TCP()
        {
            InitializeComponent();
            robotarm = new XYZrobot.XYZrobot();
            robotarm.Show();

            textIPnum.Text = "127.0.0.1";

            textportnum.Text = "13000";
        }

        int port;//port型態

        String IP ;//IP型態

        TcpListener myTcpListener;

        Socket mySocket;

        private void buttonenter_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void TCP_Load(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            IP = textIPnum.Text;
            port = Convert.ToInt16(textportnum.Text);
            IPAddress theIPAddress = IPAddress.Parse(IP);
            myTcpListener = new TcpListener(theIPAddress, port);
            this.Invoke(new EventHandler(delegate
            {
                textmessage.Text += System.DateTime.Now.ToString() + Environment.NewLine + "IP:" + IP + "通訊埠:" + port + Environment.NewLine + "等待用戶端連線.. ";
                textmessage.AppendText("..." + "\r\n");
            }));
            myTcpListener.Start();

            mySocket = myTcpListener.AcceptSocket();

            try
            {
                if (mySocket.Connected)
                {
                    IPEndPoint remoteIpEndPoint = mySocket.RemoteEndPoint as IPEndPoint;
                    IPEndPoint localIpEndPoint = mySocket.LocalEndPoint as IPEndPoint;
                    this.Invoke(new EventHandler(delegate
                    {
                        textmessage.Text += Environment.NewLine + System.DateTime.Now.ToString() + Environment.NewLine + remoteIpEndPoint.Address.ToString() + "  連線成功!! ";//用戶端請求連線成功，就會秀出訊息。

                        textmessage.AppendText("..." + "\r\n");
                    }));

                }


            }
            catch (Exception Q)
            {
                this.Invoke(new EventHandler(delegate
                {
                    textmessage.Text = Q.ToString();
                }));
                //throw;
            }
            Stopwatch sw = new Stopwatch();
            
            sw.Start();
            while (true)
            {
                try
                {

                    if (mySocket.Connected == false || sw.Elapsed.TotalSeconds>5)
                    {
                        this.Invoke(new EventHandler(delegate { 
                            textmessage.Text += Environment.NewLine + "連線終止";
                            textmessage.AppendText("..." + "\r\n");
                            myTcpListener.Stop();
                         }));
                         break;
                    }
                    
                    if (mySocket.Available >= 1)
                    {
                        sw.Restart();
                        byte[] myBufferBytes = new byte[mySocket.Available];
                        
                        int dataLength = mySocket.Receive(myBufferBytes); //取得用戶端寫入的資料
                        
                        XYZrobot.XYZrobot.Button temp = XYZrobot.XYZrobot.Button.Ping;
                        for (int i = dataLength-1; i >= 0; i--)
                        {
                            if ( (XYZrobot.XYZrobot.Button)myBufferBytes[i]!=XYZrobot.XYZrobot.Button.Ping)
                            {
                                temp = (XYZrobot.XYZrobot.Button)myBufferBytes[dataLength - 1];
                                break;
                            }
                        }
                        robotarm.btn = temp;
                        
                       
                        this.Invoke(new EventHandler(delegate {
                            if (textmessage.Text.Length>100)
                            {
                                int ed = textmessage.Text.IndexOf('\n',50);
                                textmessage.Text = textmessage.Text.Remove(0, ed);

                            } 

                            textmessage.Text += Environment.NewLine + System.DateTime.Now.ToString() + Environment.NewLine + "接收到的資料長度 = " + dataLength.ToString();
                            textmessage.Text += Environment.NewLine + "取出用戶端寫入網路資料流的資料內容" + Environment.NewLine + string.Join(" ", myBufferBytes);
                            textmessage.AppendText("..." + "\r\n");
                        }));
                        mySocket.Send(myBufferBytes, myBufferBytes.Length, 0);//將接收到的資料回傳給用戶端(Clinet)
                        myBufferBytes = null;
                    }
                }
                catch (System.Net.Sockets.SocketException eh)
                {
                     this.Invoke(new EventHandler(delegate { 
                        textmessage.Text += Environment.NewLine + "連線終止";
                        textmessage.AppendText("..." + "\r\n");
                        myTcpListener.Stop();
                     }));
                     break;
                }
                Thread.Sleep(10);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }


    }
}
