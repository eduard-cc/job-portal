namespace JobPortalDesktop.Forms
{
    partial class JobApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobApplications));
            panel1 = new Panel();
            applicationsDataGridView = new DataGridView();
            panel2 = new Panel();
            jobsLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)applicationsDataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(applicationsDataGridView);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 471);
            panel1.TabIndex = 0;
            // 
            // applicationsDataGridView
            // 
            applicationsDataGridView.AllowUserToAddRows = false;
            applicationsDataGridView.AllowUserToDeleteRows = false;
            applicationsDataGridView.AllowUserToResizeColumns = false;
            applicationsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(55, 65, 81);
            applicationsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            applicationsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            applicationsDataGridView.BackgroundColor = SystemColors.Control;
            applicationsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            applicationsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            applicationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            applicationsDataGridView.ColumnHeadersHeight = 50;
            applicationsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 190, 121);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            applicationsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            applicationsDataGridView.Dock = DockStyle.Fill;
            applicationsDataGridView.EnableHeadersVisualStyles = false;
            applicationsDataGridView.Location = new Point(0, 51);
            applicationsDataGridView.Margin = new Padding(4);
            applicationsDataGridView.MultiSelect = false;
            applicationsDataGridView.Name = "applicationsDataGridView";
            applicationsDataGridView.RowHeadersVisible = false;
            applicationsDataGridView.RowTemplate.Height = 80;
            applicationsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            applicationsDataGridView.Size = new Size(794, 420);
            applicationsDataGridView.TabIndex = 3;
            applicationsDataGridView.CellBeginEdit += applicationsDataGridView_CellBeginEdit;
            applicationsDataGridView.CellFormatting += applicationsDataGridView_CellFormatting;
            applicationsDataGridView.CellPainting += applicationsDataGridView_CellPainting;
            applicationsDataGridView.CellValueChanged += applicationsDataGridView_CellValueChanged;
            applicationsDataGridView.CurrentCellDirtyStateChanged += applicationsDataGridView_CurrentCellDirtyStateChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(jobsLbl);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 51);
            panel2.TabIndex = 0;
            // 
            // jobsLbl
            // 
            jobsLbl.Anchor = AnchorStyles.Left;
            jobsLbl.AutoSize = true;
            jobsLbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            jobsLbl.Location = new Point(10, 10);
            jobsLbl.Name = "jobsLbl";
            jobsLbl.Size = new Size(120, 30);
            jobsLbl.TabIndex = 2;
            jobsLbl.Text = "Candidates";
            // 
            // JobApplications
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 511);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(850, 550);
            Name = "JobApplications";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Job applications";
            Load += JobApplications_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)applicationsDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label jobsLbl;
        private DataGridView applicationsDataGridView;
    }
}