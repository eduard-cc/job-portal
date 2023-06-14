namespace JobPortalDesktop.Forms
{
    partial class ChangeEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeEmail));
            newEmailTxtBox = new TextBox();
            changeEmailLbl = new Label();
            changeEmailPanel = new Panel();
            passVisibilityCheckBox = new CheckBox();
            currentPasswordValidationLbl = new Label();
            newEmailValidationLbl = new Label();
            currentPasswordLbl = new Label();
            newEmailLbl = new Label();
            currentPasswordTxtBox = new TextBox();
            userEmailLbl = new Label();
            confirmBtn = new Button();
            changeEmailPanel.SuspendLayout();
            SuspendLayout();
            // 
            // newEmailTxtBox
            // 
            newEmailTxtBox.Anchor = AnchorStyles.None;
            newEmailTxtBox.Location = new Point(30, 149);
            newEmailTxtBox.Margin = new Padding(4);
            newEmailTxtBox.Name = "newEmailTxtBox";
            newEmailTxtBox.Size = new Size(520, 29);
            newEmailTxtBox.TabIndex = 1;
            // 
            // changeEmailLbl
            // 
            changeEmailLbl.Anchor = AnchorStyles.None;
            changeEmailLbl.AutoSize = true;
            changeEmailLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            changeEmailLbl.Location = new Point(30, 30);
            changeEmailLbl.Margin = new Padding(4, 0, 4, 0);
            changeEmailLbl.Name = "changeEmailLbl";
            changeEmailLbl.Size = new Size(171, 25);
            changeEmailLbl.TabIndex = 1;
            changeEmailLbl.Text = "Change your email";
            // 
            // changeEmailPanel
            // 
            changeEmailPanel.Controls.Add(passVisibilityCheckBox);
            changeEmailPanel.Controls.Add(currentPasswordValidationLbl);
            changeEmailPanel.Controls.Add(newEmailValidationLbl);
            changeEmailPanel.Controls.Add(currentPasswordLbl);
            changeEmailPanel.Controls.Add(newEmailLbl);
            changeEmailPanel.Controls.Add(currentPasswordTxtBox);
            changeEmailPanel.Controls.Add(userEmailLbl);
            changeEmailPanel.Controls.Add(confirmBtn);
            changeEmailPanel.Controls.Add(changeEmailLbl);
            changeEmailPanel.Controls.Add(newEmailTxtBox);
            changeEmailPanel.Dock = DockStyle.Fill;
            changeEmailPanel.Location = new Point(0, 0);
            changeEmailPanel.Margin = new Padding(4);
            changeEmailPanel.Name = "changeEmailPanel";
            changeEmailPanel.Padding = new Padding(30);
            changeEmailPanel.Size = new Size(584, 401);
            changeEmailPanel.TabIndex = 2;
            // 
            // passVisibilityCheckBox
            // 
            passVisibilityCheckBox.Anchor = AnchorStyles.None;
            passVisibilityCheckBox.Appearance = Appearance.Button;
            passVisibilityCheckBox.BackColor = Color.White;
            passVisibilityCheckBox.FlatStyle = FlatStyle.Flat;
            passVisibilityCheckBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passVisibilityCheckBox.Location = new Point(473, 243);
            passVisibilityCheckBox.Name = "passVisibilityCheckBox";
            passVisibilityCheckBox.Size = new Size(77, 29);
            passVisibilityCheckBox.TabIndex = 3;
            passVisibilityCheckBox.Text = "Show";
            passVisibilityCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            passVisibilityCheckBox.UseVisualStyleBackColor = false;
            passVisibilityCheckBox.CheckedChanged += passVisibilityCheckBox_CheckedChanged;
            // 
            // currentPasswordValidationLbl
            // 
            currentPasswordValidationLbl.Anchor = AnchorStyles.None;
            currentPasswordValidationLbl.AutoSize = true;
            currentPasswordValidationLbl.ForeColor = Color.Maroon;
            currentPasswordValidationLbl.Location = new Point(30, 276);
            currentPasswordValidationLbl.Name = "currentPasswordValidationLbl";
            currentPasswordValidationLbl.Size = new Size(167, 21);
            currentPasswordValidationLbl.TabIndex = 30;
            currentPasswordValidationLbl.Text = "passwordValidationLbl";
            currentPasswordValidationLbl.Visible = false;
            // 
            // newEmailValidationLbl
            // 
            newEmailValidationLbl.Anchor = AnchorStyles.None;
            newEmailValidationLbl.AutoSize = true;
            newEmailValidationLbl.ForeColor = Color.Maroon;
            newEmailValidationLbl.Location = new Point(30, 182);
            newEmailValidationLbl.Name = "newEmailValidationLbl";
            newEmailValidationLbl.Size = new Size(138, 21);
            newEmailValidationLbl.TabIndex = 29;
            newEmailValidationLbl.Text = "emailValidationLbl";
            newEmailValidationLbl.Visible = false;
            // 
            // currentPasswordLbl
            // 
            currentPasswordLbl.Anchor = AnchorStyles.None;
            currentPasswordLbl.AutoSize = true;
            currentPasswordLbl.Location = new Point(30, 218);
            currentPasswordLbl.Margin = new Padding(4, 0, 4, 0);
            currentPasswordLbl.Name = "currentPasswordLbl";
            currentPasswordLbl.Size = new Size(134, 21);
            currentPasswordLbl.TabIndex = 9;
            currentPasswordLbl.Text = "Current password";
            // 
            // newEmailLbl
            // 
            newEmailLbl.Anchor = AnchorStyles.None;
            newEmailLbl.AutoSize = true;
            newEmailLbl.Location = new Point(30, 124);
            newEmailLbl.Margin = new Padding(4, 0, 4, 0);
            newEmailLbl.Name = "newEmailLbl";
            newEmailLbl.Size = new Size(84, 21);
            newEmailLbl.TabIndex = 8;
            newEmailLbl.Text = "New Email";
            // 
            // currentPasswordTxtBox
            // 
            currentPasswordTxtBox.Anchor = AnchorStyles.None;
            currentPasswordTxtBox.Location = new Point(30, 243);
            currentPasswordTxtBox.Margin = new Padding(4);
            currentPasswordTxtBox.Name = "currentPasswordTxtBox";
            currentPasswordTxtBox.Size = new Size(436, 29);
            currentPasswordTxtBox.TabIndex = 2;
            currentPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // userEmailLbl
            // 
            userEmailLbl.Anchor = AnchorStyles.None;
            userEmailLbl.AutoSize = true;
            userEmailLbl.Location = new Point(30, 76);
            userEmailLbl.Margin = new Padding(4, 0, 4, 0);
            userEmailLbl.Name = "userEmailLbl";
            userEmailLbl.Size = new Size(58, 21);
            userEmailLbl.TabIndex = 6;
            userEmailLbl.Text = "{email}";
            // 
            // confirmBtn
            // 
            confirmBtn.Anchor = AnchorStyles.None;
            confirmBtn.BackColor = Color.FromArgb(25, 128, 80);
            confirmBtn.Cursor = Cursors.Hand;
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 110, 69);
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(30, 320);
            confirmBtn.Margin = new Padding(4);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(524, 51);
            confirmBtn.TabIndex = 4;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_ClickAsync;
            // 
            // ChangeEmail
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 401);
            Controls.Add(changeEmailPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(600, 440);
            Name = "ChangeEmail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change email";
            changeEmailPanel.ResumeLayout(false);
            changeEmailPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox newEmailTxtBox;
        private Label changeEmailLbl;
        private Panel changeEmailPanel;
        private Label currentPasswordLbl;
        private Label newEmailLbl;
        private TextBox currentPasswordTxtBox;
        private Label userEmailLbl;
        private Button confirmBtn;
        private Label currentPasswordValidationLbl;
        private Label newEmailValidationLbl;
        private CheckBox passVisibilityCheckBox;
    }
}