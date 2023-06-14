namespace JobPortalDesktop.Forms
{
    partial class EmployerJobs
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
            mainPanel = new Panel();
            jobsDataGridView = new DataGridView();
            topPanel = new Panel();
            postJobBtn = new Button();
            jobsLbl = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jobsDataGridView).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(jobsDataGridView);
            mainPanel.Controls.Add(topPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(20, 20);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(813, 543);
            mainPanel.TabIndex = 0;
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
            jobsDataGridView.Location = new Point(0, 51);
            jobsDataGridView.Margin = new Padding(4);
            jobsDataGridView.MultiSelect = false;
            jobsDataGridView.Name = "jobsDataGridView";
            jobsDataGridView.ReadOnly = true;
            jobsDataGridView.RowHeadersVisible = false;
            jobsDataGridView.RowTemplate.Height = 80;
            jobsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            jobsDataGridView.Size = new Size(813, 492);
            jobsDataGridView.TabIndex = 2;
            jobsDataGridView.CellClick += jobsDataGridView_CellClick;
            jobsDataGridView.CellFormatting += jobsDataGridView_CellFormatting;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(postJobBtn);
            topPanel.Controls.Add(jobsLbl);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(813, 51);
            topPanel.TabIndex = 0;
            // 
            // postJobBtn
            // 
            postJobBtn.Anchor = AnchorStyles.Right;
            postJobBtn.BackColor = Color.FromArgb(51, 89, 161);
            postJobBtn.Cursor = Cursors.Hand;
            postJobBtn.FlatAppearance.BorderSize = 0;
            postJobBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 68, 123);
            postJobBtn.FlatStyle = FlatStyle.Flat;
            postJobBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            postJobBtn.ForeColor = Color.White;
            postJobBtn.Image = Properties.Resources.post_job_icon;
            postJobBtn.ImageAlign = ContentAlignment.MiddleRight;
            postJobBtn.Location = new Point(621, 4);
            postJobBtn.Margin = new Padding(4);
            postJobBtn.Name = "postJobBtn";
            postJobBtn.Size = new Size(188, 43);
            postJobBtn.TabIndex = 18;
            postJobBtn.Text = " Post a job";
            postJobBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            postJobBtn.UseVisualStyleBackColor = false;
            postJobBtn.Click += postJobBtn_Click;
            // 
            // jobsLbl
            // 
            jobsLbl.Anchor = AnchorStyles.Left;
            jobsLbl.AutoSize = true;
            jobsLbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            jobsLbl.Location = new Point(10, 10);
            jobsLbl.Name = "jobsLbl";
            jobsLbl.Size = new Size(56, 30);
            jobsLbl.TabIndex = 1;
            jobsLbl.Text = "Jobs";
            // 
            // EmployerJobs
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 583);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "EmployerJobs";
            Padding = new Padding(20);
            Text = "EmployerJobs";
            Load += EmployerJobs_Load;
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)jobsDataGridView).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel topPanel;
        private Label jobsLbl;
        private Button postJobBtn;
        private DataGridView jobsDataGridView;
    }
}