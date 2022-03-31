using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Remindrest
{
    public partial class Form1 : Form
    {
        DateTime cur;
        string time2;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\11769\\source\\repos\\Remindrest\\Remindrest\\dsa.png");
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.ContextMenuStrip = contextMenuStrip2;
            cur = DateTime.Now;
            time2 = "00:30:00";
            this.Size = MinimumSize;
            timer1.Start();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.TopMost = false;
            cur = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now =  DateTime.Now;
            TimeSpan timeSpan = TimeSpan.Parse(time2);
            if(now > cur + timeSpan)
            {
                this.Location = new Point(316,50);
                this.TopMost = true;
                this.Size = MaximumSize;
                timer2.Start();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value + 2 < progressBar1.Maximum)
            {
                progressBar1.Value += 2;
            }
            else
            {
                progressBar1.Value = 0;
                this.WindowState = FormWindowState.Minimized;
                this.TopMost = false;
                cur = DateTime.Now;
                timer2.Stop();
            }
            
        }

        private void 小时ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            time2 = "00:01:00";
        }

        private void 小时ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            time2 = "00:02:00";
            progressBar1.Maximum = 2 * 600;
        }

        private void 分钟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 3 * 600;
        }

        private void 分钟ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 5 * 600;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
