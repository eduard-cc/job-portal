namespace JobPortalDesktop.Forms
{
    partial class EmployerProfile
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
            companySizeComboBox = new ComboBox();
            locationValidationLbl = new Label();
            companyNameValidationLbl = new Label();
            locationLbl = new Label();
            companySizeLbl = new Label();
            companyNameLbl = new Label();
            profileSettingsLbl = new Label();
            locationTxtBox = new TextBox();
            companyNameTxtBox = new TextBox();
            saveBtn = new Button();
            profileSettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // profileSettingsPanel
            // 
            profileSettingsPanel.Controls.Add(successMessageProfileLbl);
            profileSettingsPanel.Controls.Add(companySizeComboBox);
            profileSettingsPanel.Controls.Add(locationValidationLbl);
            profileSettingsPanel.Controls.Add(companyNameValidationLbl);
            profileSettingsPanel.Controls.Add(locationLbl);
            profileSettingsPanel.Controls.Add(companySizeLbl);
            profileSettingsPanel.Controls.Add(companyNameLbl);
            profileSettingsPanel.Controls.Add(profileSettingsLbl);
            profileSettingsPanel.Controls.Add(locationTxtBox);
            profileSettingsPanel.Controls.Add(companyNameTxtBox);
            profileSettingsPanel.Controls.Add(saveBtn);
            profileSettingsPanel.Dock = DockStyle.Fill;
            profileSettingsPanel.Location = new Point(230, 100);
            profileSettingsPanel.Name = "profileSettingsPanel";
            profileSettingsPanel.Size = new Size(425, 461);
            profileSettingsPanel.TabIndex = 1;
            // 
            // successMessageProfileLbl
            // 
            successMessageProfileLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            successMessageProfileLbl.AutoSize = true;
            successMessageProfileLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            successMessageProfileLbl.ForeColor = Color.FromArgb(25, 128, 80);
            successMessageProfileLbl.Location = new Point(3, 360);
            successMessageProfileLbl.Name = "successMessageProfileLbl";
            successMessageProfileLbl.Size = new Size(132, 21);
            successMessageProfileLbl.TabIndex = 37;
            successMessageProfileLbl.Text = "successMessage";
            successMessageProfileLbl.Visible = false;
            // 
            // companySizeComboBox
            // 
            companySizeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            companySizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            companySizeComboBox.FormattingEnabled = true;
            companySizeComboBox.Location = new Point(3, 155);
            companySizeComboBox.Name = "companySizeComboBox";
            companySizeComboBox.Size = new Size(419, 29);
            companySizeComboBox.TabIndex = 2;
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
            // companyNameValidationLbl
            // 
            companyNameValidationLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            companyNameValidationLbl.AutoSize = true;
            companyNameValidationLbl.ForeColor = Color.Maroon;
            companyNameValidationLbl.Location = new Point(3, 102);
            companyNameValidationLbl.Name = "companyNameValidationLbl";
            companyNameValidationLbl.Size = new Size(206, 21);
            companyNameValidationLbl.TabIndex = 33;
            companyNameValidationLbl.Text = "companyNameValidationLbl";
            companyNameValidationLbl.Visible = false;
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
            // companySizeLbl
            // 
            companySizeLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            companySizeLbl.AutoSize = true;
            companySizeLbl.Location = new Point(3, 131);
            companySizeLbl.Name = "companySizeLbl";
            companySizeLbl.Size = new Size(165, 21);
            companySizeLbl.TabIndex = 11;
            companySizeLbl.Text = "Number of employees";
            // 
            // companyNameLbl
            // 
            companyNameLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            companyNameLbl.AutoSize = true;
            companyNameLbl.Location = new Point(3, 46);
            companyNameLbl.Name = "companyNameLbl";
            companyNameLbl.Size = new Size(120, 21);
            companyNameLbl.TabIndex = 10;
            companyNameLbl.Text = "Company name";
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
            // locationTxtBox
            // 
            locationTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            locationTxtBox.Location = new Point(3, 240);
            locationTxtBox.Name = "locationTxtBox";
            locationTxtBox.Size = new Size(419, 29);
            locationTxtBox.TabIndex = 3;
            // 
            // companyNameTxtBox
            // 
            companyNameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            companyNameTxtBox.Location = new Point(3, 70);
            companyNameTxtBox.Name = "companyNameTxtBox";
            companyNameTxtBox.Size = new Size(419, 29);
            companyNameTxtBox.TabIndex = 1;
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
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // EmployerProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 661);
            Controls.Add(profileSettingsPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "EmployerProfile";
            Padding = new Padding(230, 100, 230, 100);
            Text = "EmployerProfile";
            Load += EmployerProfile_Load;
            profileSettingsPanel.ResumeLayout(false);
            profileSettingsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel profileSettingsPanel;
        private Label locationValidationLbl;
        private Label companyNameValidationLbl;
        private Label locationLbl;
        private Label companySizeLbl;
        private Label companyNameLbl;
        private Label profileSettingsLbl;
        private TextBox locationTxtBox;
        private TextBox companyNameTxtBox;
        private Button saveBtn;
        private ComboBox companySizeComboBox;
        private Label successMessageProfileLbl;
    }
}