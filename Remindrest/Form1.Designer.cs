namespace Remindrest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.休息间隔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小时ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.休息时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分钟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分钟ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1287, 940);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(0, 938);
            this.progressBar1.Maximum = 600;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(1287, 5);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.休息间隔ToolStripMenuItem,
            this.休息时间ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 休息间隔ToolStripMenuItem
            // 
            this.休息间隔ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.小时ToolStripMenuItem,
            this.小时ToolStripMenuItem1});
            this.休息间隔ToolStripMenuItem.Name = "休息间隔ToolStripMenuItem";
            this.休息间隔ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.休息间隔ToolStripMenuItem.Text = "休息间隔";
            // 
            // 小时ToolStripMenuItem
            // 
            this.小时ToolStripMenuItem.Name = "小时ToolStripMenuItem";
            this.小时ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.小时ToolStripMenuItem.Text = "1 小时";
            this.小时ToolStripMenuItem.Click += new System.EventHandler(this.小时ToolStripMenuItem_Click);
            // 
            // 小时ToolStripMenuItem1
            // 
            this.小时ToolStripMenuItem1.Name = "小时ToolStripMenuItem1";
            this.小时ToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.小时ToolStripMenuItem1.Text = " 2 小时";
            this.小时ToolStripMenuItem1.Click += new System.EventHandler(this.小时ToolStripMenuItem1_Click);
            // 
            // 休息时间ToolStripMenuItem
            // 
            this.休息时间ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.分钟ToolStripMenuItem,
            this.分钟ToolStripMenuItem1});
            this.休息时间ToolStripMenuItem.Name = "休息时间ToolStripMenuItem";
            this.休息时间ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.休息时间ToolStripMenuItem.Text = "休息时间";
            // 
            // 分钟ToolStripMenuItem
            // 
            this.分钟ToolStripMenuItem.Name = "分钟ToolStripMenuItem";
            this.分钟ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.分钟ToolStripMenuItem.Text = "3 分钟";
            this.分钟ToolStripMenuItem.Click += new System.EventHandler(this.分钟ToolStripMenuItem_Click);
            // 
            // 分钟ToolStripMenuItem1
            // 
            this.分钟ToolStripMenuItem1.Name = "分钟ToolStripMenuItem1";
            this.分钟ToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.分钟ToolStripMenuItem1.Text = "5 分钟";
            this.分钟ToolStripMenuItem1.Click += new System.EventHandler(this.分钟ToolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HealthRemind";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 26);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 941);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1287, 980);
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.Text = ".";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 休息间隔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小时ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小时ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 休息时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分钟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分钟ToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

