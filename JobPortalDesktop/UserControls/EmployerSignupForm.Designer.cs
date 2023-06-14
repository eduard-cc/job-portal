namespace JobPortalDesktop.UserControls
{
    partial class EmployerSignupForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signUpBtn = new Button();
            locationLbl = new Label();
            locationTxtBox = new TextBox();
            lastNameLbl = new Label();
            companyNameLbl = new Label();
            companyNameTxtBox = new TextBox();
            passwordLbl = new Label();
            passwordTxtBox = new TextBox();
            emailLbl = new Label();
            emailTxtBox = new TextBox();
            companySizeComboBox = new ComboBox();
            passVisibilityCheckBox = new CheckBox();
            emailValidationLbl = new Label();
            passwordValidationLbl = new Label();
            companyNameValidationLbl = new Label();
            locationValidationLbl = new Label();
            SuspendLayout();
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.FromArgb(25, 128, 80);
            signUpBtn.Cursor = Cursors.Hand;
            signUpBtn.Dock = DockStyle.Bottom;
            signUpBtn.FlatAppearance.BorderSize = 0;
            signUpBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 110, 69);
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signUpBtn.ForeColor = Color.White;
            signUpBtn.Location = new Point(0, 506);
            signUpBtn.Margin = new Padding(4);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(424, 51);
            signUpBtn.TabIndex = 7;
            signUpBtn.Text = "Sign up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // locationLbl
            // 
            locationLbl.Anchor = AnchorStyles.None;
            locationLbl.AutoSize = true;
            locationLbl.Location = new Point(4, 342);
            locationLbl.Name = "locationLbl";
            locationLbl.Size = new Size(69, 21);
            locationLbl.TabIndex = 23;
            locationLbl.Text = "Location";
            // 
            // locationTxtBox
            // 
            locationTxtBox.Anchor = AnchorStyles.None;
            locationTxtBox.Location = new Point(4, 367);
            locationTxtBox.Margin = new Padding(4);
            locationTxtBox.Name = "locationTxtBox";
            locationTxtBox.Size = new Size(416, 29);
            locationTxtBox.TabIndex = 6;
            // 
            // lastNameLbl
            // 
            lastNameLbl.Anchor = AnchorStyles.None;
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(4, 264);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(165, 21);
            lastNameLbl.TabIndex = 20;
            lastNameLbl.Text = "Number of employees";
            // 
            // companyNameLbl
            // 
            companyNameLbl.Anchor = AnchorStyles.None;
            companyNameLbl.AutoSize = true;
            companyNameLbl.Location = new Point(4, 184);
            companyNameLbl.Name = "companyNameLbl";
            companyNameLbl.Size = new Size(120, 21);
            companyNameLbl.TabIndex = 18;
            companyNameLbl.Text = "Company name";
            // 
            // companyNameTxtBox
            // 
            companyNameTxtBox.Anchor = AnchorStyles.None;
            companyNameTxtBox.Location = new Point(4, 209);
            companyNameTxtBox.Margin = new Padding(4);
            companyNameTxtBox.Name = "companyNameTxtBox";
            companyNameTxtBox.Size = new Size(416, 29);
            companyNameTxtBox.TabIndex = 4;
            // 
            // passwordLbl
            // 
            passwordLbl.Anchor = AnchorStyles.None;
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(4, 105);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(76, 21);
            passwordLbl.TabIndex = 16;
            passwordLbl.Text = "Password";
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Anchor = AnchorStyles.None;
            passwordTxtBox.Location = new Point(4, 130);
            passwordTxtBox.Margin = new Padding(4);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(332, 29);
            passwordTxtBox.TabIndex = 2;
            passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // emailLbl
            // 
            emailLbl.Anchor = AnchorStyles.None;
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(4, 26);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(48, 21);
            emailLbl.TabIndex = 14;
            emailLbl.Text = "Email";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Anchor = AnchorStyles.None;
            emailTxtBox.Location = new Point(4, 51);
            emailTxtBox.Margin = new Padding(4);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(416, 29);
            emailTxtBox.TabIndex = 1;
            // 
            // companySizeComboBox
            // 
            companySizeComboBox.Anchor = AnchorStyles.None;
            companySizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            companySizeComboBox.FormattingEnabled = true;
            companySizeComboBox.Location = new Point(4, 288);
            companySizeComboBox.Name = "companySizeComboBox";
            companySizeComboBox.Size = new Size(416, 29);
            companySizeComboBox.TabIndex = 5;
            // 
            // passVisibilityCheckBox
            // 
            passVisibilityCheckBox.Anchor = AnchorStyles.None;
            passVisibilityCheckBox.Appearance = Appearance.Button;
            passVisibilityCheckBox.BackColor = Color.White;
            passVisibilityCheckBox.FlatStyle = FlatStyle.Flat;
            passVisibilityCheckBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passVisibilityCheckBox.Location = new Point(343, 130);
            passVisibilityCheckBox.Name = "passVisibilityCheckBox";
            passVisibilityCheckBox.Size = new Size(77, 29);
            passVisibilityCheckBox.TabIndex = 3;
            passVisibilityCheckBox.Text = "Show";
            passVisibilityCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            passVisibilityCheckBox.UseVisualStyleBackColor = false;
            passVisibilityCheckBox.CheckedChanged += passVisibilityCheckBox_CheckedChanged;
            // 
            // emailValidationLbl
            // 
            emailValidationLbl.AutoSize = true;
            emailValidationLbl.ForeColor = Color.Maroon;
            emailValidationLbl.Location = new Point(4, 84);
            emailValidationLbl.Name = "emailValidationLbl";
            emailValidationLbl.Size = new Size(138, 21);
            emailValidationLbl.TabIndex = 24;
            emailValidationLbl.Text = "emailValidationLbl";
            emailValidationLbl.Visible = false;
            // 
            // passwordValidationLbl
            // 
            passwordValidationLbl.AutoSize = true;
            passwordValidationLbl.ForeColor = Color.Maroon;
            passwordValidationLbl.Location = new Point(4, 163);
            passwordValidationLbl.Name = "passwordValidationLbl";
            passwordValidationLbl.Size = new Size(167, 21);
            passwordValidationLbl.TabIndex = 25;
            passwordValidationLbl.Text = "passwordValidationLbl";
            passwordValidationLbl.Visible = false;
            // 
            // companyNameValidationLbl
            // 
            companyNameValidationLbl.AutoSize = true;
            companyNameValidationLbl.ForeColor = Color.Maroon;
            companyNameValidationLbl.Location = new Point(4, 242);
            companyNameValidationLbl.Name = "companyNameValidationLbl";
            companyNameValidationLbl.Size = new Size(206, 21);
            companyNameValidationLbl.TabIndex = 26;
            companyNameValidationLbl.Text = "companyNameValidationLbl";
            companyNameValidationLbl.Visible = false;
            // 
            // locationValidationLbl
            // 
            locationValidationLbl.AutoSize = true;
            locationValidationLbl.ForeColor = Color.Maroon;
            locationValidationLbl.Location = new Point(4, 400);
            locationValidationLbl.Name = "locationValidationLbl";
            locationValidationLbl.Size = new Size(155, 21);
            locationValidationLbl.TabIndex = 28;
            locationValidationLbl.Text = "locationValidationLbl";
            locationValidationLbl.Visible = false;
            // 
            // EmployerSignupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(locationValidationLbl);
            Controls.Add(companyNameValidationLbl);
            Controls.Add(passwordValidationLbl);
            Controls.Add(emailValidationLbl);
            Controls.Add(passVisibilityCheckBox);
            Controls.Add(companySizeComboBox);
            Controls.Add(signUpBtn);
            Controls.Add(locationLbl);
            Controls.Add(locationTxtBox);
            Controls.Add(lastNameLbl);
            Controls.Add(companyNameLbl);
            Controls.Add(companyNameTxtBox);
            Controls.Add(passwordLbl);
            Controls.Add(passwordTxtBox);
            Controls.Add(emailLbl);
            Controls.Add(emailTxtBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EmployerSignupForm";
            Size = new Size(424, 557);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signUpBtn;
        private Label locationLbl;
        private TextBox locationTxtBox;
        private Label lastNameLbl;
        private Label companyNameLbl;
        private TextBox companyNameTxtBox;
        private Label passwordLbl;
        private TextBox passwordTxtBox;
        private Label emailLbl;
        private TextBox emailTxtBox;
        private ComboBox companySizeComboBox;
        private CheckBox passVisibilityCheckBox;
        private Label emailValidationLbl;
        private Label passwordValidationLbl;
        private Label companyNameValidationLbl;
        private Label locationValidationLbl;
    }
}
