namespace JobPortalDesktop.Forms
{
    partial class AppliedJobs
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
            appliedJobsDataGridView = new DataGridView();
            topPanel = new Panel();
            appliedJobsLbl = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appliedJobsDataGridView).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(appliedJobsDataGridView);
            mainPanel.Controls.Add(topPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(20, 20);
            mainPanel.Margin = new Padding(4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(813, 543);
            mainPanel.TabIndex = 1;
            // 
            // appliedJobsDataGridView
            // 
            appliedJobsDataGridView.AllowUserToAddRows = false;
            appliedJobsDataGridView.AllowUserToDeleteRows = false;
            appliedJobsDataGridView.AllowUserToResizeColumns = false;
            appliedJobsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(55, 65, 81);
            appliedJobsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            appliedJobsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appliedJobsDataGridView.BackgroundColor = SystemColors.Control;
            appliedJobsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            appliedJobsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            appliedJobsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            appliedJobsDataGridView.ColumnHeadersHeight = 50;
            appliedJobsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            appliedJobsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            appliedJobsDataGridView.Dock = DockStyle.Fill;
            appliedJobsDataGridView.EnableHeadersVisualStyles = false;
            appliedJobsDataGridView.Location = new Point(0, 51);
            appliedJobsDataGridView.Margin = new Padding(4);
            appliedJobsDataGridView.MultiSelect = false;
            appliedJobsDataGridView.Name = "appliedJobsDataGridView";
            appliedJobsDataGridView.ReadOnly = true;
            appliedJobsDataGridView.RowHeadersVisible = false;
            appliedJobsDataGridView.RowTemplate.Height = 80;
            appliedJobsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appliedJobsDataGridView.Size = new Size(813, 492);
            appliedJobsDataGridView.TabIndex = 1;
            appliedJobsDataGridView.CellClick += appliedJobsDataGridView_CellClick;
            appliedJobsDataGridView.CellFormatting += appliedJobsDataGridView_CellFormatting;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(appliedJobsLbl);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(813, 51);
            topPanel.TabIndex = 2;
            // 
            // appliedJobsLbl
            // 
            appliedJobsLbl.Anchor = AnchorStyles.Left;
            appliedJobsLbl.AutoSize = true;
            appliedJobsLbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            appliedJobsLbl.Location = new Point(10, 10);
            appliedJobsLbl.Name = "appliedJobsLbl";
            appliedJobsLbl.Size = new Size(134, 30);
            appliedJobsLbl.TabIndex = 0;
            appliedJobsLbl.Text = "Applied jobs";
            // 
            // AppliedJobs
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 583);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AppliedJobs";
            Padding = new Padding(20);
            Text = "AppliedJobs";
            Load += AppliedJobs_Load;
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appliedJobsDataGridView).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private DataGridView appliedJobsDataGridView;
        private Panel topPanel;
        private Label appliedJobsLbl;
    }
}