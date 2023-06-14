namespace JobPortalDesktop.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            leftPanel = new Panel();
            welcomePanel = new Panel();
            signUpBtn = new Button();
            welcomeLbl = new Label();
            logo = new PictureBox();
            mainPanel = new Panel();
            panel1 = new Panel();
            passwordValidationLbl = new Label();
            emailValidationLbl = new Label();
            passVisibilityCheckBox = new CheckBox();
            passwordLbl = new Label();
            passwordTxtBox = new TextBox();
            emailLbl = new Label();
            logInBtn = new Button();
            emailTxtBox = new TextBox();
            optionPanel = new Panel();
            optionTablePanel = new TableLayoutPanel();
            jobseekerRadioBtn = new RadioButton();
            employerRadioBtn = new RadioButton();
            panel2 = new Panel();
            accountTypeLbl = new Label();
            topPanel = new Panel();
            logInLbl = new Label();
            leftPanel.SuspendLayout();
            welcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            optionPanel.SuspendLayout();
            optionTablePanel.SuspendLayout();
            panel2.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(55, 65, 81);
            leftPanel.Controls.Add(welcomePanel);
            leftPanel.Controls.Add(logo);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(300, 561);
            leftPanel.TabIndex = 0;
            // 
            // welcomePanel
            // 
            welcomePanel.Controls.Add(signUpBtn);
            welcomePanel.Controls.Add(welcomeLbl);
            welcomePanel.Dock = DockStyle.Top;
            welcomePanel.Location = new Point(0, 142);
            welcomePanel.Margin = new Padding(4);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Padding = new Padding(20);
            welcomePanel.Size = new Size(300, 163);
            welcomePanel.TabIndex = 2;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.FromArgb(255, 190, 121);
            signUpBtn.Cursor = Cursors.Hand;
            signUpBtn.Dock = DockStyle.Fill;
            signUpBtn.FlatAppearance.BorderSize = 0;
            signUpBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 228, 202);
            signUpBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 174, 91);
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signUpBtn.ForeColor = Color.FromArgb(55, 65, 81);
            signUpBtn.Location = new Point(20, 92);
            signUpBtn.Margin = new Padding(4);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(260, 51);
            signUpBtn.TabIndex = 1;
            signUpBtn.Text = "Sign up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // welcomeLbl
            // 
            welcomeLbl.Dock = DockStyle.Top;
            welcomeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLbl.ForeColor = Color.FromArgb(255, 190, 121);
            welcomeLbl.ImageAlign = ContentAlignment.TopCenter;
            welcomeLbl.Location = new Point(20, 20);
            welcomeLbl.Margin = new Padding(4, 0, 4, 0);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(260, 72);
            welcomeLbl.TabIndex = 0;
            welcomeLbl.Text = "Welcome back!\r\nDon't have an account?\r\n";
            welcomeLbl.TextAlign = ContentAlignment.BottomCenter;
            // 
            // logo
            // 
            logo.Dock = DockStyle.Top;
            logo.Image = Properties.Resources.logo_transparent;
            logo.Location = new Point(0, 0);
            logo.Margin = new Padding(4);
            logo.Name = "logo";
            logo.Size = new Size(300, 142);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(243, 242, 239);
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(optionPanel);
            mainPanel.Controls.Add(topPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(80, 0, 80, 100);
            mainPanel.Size = new Size(584, 561);
            mainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(passwordValidationLbl);
            panel1.Controls.Add(emailValidationLbl);
            panel1.Controls.Add(passVisibilityCheckBox);
            panel1.Controls.Add(passwordLbl);
            panel1.Controls.Add(passwordTxtBox);
            panel1.Controls.Add(emailLbl);
            panel1.Controls.Add(logInBtn);
            panel1.Controls.Add(emailTxtBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(80, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 247);
            panel1.TabIndex = 3;
            // 
            // passwordValidationLbl
            // 
            passwordValidationLbl.AutoSize = true;
            passwordValidationLbl.ForeColor = Color.Maroon;
            passwordValidationLbl.Location = new Point(3, 153);
            passwordValidationLbl.Name = "passwordValidationLbl";
            passwordValidationLbl.Size = new Size(167, 21);
            passwordValidationLbl.TabIndex = 26;
            passwordValidationLbl.Text = "passwordValidationLbl";
            passwordValidationLbl.Visible = false;
            // 
            // emailValidationLbl
            // 
            emailValidationLbl.AutoSize = true;
            emailValidationLbl.ForeColor = Color.Maroon;
            emailValidationLbl.Location = new Point(3, 76);
            emailValidationLbl.Name = "emailValidationLbl";
            emailValidationLbl.Size = new Size(138, 21);
            emailValidationLbl.TabIndex = 25;
            emailValidationLbl.Text = "emailValidationLbl";
            emailValidationLbl.Visible = false;
            // 
            // passVisibilityCheckBox
            // 
            passVisibilityCheckBox.Appearance = Appearance.Button;
            passVisibilityCheckBox.BackColor = Color.White;
            passVisibilityCheckBox.FlatStyle = FlatStyle.Flat;
            passVisibilityCheckBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passVisibilityCheckBox.Location = new Point(344, 121);
            passVisibilityCheckBox.Name = "passVisibilityCheckBox";
            passVisibilityCheckBox.Size = new Size(77, 29);
            passVisibilityCheckBox.TabIndex = 3;
            passVisibilityCheckBox.Text = "Show";
            passVisibilityCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            passVisibilityCheckBox.UseVisualStyleBackColor = false;
            passVisibilityCheckBox.CheckedChanged += passVisibilityCheckBox_CheckedChanged;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLbl.Location = new Point(3, 97);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(76, 21);
            passwordLbl.TabIndex = 5;
            passwordLbl.Text = "Password";
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTxtBox.Location = new Point(3, 121);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(335, 29);
            passwordTxtBox.TabIndex = 4;
            passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLbl.Location = new Point(3, 20);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(48, 21);
            emailLbl.TabIndex = 3;
            emailLbl.Text = "Email";
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.FromArgb(25, 128, 80);
            logInBtn.Cursor = Cursors.Hand;
            logInBtn.Dock = DockStyle.Bottom;
            logInBtn.FlatAppearance.BorderSize = 0;
            logInBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 110, 69);
            logInBtn.FlatStyle = FlatStyle.Flat;
            logInBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logInBtn.ForeColor = Color.White;
            logInBtn.Location = new Point(0, 196);
            logInBtn.Margin = new Padding(4);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(424, 51);
            logInBtn.TabIndex = 5;
            logInBtn.Text = "Log in";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailTxtBox.Location = new Point(3, 44);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(418, 29);
            emailTxtBox.TabIndex = 3;
            // 
            // optionPanel
            // 
            optionPanel.Controls.Add(optionTablePanel);
            optionPanel.Controls.Add(panel2);
            optionPanel.Dock = DockStyle.Top;
            optionPanel.Location = new Point(80, 80);
            optionPanel.Name = "optionPanel";
            optionPanel.Size = new Size(424, 134);
            optionPanel.TabIndex = 2;
            // 
            // optionTablePanel
            // 
            optionTablePanel.ColumnCount = 3;
            optionTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            optionTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            optionTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            optionTablePanel.Controls.Add(jobseekerRadioBtn, 0, 0);
            optionTablePanel.Controls.Add(employerRadioBtn, 2, 0);
            optionTablePanel.Dock = DockStyle.Fill;
            optionTablePanel.Location = new Point(0, 30);
            optionTablePanel.Name = "optionTablePanel";
            optionTablePanel.RowCount = 1;
            optionTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            optionTablePanel.Size = new Size(424, 104);
            optionTablePanel.TabIndex = 1;
            // 
            // jobseekerRadioBtn
            // 
            jobseekerRadioBtn.Appearance = Appearance.Button;
            jobseekerRadioBtn.BackColor = Color.White;
            jobseekerRadioBtn.Checked = true;
            jobseekerRadioBtn.Cursor = Cursors.Hand;
            jobseekerRadioBtn.Dock = DockStyle.Fill;
            jobseekerRadioBtn.FlatAppearance.BorderColor = Color.Silver;
            jobseekerRadioBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 190, 121);
            jobseekerRadioBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 228, 202);
            jobseekerRadioBtn.FlatStyle = FlatStyle.Flat;
            jobseekerRadioBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            jobseekerRadioBtn.Image = Properties.Resources.jobseeker_icon;
            jobseekerRadioBtn.Location = new Point(3, 3);
            jobseekerRadioBtn.Name = "jobseekerRadioBtn";
            jobseekerRadioBtn.Size = new Size(197, 98);
            jobseekerRadioBtn.TabIndex = 1;
            jobseekerRadioBtn.TabStop = true;
            jobseekerRadioBtn.Text = "Jobseeker";
            jobseekerRadioBtn.TextAlign = ContentAlignment.BottomCenter;
            jobseekerRadioBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            jobseekerRadioBtn.UseVisualStyleBackColor = false;
            // 
            // employerRadioBtn
            // 
            employerRadioBtn.Appearance = Appearance.Button;
            employerRadioBtn.BackColor = Color.White;
            employerRadioBtn.Cursor = Cursors.Hand;
            employerRadioBtn.Dock = DockStyle.Fill;
            employerRadioBtn.FlatAppearance.BorderColor = Color.Silver;
            employerRadioBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 190, 121);
            employerRadioBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 228, 202);
            employerRadioBtn.FlatStyle = FlatStyle.Flat;
            employerRadioBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            employerRadioBtn.Image = Properties.Resources.employer_icon;
            employerRadioBtn.Location = new Point(222, 3);
            employerRadioBtn.Name = "employerRadioBtn";
            employerRadioBtn.Size = new Size(199, 98);
            employerRadioBtn.TabIndex = 2;
            employerRadioBtn.Text = "Employer";
            employerRadioBtn.TextAlign = ContentAlignment.BottomCenter;
            employerRadioBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            employerRadioBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(accountTypeLbl);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 30);
            panel2.TabIndex = 2;
            // 
            // accountTypeLbl
            // 
            accountTypeLbl.AutoSize = true;
            accountTypeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountTypeLbl.Location = new Point(3, 6);
            accountTypeLbl.Name = "accountTypeLbl";
            accountTypeLbl.Size = new Size(100, 21);
            accountTypeLbl.TabIndex = 4;
            accountTypeLbl.Text = "Account type";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(logInLbl);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(80, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(424, 80);
            topPanel.TabIndex = 0;
            // 
            // logInLbl
            // 
            logInLbl.Dock = DockStyle.Fill;
            logInLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            logInLbl.Location = new Point(0, 0);
            logInLbl.Name = "logInLbl";
            logInLbl.Size = new Size(424, 80);
            logInLbl.TabIndex = 0;
            logInLbl.Text = "Log in";
            logInLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(mainPanel);
            Controls.Add(leftPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            leftPanel.ResumeLayout(false);
            welcomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            optionPanel.ResumeLayout(false);
            optionTablePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private PictureBox logo;
        private Button signUpBtn;
        private Panel welcomePanel;
        private Label welcomeLbl;
        private Panel mainPanel;
        private Panel topPanel;
        private Label logInLbl;
        private TableLayoutPanel optionTablePanel;
        private Panel jobseekerPanel;
        private RadioButton jobseekerRadioBtn;
        private Panel employerPanel;
        private RadioButton employerRadioBtn;
        private Panel optionPanel;
        private Panel panel1;
        private TextBox emailTxtBox;
        private Button logInBtn;
        private Label passwordLbl;
        private TextBox passwordTxtBox;
        private Label emailLbl;
        private Panel panel2;
        private Label accountTypeLbl;
        private CheckBox passVisibilityCheckBox;
        private Label passwordValidationLbl;
        private Label emailValidationLbl;
    }
}