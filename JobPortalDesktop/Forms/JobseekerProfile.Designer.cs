namespace JobPortalDesktop.Forms
{
    partial class JobseekerProfile
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
            profileSettingsPanel = new Panel();
            successMessageProfileLbl = new Label();
            phoneNumberValidationLbl = new Label();
            locationValidationLbl = new Label();
            lastNameValidationLbl = new Label();
            firstNameValidationLbl = new Label();
            phoneNumberLbl = new Label();
            locationLbl = new Label();
            lastNameLbl = new Label();
            firstNameLbl = new Label();
            profileSettingsLbl = new Label();
            phoneNumberTxtBox = new TextBox();
            locationTxtBox = new TextBox();
            lastNameTxtBox = new TextBox();
            firstNameTxtBox = new TextBox();
            saveBtn = new Button();
            profileSettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // profileSettingsPanel
            // 
            profileSettingsPanel.Controls.Add(successMessageProfileLbl);
            profileSettingsPanel.Controls.Add(phoneNumberValidationLbl);
            profileSettingsPanel.Controls.Add(locationValidationLbl);
            profileSettingsPanel.Controls.Add(lastNameValidationLbl);
            profileSettingsPanel.Controls.Add(firstNameValidationLbl);
            profileSettingsPanel.Controls.Add(phoneNumberLbl);
            profileSettingsPanel.Controls.Add(locationLbl);
            profileSettingsPanel.Controls.Add(lastNameLbl);
            profileSettingsPanel.Controls.Add(firstNameLbl);
            profileSettingsPanel.Controls.Add(profileSettingsLbl);
            profileSettingsPanel.Controls.Add(phoneNumberTxtBox);
            profileSettingsPanel.Controls.Add(locationTxtBox);
            profileSettingsPanel.Controls.Add(lastNameTxtBox);
            profileSettingsPanel.Controls.Add(firstNameTxtBox);
            profileSettingsPanel.Controls.Add(saveBtn);
            profileSettingsPanel.Dock = DockStyle.Fill;
            profileSettingsPanel.Location = new Point(230, 100);
            profileSettingsPanel.Name = "profileSettingsPanel";
            profileSettingsPanel.Size = new Size(425, 461);
            profileSettingsPanel.TabIndex = 0;
            // 
            // successMessageProfileLbl
            // 
            successMessageProfileLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            successMessageProfileLbl.AutoSize = true;
            successMessageProfileLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            successMessageProfileLbl.ForeColor = Color.FromArgb(25, 128, 80);
            successMessageProfileLbl.Location = new Point(3, 378);
            successMessageProfileLbl.Name = "successMessageProfileLbl";
            successMessageProfileLbl.Size = new Size(132, 21);
            successMessageProfileLbl.TabIndex = 38;
            successMessageProfileLbl.Text = "successMessage";
            successMessageProfileLbl.Visible = false;
            // 
            // phoneNumberValidationLbl
            // 
            phoneNumberValidationLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberValidationLbl.AutoSize = true;
            phoneNumberValidationLbl.ForeColor = Color.Maroon;
            phoneNumberValidationLbl.Location = new Point(3, 357);
            phoneNumberValidationLbl.Name = "phoneNumberValidationLbl";
            phoneNumberValidationLbl.Size = new Size(202, 21);
            phoneNumberValidationLbl.TabIndex = 36;
            phoneNumberValidationLbl.Text = "phoneNumberValidationLbl";
            phoneNumberValidationLbl.Visible = false;
            // 
            // locationValidationLbl
            // 
            locationValidationLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            locationValidationLbl.AutoSize = true;
            locationValidationLbl.ForeColor = Color.Maroon;
            locationValidationLbl.Location = new Point(3, 272);
            locationValidationLbl.Name = "locationValidationLbl";
            locationValidationLbl.Size = new Size(155, 21);
            locationValidationLbl.TabIndex = 35;
            locationValidationLbl.Text = "locationValidationLbl";
            locationValidationLbl.Visible = false;
            // 
            // lastNameValidationLbl
            // 
            lastNameValidationLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lastNameValidationLbl.AutoSize = true;
            lastNameValidationLbl.ForeColor = Color.Maroon;
            lastNameValidationLbl.Location = new Point(3, 187);
            lastNameValidationLbl.Name = "lastNameValidationLbl";
            lastNameValidationLbl.Size = new Size(166, 21);
            lastNameValidationLbl.TabIndex = 34;
            lastNameValidationLbl.Text = "lastNameValidationLbl";
            lastNameValidationLbl.Visible = false;
            // 
            // firstNameValidationLbl
            // 
            firstNameValidationLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            firstNameValidationLbl.AutoSize = true;
            firstNameValidationLbl.ForeColor = Color.Maroon;
            firstNameValidationLbl.Location = new Point(3, 102);
            firstNameValidationLbl.Name = "firstNameValidationLbl";
            firstNameValidationLbl.Size = new Size(169, 21);
            firstNameValidationLbl.TabIndex = 33;
            firstNameValidationLbl.Text = "firstNameValidationLbl";
            firstNameValidationLbl.Visible = false;
            // 
            // phoneNumberLbl
            // 
            phoneNumberLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberLbl.AutoSize = true;
            phoneNumberLbl.Location = new Point(3, 301);
            phoneNumberLbl.Name = "phoneNumberLbl";
            phoneNumberLbl.Size = new Size(113, 21);
            phoneNumberLbl.TabIndex = 13;
            phoneNumberLbl.Text = "Phone number";
            // 
            // locationLbl
            // 
            locationLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            locationLbl.AutoSize = true;
            locationLbl.Location = new Point(3, 216);
            locationLbl.Name = "locationLbl";
            locationLbl.Size = new Size(69, 21);
            locationLbl.TabIndex = 12;
            locationLbl.Text = "Location";
            // 
            // lastNameLbl
            // 
            lastNameLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(3, 131);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(81, 21);
            lastNameLbl.TabIndex = 11;
            lastNameLbl.Text = "Last name";
            // 
            // firstNameLbl
            // 
            firstNameLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(3, 46);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(83, 21);
            firstNameLbl.TabIndex = 10;
            firstNameLbl.Text = "First name";
            // 
            // profileSettingsLbl
            // 
            profileSettingsLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profileSettingsLbl.AutoSize = true;
            profileSettingsLbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            profileSettingsLbl.Location = new Point(3, 0);
            profileSettingsLbl.Name = "profileSettingsLbl";
            profileSettingsLbl.Size = new Size(155, 30);
            profileSettingsLbl.TabIndex = 9;
            profileSettingsLbl.Text = "Profile settings";
            // 
            // phoneNumberTxtBox
            // 
            phoneNumberTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTxtBox.Location = new Point(3, 325);
            phoneNumberTxtBox.Name = "phoneNumberTxtBox";
            phoneNumberTxtBox.Size = new Size(419, 29);
            phoneNumberTxtBox.TabIndex = 4;
            // 
            // locationTxtBox
            // 
            locationTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            locationTxtBox.Location = new Point(3, 240);
            locationTxtBox.Name = "locationTxtBox";
            locationTxtBox.Size = new Size(419, 29);
            locationTxtBox.TabIndex = 3;
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lastNameTxtBox.Location = new Point(3, 155);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(419, 29);
            lastNameTxtBox.TabIndex = 2;
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            firstNameTxtBox.Location = new Point(3, 70);
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.Size = new Size(419, 29);
            firstNameTxtBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(25, 128, 80);
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Dock = DockStyle.Bottom;
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 110, 69);
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(0, 410);
            saveBtn.Margin = new Padding(4);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(425, 51);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // JobseekerProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 661);
            ControlBox = false;
            Controls.Add(profileSettingsPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "JobseekerProfile";
            Padding = new Padding(230, 100, 230, 100);
            Text = "JobseekerProfile";
            Load += JobseekerProfile_Load;
            profileSettingsPanel.ResumeLayout(false);
            profileSettingsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel profileSettingsPanel;
        private Button saveBtn;
        private Label profileSettingsLbl;
        private TextBox phoneNumberTxtBox;
        private TextBox locationTxtBox;
        private TextBox lastNameTxtBox;
        private TextBox firstNameTxtBox;
        private Label phoneNumberLbl;
        private Label locationLbl;
        private Label lastNameLbl;
        private Label firstNameLbl;
        private Label phoneNumberValidationLbl;
        private Label locationValidationLbl;
        private Label lastNameValidationLbl;
        private Label firstNameValidationLbl;
        private Label successMessageProfileLbl;
    }
}