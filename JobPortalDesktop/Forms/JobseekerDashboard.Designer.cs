namespace JobPortalDesktop.Forms
{
    partial class JobseekerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobseekerDashboard));
            navBarPanel1 = new Panel();
            findJobsBtn = new Button();
            navBarContainerPanel = new Panel();
            navBarPanel6 = new Panel();
            logOutBtn = new Button();
            navBarPanel5 = new Panel();
            appliedJobsBtn = new Button();
            navBarPanel4 = new Panel();
            savedJobsBtn = new Button();
            navBarPanel3 = new Panel();
            accountBtn = new Button();
            navBarPanel2 = new Panel();
            profileBtn = new Button();
            containerPanel = new Panel();
            navBarPanel1.SuspendLayout();
            navBarContainerPanel.SuspendLayout();
            navBarPanel6.SuspendLayout();
            navBarPanel5.SuspendLayout();
            navBarPanel4.SuspendLayout();
            navBarPanel3.SuspendLayout();
            navBarPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // navBarPanel1
            // 
            navBarPanel1.BorderStyle = BorderStyle.FixedSingle;
            navBarPanel1.Controls.Add(findJobsBtn);
            navBarPanel1.Dock = DockStyle.Top;
            navBarPanel1.Location = new Point(0, 0);
            navBarPanel1.Margin = new Padding(4);
            navBarPanel1.Name = "navBarPanel1";
            navBarPanel1.Size = new Size(199, 80);
            navBarPanel1.TabIndex = 0;
            // 
            // findJobsBtn
            // 
            findJobsBtn.Cursor = Cursors.Hand;
            findJobsBtn.Dock = DockStyle.Fill;
            findJobsBtn.FlatAppearance.BorderSize = 0;
            findJobsBtn.FlatStyle = FlatStyle.Flat;
            findJobsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            findJobsBtn.ForeColor = Color.FromArgb(255, 190, 121);
            findJobsBtn.Image = Properties.Resources.search_icon;
            findJobsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            findJobsBtn.Location = new Point(0, 0);
            findJobsBtn.Margin = new Padding(4);
            findJobsBtn.Name = "findJobsBtn";
            findJobsBtn.Padding = new Padding(30, 0, 0, 0);
            findJobsBtn.Size = new Size(197, 78);
            findJobsBtn.TabIndex = 0;
            findJobsBtn.Text = " Find jobs";
            findJobsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            findJobsBtn.UseVisualStyleBackColor = true;
            findJobsBtn.Click += findJobsBtn_Click;
            // 
            // navBarContainerPanel
            // 
            navBarContainerPanel.BackColor = Color.FromArgb(55, 65, 81);
            navBarContainerPanel.Controls.Add(navBarPanel6);
            navBarContainerPanel.Controls.Add(navBarPanel5);
            navBarContainerPanel.Controls.Add(navBarPanel4);
            navBarContainerPanel.Controls.Add(navBarPanel3);
            navBarContainerPanel.Controls.Add(navBarPanel2);
            navBarContainerPanel.Controls.Add(navBarPanel1);
            navBarContainerPanel.Dock = DockStyle.Left;
            navBarContainerPanel.Location = new Point(0, 0);
            navBarContainerPanel.Name = "navBarContainerPanel";
            navBarContainerPanel.Size = new Size(199, 661);
            navBarContainerPanel.TabIndex = 1;
            // 
            // navBarPanel6
            // 
            navBarPanel6.BorderStyle = BorderStyle.FixedSingle;
            navBarPanel6.Controls.Add(logOutBtn);
            navBarPanel6.Dock = DockStyle.Bottom;
            navBarPanel6.Location = new Point(0, 581);
            navBarPanel6.Name = "navBarPanel6";
            navBarPanel6.Size = new Size(199, 80);
            navBarPanel6.TabIndex = 5;
            // 
            // logOutBtn
            // 
            logOutBtn.Cursor = Cursors.Hand;
            logOutBtn.Dock = DockStyle.Fill;
            logOutBtn.FlatAppearance.BorderSize = 0;
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logOutBtn.ForeColor = Color.FromArgb(255, 190, 121);
            logOutBtn.Image = Properties.Resources.log_out_icon;
            logOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logOutBtn.Location = new Point(0, 0);
            logOutBtn.Margin = new Padding(4);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Padding = new Padding(30, 0, 0, 0);
            logOutBtn.Size = new Size(197, 78);
            logOutBtn.TabIndex = 1;
            logOutBtn.Text = " Log out";
            logOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logOutBtn.UseVisualStyleBackColor = true;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // navBarPanel5
            // 
            navBarPanel5.BorderStyle = BorderStyle.FixedSingle;
            navBarPanel5.Controls.Add(appliedJobsBtn);
            navBarPanel5.Dock = DockStyle.Top;
            navBarPanel5.Location = new Point(0, 320);
            navBarPanel5.Margin = new Padding(4);
            navBarPanel5.Name = "navBarPanel5";
            navBarPanel5.Size = new Size(199, 80);
            navBarPanel5.TabIndex = 4;
            // 
            // appliedJobsBtn
            // 
            appliedJobsBtn.Cursor = Cursors.Hand;
            appliedJobsBtn.Dock = DockStyle.Fill;
            appliedJobsBtn.FlatAppearance.BorderColor = SystemColors.GrayText;
            appliedJobsBtn.FlatAppearance.BorderSize = 0;
            appliedJobsBtn.FlatStyle = FlatStyle.Flat;
            appliedJobsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            appliedJobsBtn.ForeColor = Color.FromArgb(255, 190, 121);
            appliedJobsBtn.Image = Properties.Resources.applied_jobs_icon;
            appliedJobsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            appliedJobsBtn.Location = new Point(0, 0);
            appliedJobsBtn.Margin = new Padding(4);
            appliedJobsBtn.Name = "appliedJobsBtn";
            appliedJobsBtn.Padding = new Padding(30, 0, 0, 0);
            appliedJobsBtn.Size = new Size(197, 78);
            appliedJobsBtn.TabIndex = 0;
            appliedJobsBtn.Text = " Applied Jobs";
            appliedJobsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            appliedJobsBtn.UseVisualStyleBackColor = true;
            appliedJobsBtn.Click += appliedJobsBtn_Click;
            // 
            // navBarPanel4
            // 
            navBarPanel4.BorderStyle = BorderStyle.FixedSingle;
            navBarPanel4.Controls.Add(savedJobsBtn);
            navBarPanel4.Dock = DockStyle.Top;
            navBarPanel4.Location = new Point(0, 240);
            navBarPanel4.Margin = new Padding(4);
            navBarPanel4.Name = "navBarPanel4";
            navBarPanel4.Size = new Size(199, 80);
            navBarPanel4.TabIndex = 3;
            // 
            // savedJobsBtn
            // 
            savedJobsBtn.Cursor = Cursors.Hand;
            savedJobsBtn.Dock = DockStyle.Fill;
            savedJobsBtn.FlatAppearance.BorderSize = 0;
            savedJobsBtn.FlatStyle = FlatStyle.Flat;
            savedJobsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            savedJobsBtn.ForeColor = Color.FromArgb(255, 190, 121);
            savedJobsBtn.Image = Properties.Resources.saved_jobs_icon;
            savedJobsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            savedJobsBtn.Location = new Point(0, 0);
            savedJobsBtn.Margin = new Padding(4);
            savedJobsBtn.Name = "savedJobsBtn";
            savedJobsBtn.Padding = new Padding(30, 0, 0, 0);
            savedJobsBtn.Size = new Size(197, 78);
            savedJobsBtn.TabIndex = 0;
            savedJobsBtn.Text = " Saved Jobs";
            savedJobsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            savedJobsBtn.UseVisualStyleBackColor = true;
            savedJobsBtn.Click += savedJobsBtn_Click;
            // 
            // navBarPanel3
            // 
            navBarPanel3.BorderStyle = BorderStyle.FixedSingle;
            navBarPanel3.Controls.Add(accountBtn);
            navBarPanel3.Dock = DockStyle.Top;
            navBarPanel3.Location = new Point(0, 160);
            navBarPanel3.Margin = new Padding(4);
            navBarPanel3.Name = "navBarPanel3";
            navBarPanel3.Size = new Size(199, 80);
            navBarPanel3.TabIndex = 2;
            // 
            // accountBtn
            // 
            accountBtn.Cursor = Cursors.Hand;
            accountBtn.Dock = DockStyle.Fill;
            accountBtn.FlatAppearance.BorderSize = 0;
            accountBtn.FlatStyle = FlatStyle.Flat;
            accountBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accountBtn.ForeColor = Color.FromArgb(255, 190, 121);
            accountBtn.Image = Properties.Resources.settings_icon;
            accountBtn.ImageAlign = ContentAlignment.MiddleLeft;
            accountBtn.Location = new Point(0, 0);
            accountBtn.Margin = new Padding(4);
            accountBtn.Name = "accountBtn";
            accountBtn.Padding = new Padding(30, 0, 0, 0);
            accountBtn.Size = new Size(197, 78);
            accountBtn.TabIndex = 0;
            accountBtn.Text = " Account";
            accountBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            accountBtn.UseVisualStyleBackColor = true;
            accountBtn.Click += accountBtn_Click;
            // 
            // navBarPanel2
            // 
            navBarPanel2.BorderStyle = BorderStyle.FixedSingle;
            navBarPanel2.Controls.Add(profileBtn);
            navBarPanel2.Dock = DockStyle.Top;
            navBarPanel2.Location = new Point(0, 80);
            navBarPanel2.Margin = new Padding(4);
            navBarPanel2.Name = "navBarPanel2";
            navBarPanel2.Size = new Size(199, 80);
            navBarPanel2.TabIndex = 1;
            // 
            // profileBtn
            // 
            profileBtn.Cursor = Cursors.Hand;
            profileBtn.Dock = DockStyle.Fill;
            profileBtn.FlatAppearance.BorderSize = 0;
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            profileBtn.ForeColor = Color.FromArgb(255, 190, 121);
            profileBtn.Image = Properties.Resources.profile_icon;
            profileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            profileBtn.Location = new Point(0, 0);
            profileBtn.Margin = new Padding(4);
            profileBtn.Name = "profileBtn";
            profileBtn.Padding = new Padding(30, 0, 0, 0);
            profileBtn.Size = new Size(197, 78);
            profileBtn.TabIndex = 0;
            profileBtn.Text = " Profile";
            profileBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // containerPanel
            // 
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(199, 0);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(985, 661);
            containerPanel.TabIndex = 2;
            // 
            // JobseekerDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(containerPanel);
            Controls.Add(navBarContainerPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1200, 700);
            Name = "JobseekerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            navBarPanel1.ResumeLayout(false);
            navBarContainerPanel.ResumeLayout(false);
            navBarPanel6.ResumeLayout(false);
            navBarPanel5.ResumeLayout(false);
            navBarPanel4.ResumeLayout(false);
            navBarPanel3.ResumeLayout(false);
            navBarPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel containerPanel;
        private Button findJobsBtn;
        private Panel panel2;
        private Panel panel5;
        private Button savedJobsBtn;
        private Panel panel4;
        private Button accountBtn;
        private Panel panel3;
        private Button profileBtn;
        private Panel navBarPanel1;
        private Panel navBarContainerPanel;
        private Panel navBarPanel5;
        private Button appliedJobsBtn;
        private Panel navBarPanel4;
        private Panel navBarPanel3;
        private Panel navBarPanel2;
        private Panel navBarPanel6;
        private Button logOutBtn;
    }
}