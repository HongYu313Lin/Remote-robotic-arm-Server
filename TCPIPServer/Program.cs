using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TCPIPServer
{
    /// <summary>
    /// Ph.D. Program in Engineering Science and Technology, College of Engineering
    /// National Kaohsiung University of Science and Technology
    /// 作者:林紘宇 Hong-Yu,Lin
    /// 正在國立高雄科技大學工程科技研究所攻讀博士學位
    /// </summary>
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TCP());
        }
    }
}
