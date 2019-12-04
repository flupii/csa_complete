using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotClient
{
    public partial class frmMain : Form
    {
        private const string SRVIP = "10.192.20.230";
        private const int SRVPORT = 7300;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(tbFile.Text))
            {
                string content = sr.ReadToEnd();
                string[] scontent = content.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                TcpClient client = new TcpClient(SRVIP, SRVPORT);
                using (StreamWriter sw = new StreamWriter(client.GetStream()))
                {
                    foreach (var item in scontent)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Flush();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFile.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbFile.Text = dialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:8080");
        }
    }
}
