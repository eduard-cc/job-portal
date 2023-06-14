namespace JobPortalDesktop.Forms
{
    partial class SavedJobs
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
            savedJobsDataGridView = new DataGridView();
            topPanel = new Panel();
            savedJobsLbl = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)savedJobsDataGridView).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(savedJobsDataGridView);
            mainPanel.Controls.Add(topPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(20, 20);
            mainPanel.Margin = new Padding(4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(813, 543);
            mainPanel.TabIndex = 0;
            // 
            // savedJobsDataGridView
            // 
            savedJobsDataGridView.AllowUserToAddRows = false;
            savedJobsDataGridView.AllowUserToDeleteRows = false;
            savedJobsDataGridView.AllowUserToResizeColumns = false;
            savedJobsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(55, 65, 81);
            savedJobsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            savedJobsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            savedJobsDataGridView.BackgroundColor = SystemColors.Control;
            savedJobsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            savedJobsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            savedJobsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            savedJobsDataGridView.ColumnHeadersHeight = 50;
            savedJobsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            savedJobsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            savedJobsDataGridView.Dock = DockStyle.Fill;
            savedJobsDataGridView.EnableHeadersVisualStyles = false;
            savedJobsDataGridView.Location = new Point(0, 51);
            savedJobsDataGridView.Margin = new Padding(4);
            savedJobsDataGridView.MultiSelect = false;
            savedJobsDataGridView.Name = "savedJobsDataGridView";
            savedJobsDataGridView.ReadOnly = true;
            savedJobsDataGridView.RowHeadersVisible = false;
            savedJobsDataGridView.RowTemplate.Height = 80;
            savedJobsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            savedJobsDataGridView.Size = new Size(813, 492);
            savedJobsDataGridView.TabIndex = 1;
            savedJobsDataGridView.CellClick += savedJobsDataGridView_CellClick;
            savedJobsDataGridView.CellFormatting += savedJobsDataGridView_CellFormatting;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(savedJobsLbl);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(813, 51);
            topPanel.TabIndex = 2;
            // 
            // savedJobsLbl
            // 
            savedJobsLbl.Anchor = AnchorStyles.Left;
            savedJobsLbl.AutoSize = true;
            savedJobsLbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            savedJobsLbl.Location = new Point(10, 10);
            savedJobsLbl.Name = "savedJobsLbl";
            savedJobsLbl.Size = new Size(118, 30);
            savedJobsLbl.TabIndex = 0;
            savedJobsLbl.Text = "Saved jobs";
            // 
            // SavedJobs
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 583);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SavedJobs";
            Padding = new Padding(20);
            Text = "SavedJobs";
            Load += SavedJobs_Load;
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)savedJobsDataGridView).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private DataGridView savedJobsDataGridView;
        private Panel topPanel;
        private Label savedJobsLbl;
    }
}