namespace JobPortalDesktop.Forms
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            leftPanel = new Panel();
            welcomePanel = new Panel();
            logInBtn = new Button();
            welcomeLbl = new Label();
            logo = new PictureBox();
            mainPanel = new Panel();
            formPanel = new Panel();
            optionPanel = new Panel();
            optionTablePanel = new TableLayoutPanel();
            jobseekerRadioBtn = new RadioButton();
            employerRadioBtn = new RadioButton();
            chooseAccTypePanel = new Panel();
            accountTypeLbl = new Label();
            topPanel = new Panel();
            signUpLbl = new Label();
            leftPanel.SuspendLayout();
            welcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            mainPanel.SuspendLayout();
            optionPanel.SuspendLayout();
            optionTablePanel.SuspendLayout();
            chooseAccTypePanel.SuspendLayout();
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
            leftPanel.Margin = new Padding(5, 6, 5, 6);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(300, 761);
            leftPanel.TabIndex = 2;
            // 
            // welcomePanel
            // 
            welcomePanel.Controls.Add(logInBtn);
            welcomePanel.Controls.Add(welcomeLbl);
            welcomePanel.Dock = DockStyle.Top;
            welcomePanel.Location = new Point(0, 142);
            welcomePanel.Margin = new Padding(5, 6, 5, 6);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Padding = new Padding(20);
            welcomePanel.Size = new Size(300, 141);
            welcomePanel.TabIndex = 2;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.FromArgb(255, 190, 121);
            logInBtn.Cursor = Cursors.Hand;
            logInBtn.Dock = DockStyle.Fill;
            logInBtn.FlatAppearance.BorderSize = 0;
            logInBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 228, 202);
            logInBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 174, 91);
            logInBtn.FlatStyle = FlatStyle.Flat;
            logInBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logInBtn.ForeColor = Color.FromArgb(55, 65, 81);
            logInBtn.Location = new Point(20, 70);
            logInBtn.Margin = new Padding(5, 6, 5, 6);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(260, 51);
            logInBtn.TabIndex = 0;
            logInBtn.Text = "Log in";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // welcomeLbl
            // 
            welcomeLbl.Dock = DockStyle.Top;
            welcomeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLbl.ForeColor = Color.FromArgb(255, 190, 121);
            welcomeLbl.Location = new Point(20, 20);
            welcomeLbl.Margin = new Padding(5, 0, 5, 0);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(260, 50);
            welcomeLbl.TabIndex = 0;
            welcomeLbl.Text = "Already have an account?";
            welcomeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            logo.Dock = DockStyle.Top;
            logo.Image = Properties.Resources.logo_transparent;
            logo.Location = new Point(0, 0);
            logo.Margin = new Padding(5, 6, 5, 6);
            logo.Name = "logo";
            logo.Size = new Size(300, 142);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(243, 242, 239);
            mainPanel.Controls.Add(formPanel);
            mainPanel.Controls.Add(optionPanel);
            mainPanel.Controls.Add(topPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(80, 0, 80, 20);
            mainPanel.Size = new Size(584, 761);
            mainPanel.TabIndex = 3;
            // 
            // formPanel
            // 
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(80, 184);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(424, 557);
            formPanel.TabIndex = 3;
            // 
            // optionPanel
            // 
            optionPanel.Controls.Add(optionTablePanel);
            optionPanel.Controls.Add(chooseAccTypePanel);
            optionPanel.Dock = DockStyle.Top;
            optionPanel.Location = new Point(80, 50);
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
            jobseekerRadioBtn.TabIndex = 0;
            jobseekerRadioBtn.TabStop = true;
            jobseekerRadioBtn.Text = "Jobseeker";
            jobseekerRadioBtn.TextAlign = ContentAlignment.BottomCenter;
            jobseekerRadioBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            jobseekerRadioBtn.UseVisualStyleBackColor = false;
            jobseekerRadioBtn.CheckedChanged += jobseekerRadioBtn_CheckedChanged;
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
            employerRadioBtn.TabIndex = 0;
            employerRadioBtn.Text = "Employer";
            employerRadioBtn.TextAlign = ContentAlignment.BottomCenter;
            employerRadioBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            employerRadioBtn.UseVisualStyleBackColor = false;
            employerRadioBtn.CheckedChanged += employerRadioBtn_CheckedChanged;
            // 
            // chooseAccTypePanel
            // 
            chooseAccTypePanel.Controls.Add(accountTypeLbl);
            chooseAccTypePanel.Dock = DockStyle.Top;
            chooseAccTypePanel.Location = new Point(0, 0);
            chooseAccTypePanel.Name = "chooseAccTypePanel";
            chooseAccTypePanel.Size = new Size(424, 30);
            chooseAccTypePanel.TabIndex = 2;
            // 
            // accountTypeLbl
            // 
            accountTypeLbl.AutoSize = true;
            accountTypeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountTypeLbl.Location = new Point(3, 6);
            accountTypeLbl.Name = "accountTypeLbl";
            accountTypeLbl.Size = new Size(190, 21);
            accountTypeLbl.TabIndex = 4;
            accountTypeLbl.Text = "Choose your account type";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(signUpLbl);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(80, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(424, 50);
            topPanel.TabIndex = 0;
            // 
            // signUpLbl
            // 
            signUpLbl.Dock = DockStyle.Fill;
            signUpLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            signUpLbl.Location = new Point(0, 0);
            signUpLbl.Name = "signUpLbl";
            signUpLbl.Size = new Size(424, 50);
            signUpLbl.TabIndex = 0;
            signUpLbl.Text = "Sign up";
            signUpLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 761);
            Controls.Add(mainPanel);
            Controls.Add(leftPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(900, 800);
            MinimumSize = new Size(900, 800);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            leftPanel.ResumeLayout(false);
            welcomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            mainPanel.ResumeLayout(false);
            optionPanel.ResumeLayout(false);
            optionTablePanel.ResumeLayout(false);
            chooseAccTypePanel.ResumeLayout(false);
            chooseAccTypePanel.PerformLayout();
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel welcomePanel;
        private Button logInBtn;
        private Label welcomeLbl;
        private PictureBox logo;
        private Panel mainPanel;
        private Panel optionPanel;
        private TableLayoutPanel optionTablePanel;
        private RadioButton jobseekerRadioBtn;
        private RadioButton employerRadioBtn;
        private Panel chooseAccTypePanel;
        private Label accountTypeLbl;
        private Panel topPanel;
        private Label signUpLbl;
        private Panel formPanel;
    }
}