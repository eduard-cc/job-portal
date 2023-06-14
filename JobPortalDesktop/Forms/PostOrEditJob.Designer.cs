namespace JobPortalDesktop.Forms
{
    partial class PostOrEditJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostOrEditJob));
            mainPanel = new Panel();
            bodyPanel = new Panel();
            maxAmountLbl = new Label();
            minAmountLbl = new Label();
            maxAmountTxtBox = new TextBox();
            minAmountTxtBox = new TextBox();
            exactAmountLbl = new Label();
            exactAmountTxtBox = new TextBox();
            amountValidationLbl = new Label();
            submitBtn = new Button();
            jobDescriptionValidationLbl = new Label();
            salaryRateLbl = new Label();
            jobTitleValidationLbl = new Label();
            salaryRateComboBox = new ComboBox();
            salaryTypeLbl = new Label();
            salaryTypeComboBox = new ComboBox();
            workArrangementComboBox = new ComboBox();
            workArrangementLbl = new Label();
            contractTypeLbl = new Label();
            contractTypeComboBox = new ComboBox();
            jobDescriptionTxtBox = new RichTextBox();
            jobDescriptionLbl = new Label();
            jobTitleTxtBox = new TextBox();
            jobTitleLbl = new Label();
            topPanel = new Panel();
            headerLbl = new Label();
            mainPanel.SuspendLayout();
            bodyPanel.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(250, 248, 251);
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(bodyPanel);
            mainPanel.Controls.Add(topPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(10, 10);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(728, 826);
            mainPanel.TabIndex = 0;
            // 
            // bodyPanel
            // 
            bodyPanel.Controls.Add(maxAmountLbl);
            bodyPanel.Controls.Add(minAmountLbl);
            bodyPanel.Controls.Add(maxAmountTxtBox);
            bodyPanel.Controls.Add(minAmountTxtBox);
            bodyPanel.Controls.Add(exactAmountLbl);
            bodyPanel.Controls.Add(exactAmountTxtBox);
            bodyPanel.Controls.Add(amountValidationLbl);
            bodyPanel.Controls.Add(submitBtn);
            bodyPanel.Controls.Add(jobDescriptionValidationLbl);
            bodyPanel.Controls.Add(salaryRateLbl);
            bodyPanel.Controls.Add(jobTitleValidationLbl);
            bodyPanel.Controls.Add(salaryRateComboBox);
            bodyPanel.Controls.Add(salaryTypeLbl);
            bodyPanel.Controls.Add(salaryTypeComboBox);
            bodyPanel.Controls.Add(workArrangementComboBox);
            bodyPanel.Controls.Add(workArrangementLbl);
            bodyPanel.Controls.Add(contractTypeLbl);
            bodyPanel.Controls.Add(contractTypeComboBox);
            bodyPanel.Controls.Add(jobDescriptionTxtBox);
            bodyPanel.Controls.Add(jobDescriptionLbl);
            bodyPanel.Controls.Add(jobTitleTxtBox);
            bodyPanel.Controls.Add(jobTitleLbl);
            bodyPanel.Dock = DockStyle.Fill;
            bodyPanel.Location = new Point(0, 51);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Padding = new Padding(20);
            bodyPanel.Size = new Size(726, 773);
            bodyPanel.TabIndex = 1;
            // 
            // maxAmountLbl
            // 
            maxAmountLbl.AutoSize = true;
            maxAmountLbl.Location = new Point(251, 613);
            maxAmountLbl.Name = "maxAmountLbl";
            maxAmountLbl.Size = new Size(97, 21);
            maxAmountLbl.TabIndex = 38;
            maxAmountLbl.Text = "Max amount";
            // 
            // minAmountLbl
            // 
            minAmountLbl.AutoSize = true;
            minAmountLbl.Location = new Point(23, 613);
            minAmountLbl.Name = "minAmountLbl";
            minAmountLbl.Size = new Size(95, 21);
            minAmountLbl.TabIndex = 37;
            minAmountLbl.Text = "Min amount";
            // 
            // maxAmountTxtBox
            // 
            maxAmountTxtBox.Location = new Point(251, 637);
            maxAmountTxtBox.Name = "maxAmountTxtBox";
            maxAmountTxtBox.Size = new Size(223, 29);
            maxAmountTxtBox.TabIndex = 36;
            // 
            // minAmountTxtBox
            // 
            minAmountTxtBox.Location = new Point(20, 637);
            minAmountTxtBox.Name = "minAmountTxtBox";
            minAmountTxtBox.Size = new Size(223, 29);
            minAmountTxtBox.TabIndex = 35;
            // 
            // exactAmountLbl
            // 
            exactAmountLbl.AutoSize = true;
            exactAmountLbl.Location = new Point(20, 613);
            exactAmountLbl.Name = "exactAmountLbl";
            exactAmountLbl.Size = new Size(66, 21);
            exactAmountLbl.TabIndex = 34;
            exactAmountLbl.Text = "Amount";
            // 
            // exactAmountTxtBox
            // 
            exactAmountTxtBox.Location = new Point(20, 637);
            exactAmountTxtBox.Name = "exactAmountTxtBox";
            exactAmountTxtBox.Size = new Size(454, 29);
            exactAmountTxtBox.TabIndex = 33;
            // 
            // amountValidationLbl
            // 
            amountValidationLbl.AutoSize = true;
            amountValidationLbl.ForeColor = Color.Maroon;
            amountValidationLbl.Location = new Point(20, 669);
            amountValidationLbl.Name = "amountValidationLbl";
            amountValidationLbl.Size = new Size(154, 21);
            amountValidationLbl.TabIndex = 32;
            amountValidationLbl.Text = "amountValidationLbl";
            amountValidationLbl.Visible = false;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(25, 128, 80);
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.Dock = DockStyle.Bottom;
            submitBtn.FlatAppearance.BorderSize = 0;
            submitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 110, 69);
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(20, 702);
            submitBtn.Margin = new Padding(4);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(686, 51);
            submitBtn.TabIndex = 27;
            submitBtn.Text = "Post job";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // jobDescriptionValidationLbl
            // 
            jobDescriptionValidationLbl.AutoSize = true;
            jobDescriptionValidationLbl.ForeColor = Color.Maroon;
            jobDescriptionValidationLbl.Location = new Point(23, 355);
            jobDescriptionValidationLbl.Name = "jobDescriptionValidationLbl";
            jobDescriptionValidationLbl.Size = new Size(201, 21);
            jobDescriptionValidationLbl.TabIndex = 26;
            jobDescriptionValidationLbl.Text = "jobDescriptionValidationLbl";
            jobDescriptionValidationLbl.Visible = false;
            // 
            // salaryRateLbl
            // 
            salaryRateLbl.AutoSize = true;
            salaryRateLbl.Location = new Point(496, 613);
            salaryRateLbl.Name = "salaryRateLbl";
            salaryRateLbl.Size = new Size(41, 21);
            salaryRateLbl.TabIndex = 15;
            salaryRateLbl.Text = "Rate";
            // 
            // jobTitleValidationLbl
            // 
            jobTitleValidationLbl.AutoSize = true;
            jobTitleValidationLbl.ForeColor = Color.Maroon;
            jobTitleValidationLbl.Location = new Point(23, 76);
            jobTitleValidationLbl.Name = "jobTitleValidationLbl";
            jobTitleValidationLbl.Size = new Size(151, 21);
            jobTitleValidationLbl.TabIndex = 25;
            jobTitleValidationLbl.Text = "jobTitleValidationLbl";
            jobTitleValidationLbl.Visible = false;
            // 
            // salaryRateComboBox
            // 
            salaryRateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            salaryRateComboBox.FormattingEnabled = true;
            salaryRateComboBox.Location = new Point(496, 637);
            salaryRateComboBox.Name = "salaryRateComboBox";
            salaryRateComboBox.Size = new Size(207, 29);
            salaryRateComboBox.TabIndex = 14;
            // 
            // salaryTypeLbl
            // 
            salaryTypeLbl.AutoSize = true;
            salaryTypeLbl.Location = new Point(23, 530);
            salaryTypeLbl.Name = "salaryTypeLbl";
            salaryTypeLbl.Size = new Size(87, 21);
            salaryTypeLbl.TabIndex = 13;
            salaryTypeLbl.Text = "Salary type";
            // 
            // salaryTypeComboBox
            // 
            salaryTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            salaryTypeComboBox.FormattingEnabled = true;
            salaryTypeComboBox.Location = new Point(23, 554);
            salaryTypeComboBox.Name = "salaryTypeComboBox";
            salaryTypeComboBox.Size = new Size(680, 29);
            salaryTypeComboBox.TabIndex = 12;
            salaryTypeComboBox.SelectedIndexChanged += salaryTypeComboBox_SelectedIndexChanged;
            // 
            // workArrangementComboBox
            // 
            workArrangementComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            workArrangementComboBox.FormattingEnabled = true;
            workArrangementComboBox.Location = new Point(23, 477);
            workArrangementComboBox.Name = "workArrangementComboBox";
            workArrangementComboBox.Size = new Size(680, 29);
            workArrangementComboBox.TabIndex = 11;
            // 
            // workArrangementLbl
            // 
            workArrangementLbl.AutoSize = true;
            workArrangementLbl.Location = new Point(23, 453);
            workArrangementLbl.Name = "workArrangementLbl";
            workArrangementLbl.Size = new Size(141, 21);
            workArrangementLbl.TabIndex = 10;
            workArrangementLbl.Text = "Work arrangement";
            // 
            // contractTypeLbl
            // 
            contractTypeLbl.AutoSize = true;
            contractTypeLbl.Location = new Point(23, 376);
            contractTypeLbl.Name = "contractTypeLbl";
            contractTypeLbl.Size = new Size(103, 21);
            contractTypeLbl.TabIndex = 9;
            contractTypeLbl.Text = "Contract type";
            // 
            // contractTypeComboBox
            // 
            contractTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            contractTypeComboBox.FormattingEnabled = true;
            contractTypeComboBox.Location = new Point(23, 400);
            contractTypeComboBox.Name = "contractTypeComboBox";
            contractTypeComboBox.Size = new Size(680, 29);
            contractTypeComboBox.TabIndex = 8;
            // 
            // jobDescriptionTxtBox
            // 
            jobDescriptionTxtBox.Location = new Point(23, 121);
            jobDescriptionTxtBox.Name = "jobDescriptionTxtBox";
            jobDescriptionTxtBox.Size = new Size(680, 231);
            jobDescriptionTxtBox.TabIndex = 7;
            jobDescriptionTxtBox.Text = "";
            // 
            // jobDescriptionLbl
            // 
            jobDescriptionLbl.AutoSize = true;
            jobDescriptionLbl.Location = new Point(23, 97);
            jobDescriptionLbl.Name = "jobDescriptionLbl";
            jobDescriptionLbl.Size = new Size(115, 21);
            jobDescriptionLbl.TabIndex = 5;
            jobDescriptionLbl.Text = "Job description";
            // 
            // jobTitleTxtBox
            // 
            jobTitleTxtBox.Location = new Point(23, 44);
            jobTitleTxtBox.Name = "jobTitleTxtBox";
            jobTitleTxtBox.Size = new Size(680, 29);
            jobTitleTxtBox.TabIndex = 4;
            // 
            // jobTitleLbl
            // 
            jobTitleLbl.AutoSize = true;
            jobTitleLbl.Location = new Point(23, 20);
            jobTitleLbl.Name = "jobTitleLbl";
            jobTitleLbl.Size = new Size(64, 21);
            jobTitleLbl.TabIndex = 3;
            jobTitleLbl.Text = "Job title";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(headerLbl);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(726, 51);
            topPanel.TabIndex = 0;
            // 
            // headerLbl
            // 
            headerLbl.Anchor = AnchorStyles.Left;
            headerLbl.AutoSize = true;
            headerLbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerLbl.Location = new Point(10, 10);
            headerLbl.Name = "headerLbl";
            headerLbl.Size = new Size(107, 30);
            headerLbl.TabIndex = 2;
            headerLbl.Text = "Post a job";
            // 
            // PostOrEditJob
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 846);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(764, 885);
            MinimumSize = new Size(764, 885);
            Name = "PostOrEditJob";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Post job";
            Load += PostOrEditJob_Load;
            mainPanel.ResumeLayout(false);
            bodyPanel.ResumeLayout(false);
            bodyPanel.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel topPanel;
        private Label headerLbl;
        private Panel bodyPanel;
        private RichTextBox jobDescriptionTxtBox;
        private Label jobDescriptionLbl;
        private TextBox jobTitleTxtBox;
        private Label jobTitleLbl;
        private Label workArrangementLbl;
        private Label contractTypeLbl;
        private ComboBox contractTypeComboBox;
        private Label salaryTypeLbl;
        private ComboBox salaryTypeComboBox;
        private ComboBox workArrangementComboBox;
        private Label jobTitleValidationLbl;
        private Label jobDescriptionValidationLbl;
        private Label salaryRateLbl;
        private ComboBox salaryRateComboBox;
        private Button submitBtn;
        private Label exactAmountLbl;
        private TextBox exactAmountTxtBox;
        private Label amountValidationLbl;
        private Label maxAmountLbl;
        private Label minAmountLbl;
        private TextBox maxAmountTxtBox;
        private TextBox minAmountTxtBox;
    }
}