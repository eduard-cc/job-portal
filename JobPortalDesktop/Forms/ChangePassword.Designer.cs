namespace JobPortalDesktop.Forms
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            changePasswordPanel = new Panel();
            newPasswordValidationLbl = new Label();
            newPasswordLbl = new Label();
            newPasswordTxtBox = new TextBox();
            currentPasswordValidationLbl = new Label();
            confirmNewPasswordValidationLbl = new Label();
            currentPasswordLbl = new Label();
            confirmNewPasswordLbl = new Label();
            currentPasswordTxtBox = new TextBox();
            confirmBtn = new Button();
            changePasswordLbl = new Label();
            confirmNewPasswordTxtBox = new TextBox();
            changePasswordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // changePasswordPanel
            // 
            changePasswordPanel.Controls.Add(newPasswordValidationLbl);
            changePasswordPanel.Controls.Add(newPasswordLbl);
            changePasswordPanel.Controls.Add(newPasswordTxtBox);
            changePasswordPanel.Controls.Add(currentPasswordValidationLbl);
            changePasswordPanel.Controls.Add(confirmNewPasswordValidationLbl);
            changePasswordPanel.Controls.Add(currentPasswordLbl);
            changePasswordPanel.Controls.Add(confirmNewPasswordLbl);
            changePasswordPanel.Controls.Add(currentPasswordTxtBox);
            changePasswordPanel.Controls.Add(confirmBtn);
            changePasswordPanel.Controls.Add(changePasswordLbl);
            changePasswordPanel.Controls.Add(confirmNewPasswordTxtBox);
            changePasswordPanel.Dock = DockStyle.Fill;
            changePasswordPanel.Location = new Point(0, 0);
            changePasswordPanel.Margin = new Padding(4);
            changePasswordPanel.Name = "changePasswordPanel";
            changePasswordPanel.Padding = new Padding(30);
            changePasswordPanel.Size = new Size(584, 441);
            changePasswordPanel.TabIndex = 3;
            // 
            // newPasswordValidationLbl
            // 
            newPasswordValidationLbl.AutoSize = true;
            newPasswordValidationLbl.ForeColor = Color.Maroon;
            newPasswordValidationLbl.Location = new Point(34, 130);
            newPasswordValidationLbl.Name = "newPasswordValidationLbl";
            newPasswordValidationLbl.Size = new Size(195, 21);
            newPasswordValidationLbl.TabIndex = 34;
            newPasswordValidationLbl.Text = "newPasswordValidationLbl";
            newPasswordValidationLbl.Visible = false;
            // 
            // newPasswordLbl
            // 
            newPasswordLbl.AutoSize = true;
            newPasswordLbl.Location = new Point(33, 72);
            newPasswordLbl.Margin = new Padding(4, 0, 4, 0);
            newPasswordLbl.Name = "newPasswordLbl";
            newPasswordLbl.Size = new Size(113, 21);
            newPasswordLbl.TabIndex = 33;
            newPasswordLbl.Text = "New password";
            // 
            // newPasswordTxtBox
            // 
            newPasswordTxtBox.Location = new Point(34, 97);
            newPasswordTxtBox.Margin = new Padding(4);
            newPasswordTxtBox.Name = "newPasswordTxtBox";
            newPasswordTxtBox.Size = new Size(516, 29);
            newPasswordTxtBox.TabIndex = 1;
            newPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // currentPasswordValidationLbl
            // 
            currentPasswordValidationLbl.AutoSize = true;
            currentPasswordValidationLbl.ForeColor = Color.Maroon;
            currentPasswordValidationLbl.Location = new Point(34, 312);
            currentPasswordValidationLbl.Name = "currentPasswordValidationLbl";
            currentPasswordValidationLbl.Size = new Size(216, 21);
            currentPasswordValidationLbl.TabIndex = 30;
            currentPasswordValidationLbl.Text = "currentPasswordValidationLbl";
            currentPasswordValidationLbl.Visible = false;
            // 
            // confirmNewPasswordValidationLbl
            // 
            confirmNewPasswordValidationLbl.AutoSize = true;
            confirmNewPasswordValidationLbl.ForeColor = Color.Maroon;
            confirmNewPasswordValidationLbl.Location = new Point(33, 221);
            confirmNewPasswordValidationLbl.Name = "confirmNewPasswordValidationLbl";
            confirmNewPasswordValidationLbl.Size = new Size(252, 21);
            confirmNewPasswordValidationLbl.TabIndex = 29;
            confirmNewPasswordValidationLbl.Text = "confirmNewPasswordValidationLbl";
            confirmNewPasswordValidationLbl.Visible = false;
            // 
            // currentPasswordLbl
            // 
            currentPasswordLbl.AutoSize = true;
            currentPasswordLbl.Location = new Point(33, 254);
            currentPasswordLbl.Margin = new Padding(4, 0, 4, 0);
            currentPasswordLbl.Name = "currentPasswordLbl";
            currentPasswordLbl.Size = new Size(134, 21);
            currentPasswordLbl.TabIndex = 9;
            currentPasswordLbl.Text = "Current password";
            // 
            // confirmNewPasswordLbl
            // 
            confirmNewPasswordLbl.AutoSize = true;
            confirmNewPasswordLbl.Location = new Point(34, 163);
            confirmNewPasswordLbl.Margin = new Padding(4, 0, 4, 0);
            confirmNewPasswordLbl.Name = "confirmNewPasswordLbl";
            confirmNewPasswordLbl.Size = new Size(171, 21);
            confirmNewPasswordLbl.TabIndex = 8;
            confirmNewPasswordLbl.Text = "Confirm new password";
            // 
            // currentPasswordTxtBox
            // 
            currentPasswordTxtBox.Location = new Point(34, 279);
            currentPasswordTxtBox.Margin = new Padding(4);
            currentPasswordTxtBox.Name = "currentPasswordTxtBox";
            currentPasswordTxtBox.Size = new Size(516, 29);
            currentPasswordTxtBox.TabIndex = 3;
            currentPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.FromArgb(25, 128, 80);
            confirmBtn.Cursor = Cursors.Hand;
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 110, 69);
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(34, 356);
            confirmBtn.Margin = new Padding(4);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(524, 51);
            confirmBtn.TabIndex = 4;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // changePasswordLbl
            // 
            changePasswordLbl.AutoSize = true;
            changePasswordLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            changePasswordLbl.Location = new Point(34, 30);
            changePasswordLbl.Margin = new Padding(4, 0, 4, 0);
            changePasswordLbl.Name = "changePasswordLbl";
            changePasswordLbl.Size = new Size(205, 25);
            changePasswordLbl.TabIndex = 1;
            changePasswordLbl.Text = "Change your password";
            // 
            // confirmNewPasswordTxtBox
            // 
            confirmNewPasswordTxtBox.Location = new Point(34, 188);
            confirmNewPasswordTxtBox.Margin = new Padding(4);
            confirmNewPasswordTxtBox.Name = "confirmNewPasswordTxtBox";
            confirmNewPasswordTxtBox.Size = new Size(516, 29);
            confirmNewPasswordTxtBox.TabIndex = 2;
            confirmNewPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 441);
            Controls.Add(changePasswordPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change password";
            changePasswordPanel.ResumeLayout(false);
            changePasswordPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel changePasswordPanel;
        private Label currentPasswordValidationLbl;
        private Label confirmNewPasswordValidationLbl;
        private Label currentPasswordLbl;
        private Label confirmNewPasswordLbl;
        private TextBox currentPasswordTxtBox;
        private Button confirmBtn;
        private Label changePasswordLbl;
        private TextBox confirmNewPasswordTxtBox;
        private Label newPasswordValidationLbl;
        private Label newPasswordLbl;
        private TextBox newPasswordTxtBox;
    }
}