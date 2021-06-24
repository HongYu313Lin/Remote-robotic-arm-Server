using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZrobot
{
    public partial class XYZrobot : Form
    {
        public class Robot
        {
            byte RCU_mask_release = 0x0010;
            byte RCU_mask_BT = 0x0020;
            byte RCU_mask_power = 0x0040;
            byte RCU_mask_L1 = 0x0001;
            byte RCU_mask_L2 = 0x0002;
            byte RCU_mask_L3 = 0x0004;
            byte RCU_mask_R1 = 0x0001;
            byte RCU_mask_R2 = 0x0002;
            byte RCU_mask_R3 = 0x0004;
            byte RCU_packet_header_address = 0x00;
            byte RCU_packet_LJ_X_address = 0x01;
            byte RCU_packet_LJ_Y_address = 0x02;
            byte RCU_packet_RJ_X_address = 0x03;
            byte RCU_packet_RJ_Y_address = 0x04;
            public Robot()
            {

            }
            public byte[] Ping()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 128, RCU_mask_BT, 128 };
                return temp;
            }
            public byte[] Release()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 128, RCU_mask_release, 128 };

                return temp;
            }
            public byte[] Power()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 128, RCU_mask_power, 128 };

                return temp;
            }
            public byte[] L1()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 128, 128, RCU_mask_L1 };

                return temp;
            }
            public byte[] L2()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 128, 128, RCU_mask_L2 };

                return temp;
            }
            public byte[] L3()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 128, 128, RCU_mask_L3 };

                return temp;
            }
            public byte[] R1()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 128, RCU_mask_R1, 128 };

                return temp;
            }
            public byte[] R2()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 128, RCU_mask_R2, 128 };

                return temp;
            }
            public byte[] R3()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 128, RCU_mask_R3, 128 };

                return temp;
            }
            public byte[] LJRS()//LeftJoystick_Rightside
            {
                byte[] temp = new byte[7] { 0, 192, 128, 128, 128, 128, 128 };

                return temp;
            }
            public byte[] LJLS()
            {
                byte[] temp = new byte[7] { 0, 64, 128, 128, 128, 128, 128 };

                return temp;
            }
            public byte[] LJU()//LeftJoystick_Rightside
            {
                byte[] temp = new byte[7] { 0, 128, 192, 128, 128, 128, 128 };

                return temp;
            }
            public byte[] LJD()
            {
                byte[] temp = new byte[7] { 0, 128, 64, 128, 128, 128, 128 };

                return temp;
            }

            public byte[] RJRS()//LeftJoystick_Rightside
            {
                byte[] temp = new byte[7] { 0, 128, 128, 192, 128, 128, 128 };

                return temp;
            }
            public byte[] RJLS()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 64, 128, 128, 128 };

                return temp;
            }
            public byte[] RJU()//LeftJoystick_Rightside
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 192, 128, 128 };

                return temp;
            }
            public byte[] RJD()
            {
                byte[] temp = new byte[7] { 0, 128, 128, 128, 64, 128, 128 };

                return temp;
            }
        }

        Robot arm;
        public enum Button
        {
            Ping, Release, Power, L1, L2, L3, R1, R2, R3, LJLS, LJRS, LJU, LJD, RJLS, RJRS, RJU, RJD
        }
        public Button btn = Button.Ping;
        Stopwatch sw;
        public XYZrobot()
        {
            InitializeComponent();
            arm = new Robot();
            sw = new Stopwatch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = "COM11";
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
            }
            catch (Exception)
            {

            }
            backgroundWorker1.RunWorkerAsync();
        }

        private void btn_release_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.Release;
        }

        private void btn_Power_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.Power;
        }

        private void btn_L1_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.L1;
        }

        private void btn_L2_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.L2;
        }
        private void btn_L3_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.L3;
        }

        private void btn_R3_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.R3;
        }

        private void btn_R2_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.R2;
        }

        private void btn_R1_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.R1;
        }

        private void btn_LL_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.LJLS;
        }

        private void btn_LU_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.LJU;
        }

        private void btn_LD_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.LJD;
        }

        private void btn_LR_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.LJRS;
        }

        private void btn_RU_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.RJU;
        }

        private void btn_RD_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.RJD;
        }

        private void btn_RL_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.RJLS;
        }

        private void btn_RR_Click(object sender, EventArgs e)
        {
            sw.Restart();
            btn = Button.RJRS;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sw.Start();
            int delay = 100;
            while (true)
            {
                if (serialPort1.IsOpen)
                {

                    switch (btn)
                    {
                        case Button.Ping:
                            delay = 100;

                            break;
                        case Button.Release:
                            delay = 100;
                            serialPort1.Write(arm.Release(), 0, 7);
                            break;
                        case Button.Power:
                            delay = 100;
                            serialPort1.Write(arm.Power(), 0, 7);
                            break;
                        case Button.L1:
                            delay = 100;
                            serialPort1.Write(arm.L1(), 0, 7);
                            break;
                        case Button.L2:
                            delay = 100;
                            serialPort1.Write(arm.L2(), 0, 7);
                            break;
                        case Button.L3:
                            delay = 100;
                            serialPort1.Write(arm.L3(), 0, 7);
                            break;
                        case Button.R1:
                            delay = 100;
                            serialPort1.Write(arm.R1(), 0, 7);
                            break;
                        case Button.R2:
                            delay = 100;
                            serialPort1.Write(arm.R2(), 0, 7);
                            break;
                        case Button.R3:
                            delay = 100;
                            serialPort1.Write(arm.R3(), 0, 7);
                            break;
                        case Button.LJLS:
                            delay = 100;
                            serialPort1.Write(arm.LJLS(), 0, 7);
                            break;
                        case Button.LJRS:
                            delay = 100;
                            serialPort1.Write(arm.LJRS(), 0, 7);
                            break;
                        case Button.LJU:
                            delay = 100;
                            serialPort1.Write(arm.LJU(), 0, 7);
                            break;
                        case Button.LJD:
                            delay = 100;
                            serialPort1.Write(arm.LJD(), 0, 7);
                            break;
                        case Button.RJLS:
                            delay = 100;
                            serialPort1.Write(arm.RJLS(), 0, 7);
                            break;
                        case Button.RJRS:
                            delay = 100;
                            serialPort1.Write(arm.RJRS(), 0, 7);
                            break;
                        case Button.RJU:
                            delay = 100;
                            serialPort1.Write(arm.RJU(), 0, 7);
                            break;
                        case Button.RJD:
                            delay = 100;
                            serialPort1.Write(arm.RJD(), 0, 7);

                            break;
                        default:
                            break;
                    }

                    if (sw.Elapsed.TotalMilliseconds >= delay)
                    {
                        sw.Restart();
                        btn = Button.Ping;
                        serialPort1.Write(arm.Ping(), 0, 7);
                        Thread.Sleep(10);
                    }
                }
                Thread.Sleep(10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
