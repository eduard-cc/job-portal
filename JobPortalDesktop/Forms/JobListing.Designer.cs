namespace JobPortalDesktop.Forms
{
    partial class JobListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobListing));
            jobBodyPanel = new Panel();
            deleteBtn = new Button();
            dashboardBtn = new Button();
            editBtn = new Button();
            applicationDateApplied = new Label();
            applyPanel = new Panel();
            applyBtn = new Button();
            applicationStatusIcon = new PictureBox();
            alreadyAppliedLbl = new Label();
            saveBtn = new Button();
            descriptionTitleLbl = new Label();
            salaryLbl = new Label();
            contractTypeLbl = new Label();
            workArrangementLbl = new Label();
            locationLbl = new Label();
            salaryIcon = new PictureBox();
            salaryTitleLbl = new Label();
            contractTypeIcon = new PictureBox();
            contractTypeTitleLbl = new Label();
            workArrangementIcon = new PictureBox();
            workArrangementTitleLbl = new Label();
            locationIcon = new PictureBox();
            locationTitleLbl = new Label();
            descriptionRichTxtBox = new RichTextBox();
            companyNameLbl = new Label();
            titleLbl = new Label();
            jobBodyPanel.SuspendLayout();
            applyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)applicationStatusIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contractTypeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workArrangementIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationIcon).BeginInit();
            SuspendLayout();
            // 
            // jobBodyPanel
            // 
            jobBodyPanel.BackColor = Color.FromArgb(250, 248, 251);
            jobBodyPanel.BorderStyle = BorderStyle.FixedSingle;
            jobBodyPanel.Controls.Add(deleteBtn);
            jobBodyPanel.Controls.Add(dashboardBtn);
            jobBodyPanel.Controls.Add(editBtn);
            jobBodyPanel.Controls.Add(applicationDateApplied);
            jobBodyPanel.Controls.Add(applyPanel);
            jobBodyPanel.Controls.Add(saveBtn);
            jobBodyPanel.Controls.Add(descriptionTitleLbl);
            jobBodyPanel.Controls.Add(salaryLbl);
            jobBodyPanel.Controls.Add(contractTypeLbl);
            jobBodyPanel.Controls.Add(workArrangementLbl);
            jobBodyPanel.Controls.Add(locationLbl);
            jobBodyPanel.Controls.Add(salaryIcon);
            jobBodyPanel.Controls.Add(salaryTitleLbl);
            jobBodyPanel.Controls.Add(contractTypeIcon);
            jobBodyPanel.Controls.Add(contractTypeTitleLbl);
            jobBodyPanel.Controls.Add(workArrangementIcon);
            jobBodyPanel.Controls.Add(workArrangementTitleLbl);
            jobBodyPanel.Controls.Add(locationIcon);
            jobBodyPanel.Controls.Add(locationTitleLbl);
            jobBodyPanel.Controls.Add(descriptionRichTxtBox);
            jobBodyPanel.Controls.Add(companyNameLbl);
            jobBodyPanel.Controls.Add(titleLbl);
            jobBodyPanel.Dock = DockStyle.Fill;
            jobBodyPanel.Location = new Point(20, 20);
            jobBodyPanel.Name = "jobBodyPanel";
            jobBodyPanel.Padding = new Padding(10);
            jobBodyPanel.Size = new Size(894, 571);
            jobBodyPanel.TabIndex = 0;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Image = Properties.Resources.delete_icon_32;
            deleteBtn.Location = new Point(825, 13);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(54, 52);
            deleteBtn.TabIndex = 22;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Visible = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dashboardBtn.Cursor = Cursors.Hand;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Image = Properties.Resources.card_list_icon;
            dashboardBtn.Location = new Point(679, 13);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(54, 52);
            dashboardBtn.TabIndex = 21;
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Visible = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editBtn.Cursor = Cursors.Hand;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Image = Properties.Resources.edit_icon;
            editBtn.Location = new Point(752, 13);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(54, 52);
            editBtn.TabIndex = 20;
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Visible = false;
            editBtn.Click += editBtn_Click;
            // 
            // applicationDateApplied
            // 
            applicationDateApplied.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            applicationDateApplied.AutoSize = true;
            applicationDateApplied.ForeColor = Color.Navy;
            applicationDateApplied.Location = new Point(516, 29);
            applicationDateApplied.Name = "applicationDateApplied";
            applicationDateApplied.RightToLeft = RightToLeft.No;
            applicationDateApplied.Size = new Size(93, 21);
            applicationDateApplied.TabIndex = 19;
            applicationDateApplied.Text = "dateApplied";
            applicationDateApplied.Visible = false;
            // 
            // applyPanel
            // 
            applyPanel.Controls.Add(applyBtn);
            applyPanel.Controls.Add(applicationStatusIcon);
            applyPanel.Controls.Add(alreadyAppliedLbl);
            applyPanel.Dock = DockStyle.Bottom;
            applyPanel.Location = new Point(10, 517);
            applyPanel.Name = "applyPanel";
            applyPanel.Size = new Size(872, 42);
            applyPanel.TabIndex = 18;
            // 
            // applyBtn
            // 
            applyBtn.BackColor = Color.FromArgb(51, 89, 161);
            applyBtn.Cursor = Cursors.Hand;
            applyBtn.Dock = DockStyle.Fill;
            applyBtn.FlatAppearance.BorderSize = 0;
            applyBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 68, 123);
            applyBtn.FlatStyle = FlatStyle.Flat;
            applyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            applyBtn.ForeColor = Color.White;
            applyBtn.Location = new Point(0, 0);
            applyBtn.Margin = new Padding(4);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(872, 42);
            applyBtn.TabIndex = 17;
            applyBtn.Text = "Apply";
            applyBtn.UseVisualStyleBackColor = false;
            applyBtn.Click += applyBtn_Click;
            // 
            // applicationStatusIcon
            // 
            applicationStatusIcon.Anchor = AnchorStyles.None;
            applicationStatusIcon.Location = new Point(365, 11);
            applicationStatusIcon.Name = "applicationStatusIcon";
            applicationStatusIcon.Size = new Size(22, 22);
            applicationStatusIcon.SizeMode = PictureBoxSizeMode.Zoom;
            applicationStatusIcon.TabIndex = 1;
            applicationStatusIcon.TabStop = false;
            applicationStatusIcon.Visible = false;
            // 
            // alreadyAppliedLbl
            // 
            alreadyAppliedLbl.Anchor = AnchorStyles.None;
            alreadyAppliedLbl.AutoSize = true;
            alreadyAppliedLbl.Location = new Point(393, 11);
            alreadyAppliedLbl.Name = "alreadyAppliedLbl";
            alreadyAppliedLbl.Size = new Size(114, 21);
            alreadyAppliedLbl.TabIndex = 0;
            alreadyAppliedLbl.Text = "alreadyApplied";
            alreadyAppliedLbl.Visible = false;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Image = Properties.Resources.unsaved_icon;
            saveBtn.Location = new Point(825, 13);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(54, 52);
            saveBtn.TabIndex = 16;
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // descriptionTitleLbl
            // 
            descriptionTitleLbl.AutoSize = true;
            descriptionTitleLbl.Location = new Point(13, 167);
            descriptionTitleLbl.Name = "descriptionTitleLbl";
            descriptionTitleLbl.Size = new Size(115, 21);
            descriptionTitleLbl.TabIndex = 15;
            descriptionTitleLbl.Text = "Job description";
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Location = new Point(628, 119);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(51, 21);
            salaryLbl.TabIndex = 14;
            salaryLbl.Text = "salary";
            // 
            // contractTypeLbl
            // 
            contractTypeLbl.AutoSize = true;
            contractTypeLbl.Location = new Point(423, 120);
            contractTypeLbl.Name = "contractTypeLbl";
            contractTypeLbl.Size = new Size(98, 21);
            contractTypeLbl.TabIndex = 13;
            contractTypeLbl.Text = "contractType";
            // 
            // workArrangementLbl
            // 
            workArrangementLbl.AutoSize = true;
            workArrangementLbl.Location = new Point(218, 120);
            workArrangementLbl.Name = "workArrangementLbl";
            workArrangementLbl.Size = new Size(137, 21);
            workArrangementLbl.TabIndex = 12;
            workArrangementLbl.Text = "workArrangement";
            // 
            // locationLbl
            // 
            locationLbl.AutoSize = true;
            locationLbl.Location = new Point(13, 120);
            locationLbl.Name = "locationLbl";
            locationLbl.Size = new Size(65, 21);
            locationLbl.TabIndex = 11;
            locationLbl.Text = "location";
            // 
            // salaryIcon
            // 
            salaryIcon.Image = Properties.Resources.salary_icon;
            salaryIcon.Location = new Point(628, 94);
            salaryIcon.Name = "salaryIcon";
            salaryIcon.Size = new Size(22, 22);
            salaryIcon.SizeMode = PictureBoxSizeMode.Zoom;
            salaryIcon.TabIndex = 10;
            salaryIcon.TabStop = false;
            // 
            // salaryTitleLbl
            // 
            salaryTitleLbl.AutoSize = true;
            salaryTitleLbl.Location = new Point(656, 94);
            salaryTitleLbl.Name = "salaryTitleLbl";
            salaryTitleLbl.Size = new Size(53, 21);
            salaryTitleLbl.TabIndex = 9;
            salaryTitleLbl.Text = "Salary";
            // 
            // contractTypeIcon
            // 
            contractTypeIcon.Image = Properties.Resources.contract_type_icon;
            contractTypeIcon.Location = new Point(423, 95);
            contractTypeIcon.Name = "contractTypeIcon";
            contractTypeIcon.Size = new Size(22, 22);
            contractTypeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            contractTypeIcon.TabIndex = 8;
            contractTypeIcon.TabStop = false;
            // 
            // contractTypeTitleLbl
            // 
            contractTypeTitleLbl.AutoSize = true;
            contractTypeTitleLbl.Location = new Point(451, 94);
            contractTypeTitleLbl.Name = "contractTypeTitleLbl";
            contractTypeTitleLbl.Size = new Size(68, 21);
            contractTypeTitleLbl.TabIndex = 7;
            contractTypeTitleLbl.Text = "Job type";
            // 
            // workArrangementIcon
            // 
            workArrangementIcon.Image = Properties.Resources.calendar_icon;
            workArrangementIcon.Location = new Point(218, 95);
            workArrangementIcon.Name = "workArrangementIcon";
            workArrangementIcon.Size = new Size(22, 22);
            workArrangementIcon.SizeMode = PictureBoxSizeMode.Zoom;
            workArrangementIcon.TabIndex = 6;
            workArrangementIcon.TabStop = false;
            // 
            // workArrangementTitleLbl
            // 
            workArrangementTitleLbl.AutoSize = true;
            workArrangementTitleLbl.Location = new Point(246, 94);
            workArrangementTitleLbl.Name = "workArrangementTitleLbl";
            workArrangementTitleLbl.Size = new Size(47, 21);
            workArrangementTitleLbl.TabIndex = 5;
            workArrangementTitleLbl.Text = "Work";
            // 
            // locationIcon
            // 
            locationIcon.Image = Properties.Resources.location_icon;
            locationIcon.Location = new Point(13, 95);
            locationIcon.Name = "locationIcon";
            locationIcon.Size = new Size(22, 22);
            locationIcon.SizeMode = PictureBoxSizeMode.Zoom;
            locationIcon.TabIndex = 4;
            locationIcon.TabStop = false;
            // 
            // locationTitleLbl
            // 
            locationTitleLbl.AutoSize = true;
            locationTitleLbl.Location = new Point(41, 94);
            locationTitleLbl.Name = "locationTitleLbl";
            locationTitleLbl.Size = new Size(69, 21);
            locationTitleLbl.TabIndex = 3;
            locationTitleLbl.Text = "Location";
            // 
            // descriptionRichTxtBox
            // 
            descriptionRichTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionRichTxtBox.BackColor = Color.FromArgb(250, 248, 251);
            descriptionRichTxtBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionRichTxtBox.Location = new Point(13, 191);
            descriptionRichTxtBox.Name = "descriptionRichTxtBox";
            descriptionRichTxtBox.ReadOnly = true;
            descriptionRichTxtBox.Size = new Size(868, 308);
            descriptionRichTxtBox.TabIndex = 2;
            descriptionRichTxtBox.Text = "";
            // 
            // companyNameLbl
            // 
            companyNameLbl.AutoSize = true;
            companyNameLbl.Location = new Point(13, 52);
            companyNameLbl.Name = "companyNameLbl";
            companyNameLbl.Size = new Size(116, 21);
            companyNameLbl.TabIndex = 1;
            companyNameLbl.Text = "companyName";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.Location = new Point(13, 10);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(49, 30);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "title";
            // 
            // JobListing
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(jobBodyPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(950, 650);
            Name = "JobListing";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Job listing";
            FormClosed += JobListing_FormClosed;
            Load += JobListing_Load;
            jobBodyPanel.ResumeLayout(false);
            jobBodyPanel.PerformLayout();
            applyPanel.ResumeLayout(false);
            applyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)applicationStatusIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)contractTypeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)workArrangementIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel jobBodyPanel;
        private Label companyNameLbl;
        private Label titleLbl;
        private RichTextBox descriptionRichTxtBox;
        private Label locationLbl;
        private PictureBox salaryIcon;
        private Label salaryTitleLbl;
        private PictureBox contractTypeIcon;
        private Label contractTypeTitleLbl;
        private PictureBox workArrangementIcon;
        private Label workArrangementTitleLbl;
        private PictureBox locationIcon;
        private Label locationTitleLbl;
        private Label descriptionTitleLbl;
        private Label salaryLbl;
        private Label contractTypeLbl;
        private Label workArrangementLbl;
        private Button saveBtn;
        private Panel applyPanel;
        private Button applyBtn;
        private Label alreadyAppliedLbl;
        private PictureBox applicationStatusIcon;
        private Label applicationDateApplied;
        private Button editBtn;
        private Button dashboardBtn;
        private Button deleteBtn;
    }
}