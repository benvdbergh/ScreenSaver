namespace ScreenSaver
{
    partial class ScreenSaverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSaverForm));
            this.timeLbl = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.emailLbl = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notificationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.emailPnl = new System.Windows.Forms.Panel();
            this.mailIcon = new System.Windows.Forms.Panel();
            this.nextMeetingPanel = new System.Windows.Forms.Panel();
            this.nextMeetingLbl = new System.Windows.Forms.Label();
            this.calendarIcon = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.notificationPanel.SuspendLayout();
            this.emailPnl.SuspendLayout();
            this.nextMeetingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Minimal", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Location = new System.Drawing.Point(290, 281);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(526, 96);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "00 : 00 : 00";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 400;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // emailLbl
            // 
            this.emailLbl.Font = new System.Drawing.Font("Minimal", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(64, 12);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(32, 40);
            this.emailLbl.TabIndex = 1;
            this.emailLbl.Text = "0";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.notificationPanel);
            this.mainPanel.Controls.Add(this.timeLbl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1118, 733);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 282);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // notificationPanel
            // 
            this.notificationPanel.AutoSize = true;
            this.notificationPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.notificationPanel.Controls.Add(this.emailPnl);
            this.notificationPanel.Controls.Add(this.nextMeetingPanel);
            this.notificationPanel.ForeColor = System.Drawing.Color.Transparent;
            this.notificationPanel.Location = new System.Drawing.Point(423, 414);
            this.notificationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(237, 64);
            this.notificationPanel.TabIndex = 3;
            // 
            // emailPnl
            // 
            this.emailPnl.Controls.Add(this.mailIcon);
            this.emailPnl.Controls.Add(this.emailLbl);
            this.emailPnl.Location = new System.Drawing.Point(2, 2);
            this.emailPnl.Margin = new System.Windows.Forms.Padding(2);
            this.emailPnl.Name = "emailPnl";
            this.emailPnl.Size = new System.Drawing.Size(124, 59);
            this.emailPnl.TabIndex = 2;
            // 
            // mailIcon
            // 
            this.mailIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mailIcon.BackgroundImage")));
            this.mailIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mailIcon.Location = new System.Drawing.Point(10, 12);
            this.mailIcon.Margin = new System.Windows.Forms.Padding(2);
            this.mailIcon.Name = "mailIcon";
            this.mailIcon.Size = new System.Drawing.Size(50, 40);
            this.mailIcon.TabIndex = 2;
            // 
            // nextMeetingPanel
            // 
            this.nextMeetingPanel.AutoSize = true;
            this.nextMeetingPanel.Controls.Add(this.nextMeetingLbl);
            this.nextMeetingPanel.Controls.Add(this.calendarIcon);
            this.nextMeetingPanel.Location = new System.Drawing.Point(130, 2);
            this.nextMeetingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.nextMeetingPanel.Name = "nextMeetingPanel";
            this.nextMeetingPanel.Size = new System.Drawing.Size(105, 60);
            this.nextMeetingPanel.TabIndex = 3;
            // 
            // nextMeetingLbl
            // 
            this.nextMeetingLbl.AutoSize = true;
            this.nextMeetingLbl.BackColor = System.Drawing.Color.Transparent;
            this.nextMeetingLbl.Font = new System.Drawing.Font("Minimal", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMeetingLbl.ForeColor = System.Drawing.Color.White;
            this.nextMeetingLbl.Location = new System.Drawing.Point(60, 12);
            this.nextMeetingLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nextMeetingLbl.Name = "nextMeetingLbl";
            this.nextMeetingLbl.Size = new System.Drawing.Size(43, 48);
            this.nextMeetingLbl.TabIndex = 3;
            this.nextMeetingLbl.Text = "0";
            this.nextMeetingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calendarIcon
            // 
            this.calendarIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calendarIcon.BackgroundImage")));
            this.calendarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.calendarIcon.Location = new System.Drawing.Point(2, 12);
            this.calendarIcon.Margin = new System.Windows.Forms.Padding(2);
            this.calendarIcon.Name = "calendarIcon";
            this.calendarIcon.Size = new System.Drawing.Size(53, 40);
            this.calendarIcon.TabIndex = 3;
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1118, 733);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.emailPnl.ResumeLayout(false);
            this.nextMeetingPanel.ResumeLayout(false);
            this.nextMeetingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel emailPnl;
        private System.Windows.Forms.Panel mailIcon;
        private System.Windows.Forms.FlowLayoutPanel notificationPanel;
        private System.Windows.Forms.Panel nextMeetingPanel;
        private System.Windows.Forms.Panel calendarIcon;
        private System.Windows.Forms.Label nextMeetingLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

