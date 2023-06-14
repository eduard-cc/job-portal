namespace JobPortalDesktop.Forms
{
    partial class UserAccount
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
            deleteAccountPanel = new Panel();
            deleteAccountBtn = new Label();
            deleteAccountDescriptionLbl = new Label();
            deleteAccountLbl = new Label();
            changePasswordPanel = new Panel();
            successMessagePasswordLbl = new Label();
            ChangePasswordBtn = new Label();
            changePasswordLbl = new Label();
            changeEmailPanel = new Panel();
            successMessageEmailLbl = new Label();
            userEmailLbl = new Label();
            changeEmailBtn = new Label();
            changeEmailLbl = new Label();
            userAccountContainerPanel = new Panel();
            dummyPanel2 = new Panel();
            dummyPanel1 = new Panel();
            deleteAccountPanel.SuspendLayout();
            changePasswordPanel.SuspendLayout();
            changeEmailPanel.SuspendLayout();
            userAccountContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // deleteAccountPanel
            // 
            deleteAccountPanel.BackColor = Color.FromArgb(250, 248, 251);
            deleteAccountPanel.BorderStyle = BorderStyle.FixedSingle;
            deleteAccountPanel.Controls.Add(deleteAccountBtn);
            deleteAccountPanel.Controls.Add(deleteAccountDescriptionLbl);
            deleteAccountPanel.Controls.Add(deleteAccountLbl);
            deleteAccountPanel.Dock = DockStyle.Top;
            deleteAccountPanel.Location = new Point(120, 354);
            deleteAccountPanel.Margin = new Padding(3, 20, 3, 3);
            deleteAccountPanel.Name = "deleteAccountPanel";
            deleteAccountPanel.Padding = new Padding(20);
            deleteAccountPanel.Size = new Size(645, 148);
            deleteAccountPanel.TabIndex = 0;
            // 
            // deleteAccountBtn
            // 
            deleteAccountBtn.AutoSize = true;
            deleteAccountBtn.Cursor = Cursors.Hand;
            deleteAccountBtn.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            deleteAccountBtn.ForeColor = Color.Navy;
            deleteAccountBtn.Location = new Point(23, 105);
            deleteAccountBtn.Name = "deleteAccountBtn";
            deleteAccountBtn.Size = new Size(112, 21);
            deleteAccountBtn.TabIndex = 3;
            deleteAccountBtn.Text = "Delete account";
            deleteAccountBtn.Click += deleteAccountBtn_Click;
            // 
            // deleteAccountDescriptionLbl
            // 
            deleteAccountDescriptionLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deleteAccountDescriptionLbl.ForeColor = Color.FromArgb(64, 64, 64);
            deleteAccountDescriptionLbl.Location = new Point(23, 41);
            deleteAccountDescriptionLbl.Name = "deleteAccountDescriptionLbl";
            deleteAccountDescriptionLbl.Size = new Size(597, 64);
            deleteAccountDescriptionLbl.TabIndex = 3;
            deleteAccountDescriptionLbl.Text = "Permanently remove all data associated with your account, including any job listings or applications made.\r\n";
            deleteAccountDescriptionLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // deleteAccountLbl
            // 
            deleteAccountLbl.AutoSize = true;
            deleteAccountLbl.Location = new Point(23, 20);
            deleteAccountLbl.Name = "deleteAccountLbl";
            deleteAccountLbl.Size = new Size(148, 21);
            deleteAccountLbl.TabIndex = 2;
            deleteAccountLbl.Text = "Delete your account";
            // 
            // changePasswordPanel
            // 
            changePasswordPanel.BackColor = Color.FromArgb(250, 248, 251);
            changePasswordPanel.BorderStyle = BorderStyle.FixedSingle;
            changePasswordPanel.Controls.Add(successMessagePasswordLbl);
            changePasswordPanel.Controls.Add(ChangePasswordBtn);
            changePasswordPanel.Controls.Add(changePasswordLbl);
            changePasswordPanel.Dock = DockStyle.Top;
            changePasswordPanel.Location = new Point(120, 187);
            changePasswordPanel.Margin = new Padding(0);
            changePasswordPanel.Name = "changePasswordPanel";
            changePasswordPanel.Padding = new Padding(20);
            changePasswordPanel.Size = new Size(645, 147);
            changePasswordPanel.TabIndex = 1;
            // 
            // successMessagePasswordLbl
            // 
            successMessagePasswordLbl.AutoSize = true;
            successMessagePasswordLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            successMessagePasswordLbl.ForeColor = Color.FromArgb(25, 128, 80);
            successMessagePasswordLbl.Location = new Point(163, 104);
            successMessagePasswordLbl.Name = "successMessagePasswordLbl";
            successMessagePasswordLbl.Size = new Size(132, 21);
            successMessagePasswordLbl.TabIndex = 7;
            successMessagePasswordLbl.Text = "successMessage";
            successMessagePasswordLbl.Visible = false;
            // 
            // ChangePasswordBtn
            // 
            ChangePasswordBtn.AutoSize = true;
            ChangePasswordBtn.Cursor = Cursors.Hand;
            ChangePasswordBtn.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            ChangePasswordBtn.ForeColor = Color.Navy;
            ChangePasswordBtn.Location = new Point(23, 104);
            ChangePasswordBtn.Name = "ChangePasswordBtn";
            ChangePasswordBtn.Size = new Size(134, 21);
            ChangePasswordBtn.TabIndex = 2;
            ChangePasswordBtn.Text = "Change password";
            ChangePasswordBtn.Click += ChangePasswordBtn_Click;
            // 
            // changePasswordLbl
            // 
            changePasswordLbl.AutoSize = true;
            changePasswordLbl.Location = new Point(23, 20);
            changePasswordLbl.Name = "changePasswordLbl";
            changePasswordLbl.Size = new Size(170, 21);
            changePasswordLbl.TabIndex = 1;
            changePasswordLbl.Text = "Change your password";
            // 
            // changeEmailPanel
            // 
            changeEmailPanel.BackColor = Color.FromArgb(250, 248, 251);
            changeEmailPanel.BorderStyle = BorderStyle.FixedSingle;
            changeEmailPanel.Controls.Add(successMessageEmailLbl);
            changeEmailPanel.Controls.Add(userEmailLbl);
            changeEmailPanel.Controls.Add(changeEmailBtn);
            changeEmailPanel.Controls.Add(changeEmailLbl);
            changeEmailPanel.Dock = DockStyle.Top;
            changeEmailPanel.Location = new Point(120, 20);
            changeEmailPanel.Name = "changeEmailPanel";
            changeEmailPanel.Padding = new Padding(20);
            changeEmailPanel.Size = new Size(645, 147);
            changeEmailPanel.TabIndex = 2;
            // 
            // successMessageEmailLbl
            // 
            successMessageEmailLbl.AutoSize = true;
            successMessageEmailLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            successMessageEmailLbl.ForeColor = Color.FromArgb(25, 128, 80);
            successMessageEmailLbl.Location = new Point(134, 104);
            successMessageEmailLbl.Name = "successMessageEmailLbl";
            successMessageEmailLbl.Size = new Size(132, 21);
            successMessageEmailLbl.TabIndex = 6;
            successMessageEmailLbl.Text = "successMessage";
            successMessageEmailLbl.Visible = false;
            // 
            // userEmailLbl
            // 
            userEmailLbl.Location = new Point(23, 41);
            userEmailLbl.Name = "userEmailLbl";
            userEmailLbl.Size = new Size(797, 63);
            userEmailLbl.TabIndex = 5;
            userEmailLbl.Text = "{user email}";
            userEmailLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // changeEmailBtn
            // 
            changeEmailBtn.AutoSize = true;
            changeEmailBtn.Cursor = Cursors.Hand;
            changeEmailBtn.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            changeEmailBtn.ForeColor = Color.Navy;
            changeEmailBtn.Location = new Point(23, 104);
            changeEmailBtn.Name = "changeEmailBtn";
            changeEmailBtn.Size = new Size(105, 21);
            changeEmailBtn.TabIndex = 1;
            changeEmailBtn.Text = "Change email";
            changeEmailBtn.Click += changeEmailBtn_Click;
            // 
            // changeEmailLbl
            // 
            changeEmailLbl.AutoSize = true;
            changeEmailLbl.Location = new Point(23, 20);
            changeEmailLbl.Name = "changeEmailLbl";
            changeEmailLbl.Size = new Size(141, 21);
            changeEmailLbl.TabIndex = 0;
            changeEmailLbl.Text = "Change your email";
            // 
            // userAccountContainerPanel
            // 
            userAccountContainerPanel.AutoScroll = true;
            userAccountContainerPanel.Controls.Add(deleteAccountPanel);
            userAccountContainerPanel.Controls.Add(dummyPanel2);
            userAccountContainerPanel.Controls.Add(changePasswordPanel);
            userAccountContainerPanel.Controls.Add(dummyPanel1);
            userAccountContainerPanel.Controls.Add(changeEmailPanel);
            userAccountContainerPanel.Dock = DockStyle.Fill;
            userAccountContainerPanel.Location = new Point(0, 0);
            userAccountContainerPanel.Margin = new Padding(20);
            userAccountContainerPanel.Name = "userAccountContainerPanel";
            userAccountContainerPanel.Padding = new Padding(120, 20, 120, 20);
            userAccountContainerPanel.Size = new Size(885, 525);
            userAccountContainerPanel.TabIndex = 3;
            // 
            // dummyPanel2
            // 
            dummyPanel2.Dock = DockStyle.Top;
            dummyPanel2.Location = new Point(120, 334);
            dummyPanel2.Name = "dummyPanel2";
            dummyPanel2.Size = new Size(645, 20);
            dummyPanel2.TabIndex = 4;
            // 
            // dummyPanel1
            // 
            dummyPanel1.Dock = DockStyle.Top;
            dummyPanel1.Location = new Point(120, 167);
            dummyPanel1.Name = "dummyPanel1";
            dummyPanel1.Size = new Size(645, 20);
            dummyPanel1.TabIndex = 3;
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 525);
            Controls.Add(userAccountContainerPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "UserAccount";
            Text = "JobseekerAccount";
            Load += UserAccount_Load;
            deleteAccountPanel.ResumeLayout(false);
            deleteAccountPanel.PerformLayout();
            changePasswordPanel.ResumeLayout(false);
            changePasswordPanel.PerformLayout();
            changeEmailPanel.ResumeLayout(false);
            changeEmailPanel.PerformLayout();
            userAccountContainerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel deleteAccountPanel;
        private Label deleteAccountBtn;
        private Label deleteAccountDescriptionLbl;
        private Label deleteAccountLbl;
        private Panel changePasswordPanel;
        private Label ChangePasswordBtn;
        private Label changePasswordLbl;
        private Panel changeEmailPanel;
        private Label userEmailLbl;
        private Label changeEmailBtn;
        private Label changeEmailLbl;
        private Panel userAccountContainerPanel;
        private Panel dummyPanel2;
        private Panel dummyPanel1;
        private Label successMessageEmailLbl;
        private Label successMessagePasswordLbl;
    }
}