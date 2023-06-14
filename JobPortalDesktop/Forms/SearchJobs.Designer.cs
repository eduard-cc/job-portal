namespace JobPortalDesktop.Forms
{
    partial class SearchJobs
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            topPanel = new Panel();
            findJobsBtn = new Button();
            locationTxtBox = new TextBox();
            locationIcon = new PictureBox();
            searchIcon = new PictureBox();
            jobTitleOrCompanyTxtBox = new TextBox();
            mainPanel = new Panel();
            jobsDataGridView = new DataGridView();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)locationIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jobsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(findJobsBtn);
            topPanel.Controls.Add(locationTxtBox);
            topPanel.Controls.Add(locationIcon);
            topPanel.Controls.Add(searchIcon);
            topPanel.Controls.Add(jobTitleOrCompanyTxtBox);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(20, 20);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(100, 20, 100, 20);
            topPanel.Size = new Size(829, 76);
            topPanel.TabIndex = 0;
            // 
            // findJobsBtn
            // 
            findJobsBtn.Anchor = AnchorStyles.None;
            findJobsBtn.BackColor = Color.FromArgb(51, 89, 161);
            findJobsBtn.Cursor = Cursors.Hand;
            findJobsBtn.FlatAppearance.BorderSize = 0;
            findJobsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 68, 123);
            findJobsBtn.FlatStyle = FlatStyle.Flat;
            findJobsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            findJobsBtn.ForeColor = Color.White;
            findJobsBtn.Location = new Point(590, 19);
            findJobsBtn.Margin = new Padding(4);
            findJobsBtn.Name = "findJobsBtn";
            findJobsBtn.Size = new Size(135, 35);
            findJobsBtn.TabIndex = 5;
            findJobsBtn.Text = "Find jobs";
            findJobsBtn.UseVisualStyleBackColor = false;
            findJobsBtn.Click += findJobsBtn_Click;
            // 
            // locationTxtBox
            // 
            locationTxtBox.Anchor = AnchorStyles.None;
            locationTxtBox.Location = new Point(362, 23);
            locationTxtBox.Name = "locationTxtBox";
            locationTxtBox.PlaceholderText = "City or country";
            locationTxtBox.Size = new Size(187, 29);
            locationTxtBox.TabIndex = 2;
            // 
            // locationIcon
            // 
            locationIcon.Anchor = AnchorStyles.None;
            locationIcon.Image = Properties.Resources.location_icon;
            locationIcon.Location = new Point(327, 23);
            locationIcon.Name = "locationIcon";
            locationIcon.Size = new Size(29, 29);
            locationIcon.SizeMode = PictureBoxSizeMode.Zoom;
            locationIcon.TabIndex = 3;
            locationIcon.TabStop = false;
            // 
            // searchIcon
            // 
            searchIcon.Anchor = AnchorStyles.None;
            searchIcon.Image = Properties.Resources.search_icon1;
            searchIcon.Location = new Point(68, 23);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(29, 29);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 1;
            searchIcon.TabStop = false;
            // 
            // jobTitleOrCompanyTxtBox
            // 
            jobTitleOrCompanyTxtBox.Anchor = AnchorStyles.None;
            jobTitleOrCompanyTxtBox.Location = new Point(103, 23);
            jobTitleOrCompanyTxtBox.Name = "jobTitleOrCompanyTxtBox";
            jobTitleOrCompanyTxtBox.PlaceholderText = "Job title or company";
            jobTitleOrCompanyTxtBox.Size = new Size(189, 29);
            jobTitleOrCompanyTxtBox.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(jobsDataGridView);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(20, 96);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(829, 506);
            mainPanel.TabIndex = 1;
            // 
            // jobsDataGridView
            // 
            jobsDataGridView.AllowUserToAddRows = false;
            jobsDataGridView.AllowUserToDeleteRows = false;
            jobsDataGridView.AllowUserToResizeColumns = false;
            jobsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(55, 65, 81);
            jobsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            jobsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            jobsDataGridView.BackgroundColor = SystemColors.Control;
            jobsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            jobsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            jobsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            jobsDataGridView.ColumnHeadersHeight = 50;
            jobsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            jobsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            jobsDataGridView.Dock = DockStyle.Fill;
            jobsDataGridView.EnableHeadersVisualStyles = false;
            jobsDataGridView.Location = new Point(0, 0);
            jobsDataGridView.MultiSelect = false;
            jobsDataGridView.Name = "jobsDataGridView";
            jobsDataGridView.ReadOnly = true;
            jobsDataGridView.RowHeadersVisible = false;
            jobsDataGridView.RowTemplate.Height = 80;
            jobsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            jobsDataGridView.Size = new Size(829, 506);
            jobsDataGridView.TabIndex = 0;
            jobsDataGridView.CellClick += jobsDataGridView_CellClick;
            jobsDataGridView.CellFormatting += jobsDataGridView_CellFormatting;
            // 
            // SearchJobs
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 622);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SearchJobs";
            Padding = new Padding(20);
            Text = "SearchJobs";
            Load += SearchJobs_LoadAsync;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)locationIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)jobsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private PictureBox searchIcon;
        private TextBox jobTitleOrCompanyTxtBox;
        private TextBox locationTxtBox;
        private PictureBox locationIcon;
        private Button findJobsBtn;
        private Panel mainPanel;
        private DataGridView jobsDataGridView;
        private DataGridViewTextBoxColumn employerDataGridViewTextBoxColumn;
    }
}