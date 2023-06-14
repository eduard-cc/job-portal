namespace JobPortalDesktop.UserControls
{
    partial class JobseekerSignupForm
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
            emailTxtBox = new TextBox();
            emailLbl = new Label();
            passwordLbl = new Label();
            passwordTxtBox = new TextBox();
            firstNameLbl = new Label();
            firstNameTxtBox = new TextBox();
            lastNameLbl = new Label();
            lastNameTxtBox = new TextBox();
            locationTxtBox = new TextBox();
            locationLbl = new Label();
            signUpBtn = new Button();
            phoneNumberLbl = new Label();
            phoneNumberTxtBox = new TextBox();
            passVisibilityCheckBox = new CheckBox();
            emailValidationLbl = new Label();
            passwordValidationLbl = new Label();
            firstNameValidationLbl = new Label();
            lastNameValidationLbl = new Label();
            locationValidationLbl = new Label();
            phoneNumberValidationLbl = new Label();
            SuspendLayout();
            // 
            // emailTxtBox
            // 
            emailTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailTxtBox.Location = new Point(4, 51);
            emailTxtBox.Margin = new Padding(4);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(416, 29);
            emailTxtBox.TabIndex = 1;
            // 
            // emailLbl
            // 
            emailLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(4, 26);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(48, 21);
            emailLbl.TabIndex = 1;
            emailLbl.Text = "Email";
            // 
            // passwordLbl
            // 
            passwordLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(4, 104);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(76, 21);
            passwordLbl.TabIndex = 3;
            passwordLbl.Text = "Password";
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTxtBox.Location = new Point(4, 129);
            passwordTxtBox.Margin = new Padding(4);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(332, 29);
            passwordTxtBox.TabIndex = 2;
            passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // firstNameLbl
            // 
            firstNameLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(4, 182);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(83, 21);
            firstNameLbl.TabIndex = 5;
            firstNameLbl.Text = "First name";
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            firstNameTxtBox.Location = new Point(4, 207);
            firstNameTxtBox.Margin = new Padding(4);
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.Size = new Size(416, 29);
            firstNameTxtBox.TabIndex = 4;
            // 
            // lastNameLbl
            // 
            lastNameLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(4, 260);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(81, 21);
            lastNameLbl.TabIndex = 7;
            lastNameLbl.Text = "Last name";
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lastNameTxtBox.Location = new Point(4, 285);
            lastNameTxtBox.Margin = new Padding(4);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(416, 29);
            lastNameTxtBox.TabIndex = 5;
            // 
            // locationTxtBox
            // 
            locationTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            locationTxtBox.Location = new Point(4, 363);
            locationTxtBox.Margin = new Padding(4);
            locationTxtBox.Name = "locationTxtBox";
            locationTxtBox.Size = new Size(416, 29);
            locationTxtBox.TabIndex = 6;
            // 
            // locationLbl
            // 
            locationLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            locationLbl.AutoSize = true;
            locationLbl.Location = new Point(4, 339);
            locationLbl.Name = "locationLbl";
            locationLbl.Size = new Size(69, 21);
            locationLbl.TabIndex = 10;
            locationLbl.Text = "Location";
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
            signUpBtn.TabIndex = 8;
            signUpBtn.Text = "Sign up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // phoneNumberLbl
            // 
            phoneNumberLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberLbl.AutoSize = true;
            phoneNumberLbl.Location = new Point(4, 416);
            phoneNumberLbl.Name = "phoneNumberLbl";
            phoneNumberLbl.Size = new Size(113, 21);
            phoneNumberLbl.TabIndex = 26;
            phoneNumberLbl.Text = "Phone number";
            // 
            // phoneNumberTxtBox
            // 
            phoneNumberTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTxtBox.Location = new Point(4, 441);
            phoneNumberTxtBox.Margin = new Padding(4);
            phoneNumberTxtBox.Name = "phoneNumberTxtBox";
            phoneNumberTxtBox.Size = new Size(416, 29);
            phoneNumberTxtBox.TabIndex = 7;
            // 
            // passVisibilityCheckBox
            // 
            passVisibilityCheckBox.Anchor = AnchorStyles.None;
            passVisibilityCheckBox.Appearance = Appearance.Button;
            passVisibilityCheckBox.BackColor = Color.White;
            passVisibilityCheckBox.FlatStyle = FlatStyle.Flat;
            passVisibilityCheckBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passVisibilityCheckBox.Location = new Point(343, 129);
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
            emailValidationLbl.TabIndex = 27;
            emailValidationLbl.Text = "emailValidationLbl";
            emailValidationLbl.Visible = false;
            // 
            // passwordValidationLbl
            // 
            passwordValidationLbl.AutoSize = true;
            passwordValidationLbl.ForeColor = Color.Maroon;
            passwordValidationLbl.Location = new Point(4, 162);
            passwordValidationLbl.Name = "passwordValidationLbl";
            passwordValidationLbl.Size = new Size(167, 21);
            passwordValidationLbl.TabIndex = 28;
            passwordValidationLbl.Text = "passwordValidationLbl";
            passwordValidationLbl.Visible = false;
            // 
            // firstNameValidationLbl
            // 
            firstNameValidationLbl.AutoSize = true;
            firstNameValidationLbl.ForeColor = Color.Maroon;
            firstNameValidationLbl.Location = new Point(4, 240);
            firstNameValidationLbl.Name = "firstNameValidationLbl";
            firstNameValidationLbl.Size = new Size(169, 21);
            firstNameValidationLbl.TabIndex = 29;
            firstNameValidationLbl.Text = "firstNameValidationLbl";
            firstNameValidationLbl.Visible = false;
            // 
            // lastNameValidationLbl
            // 
            lastNameValidationLbl.AutoSize = true;
            lastNameValidationLbl.ForeColor = Color.Maroon;
            lastNameValidationLbl.Location = new Point(4, 318);
            lastNameValidationLbl.Name = "lastNameValidationLbl";
            lastNameValidationLbl.Size = new Size(166, 21);
            lastNameValidationLbl.TabIndex = 30;
            lastNameValidationLbl.Text = "lastNameValidationLbl";
            lastNameValidationLbl.Visible = false;
            // 
            // locationValidationLbl
            // 
            locationValidationLbl.AutoSize = true;
            locationValidationLbl.ForeColor = Color.Maroon;
            locationValidationLbl.Location = new Point(4, 395);
            locationValidationLbl.Name = "locationValidationLbl";
            locationValidationLbl.Size = new Size(155, 21);
            locationValidationLbl.TabIndex = 31;
            locationValidationLbl.Text = "locationValidationLbl";
            locationValidationLbl.Visible = false;
            // 
            // phoneNumberValidationLbl
            // 
            phoneNumberValidationLbl.AutoSize = true;
            phoneNumberValidationLbl.ForeColor = Color.Maroon;
            phoneNumberValidationLbl.Location = new Point(4, 474);
            phoneNumberValidationLbl.Name = "phoneNumberValidationLbl";
            phoneNumberValidationLbl.Size = new Size(202, 21);
            phoneNumberValidationLbl.TabIndex = 32;
            phoneNumberValidationLbl.Text = "phoneNumberValidationLbl";
            phoneNumberValidationLbl.Visible = false;
            // 
            // JobseekerSignupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(phoneNumberValidationLbl);
            Controls.Add(locationValidationLbl);
            Controls.Add(lastNameValidationLbl);
            Controls.Add(firstNameValidationLbl);
            Controls.Add(passwordValidationLbl);
            Controls.Add(emailValidationLbl);
            Controls.Add(passVisibilityCheckBox);
            Controls.Add(phoneNumberLbl);
            Controls.Add(phoneNumberTxtBox);
            Controls.Add(signUpBtn);
            Controls.Add(locationLbl);
            Controls.Add(locationTxtBox);
            Controls.Add(lastNameLbl);
            Controls.Add(lastNameTxtBox);
            Controls.Add(firstNameLbl);
            Controls.Add(firstNameTxtBox);
            Controls.Add(passwordLbl);
            Controls.Add(passwordTxtBox);
            Controls.Add(emailLbl);
            Controls.Add(emailTxtBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "JobseekerSignupForm";
            Size = new Size(424, 557);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailTxtBox;
        private Label emailLbl;
        private Label passwordLbl;
        private TextBox passwordTxtBox;
        private Label firstNameLbl;
        private TextBox firstNameTxtBox;
        private Label lastNameLbl;
        private TextBox lastNameTxtBox;
        private TextBox locationTxtBox;
        private Label locationLbl;
        private Button signUpBtn;
        private Label phoneNumberLbl;
        private TextBox phoneNumberTxtBox;
        private CheckBox passVisibilityCheckBox;
        private Label emailValidationLbl;
        private Label passwordValidationLbl;
        private Label firstNameValidationLbl;
        private Label lastNameValidationLbl;
        private Label locationValidationLbl;
        private Label phoneNumberValidationLbl;
    }
}
