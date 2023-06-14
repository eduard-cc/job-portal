namespace JobPortalDesktop.Forms
{
    partial class ApplyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyForm));
            nameIcon = new PictureBox();
            locationIcon = new PictureBox();
            phoneIcon = new PictureBox();
            emailIcon = new PictureBox();
            nameTitleLbl = new Label();
            locationTitleLbl = new Label();
            phoneTitleLbl = new Label();
            emailTitleLbl = new Label();
            applyBtn = new Button();
            panel1 = new Panel();
            fileFormatsLbl = new Label();
            uploadCvTitleLbl = new Label();
            uploadBtn = new Button();
            emailLbl = new Label();
            phoneLbl = new Label();
            locationLbl = new Label();
            nameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)nameIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phoneIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameIcon
            // 
            nameIcon.Image = Properties.Resources.user_icon;
            nameIcon.Location = new Point(13, 13);
            nameIcon.Name = "nameIcon";
            nameIcon.Size = new Size(22, 22);
            nameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            nameIcon.TabIndex = 0;
            nameIcon.TabStop = false;
            // 
            // locationIcon
            // 
            locationIcon.Image = Properties.Resources.location_icon;
            locationIcon.Location = new Point(13, 57);
            locationIcon.Name = "locationIcon";
            locationIcon.Size = new Size(22, 22);
            locationIcon.SizeMode = PictureBoxSizeMode.Zoom;
            locationIcon.TabIndex = 1;
            locationIcon.TabStop = false;
            // 
            // phoneIcon
            // 
            phoneIcon.Image = Properties.Resources.phone_icon;
            phoneIcon.Location = new Point(13, 101);
            phoneIcon.Name = "phoneIcon";
            phoneIcon.Size = new Size(22, 22);
            phoneIcon.SizeMode = PictureBoxSizeMode.Zoom;
            phoneIcon.TabIndex = 2;
            phoneIcon.TabStop = false;
            // 
            // emailIcon
            // 
            emailIcon.Image = Properties.Resources.email_icon;
            emailIcon.Location = new Point(13, 145);
            emailIcon.Name = "emailIcon";
            emailIcon.Size = new Size(22, 22);
            emailIcon.SizeMode = PictureBoxSizeMode.Zoom;
            emailIcon.TabIndex = 3;
            emailIcon.TabStop = false;
            // 
            // nameTitleLbl
            // 
            nameTitleLbl.AutoSize = true;
            nameTitleLbl.Location = new Point(41, 13);
            nameTitleLbl.Name = "nameTitleLbl";
            nameTitleLbl.Size = new Size(55, 21);
            nameTitleLbl.TabIndex = 4;
            nameTitleLbl.Text = "Name:";
            // 
            // locationTitleLbl
            // 
            locationTitleLbl.AutoSize = true;
            locationTitleLbl.Location = new Point(41, 57);
            locationTitleLbl.Name = "locationTitleLbl";
            locationTitleLbl.Size = new Size(72, 21);
            locationTitleLbl.TabIndex = 5;
            locationTitleLbl.Text = "Location:";
            // 
            // phoneTitleLbl
            // 
            phoneTitleLbl.AutoSize = true;
            phoneTitleLbl.Location = new Point(41, 101);
            phoneTitleLbl.Name = "phoneTitleLbl";
            phoneTitleLbl.Size = new Size(57, 21);
            phoneTitleLbl.TabIndex = 6;
            phoneTitleLbl.Text = "Phone:";
            // 
            // emailTitleLbl
            // 
            emailTitleLbl.AutoSize = true;
            emailTitleLbl.Location = new Point(41, 145);
            emailTitleLbl.Name = "emailTitleLbl";
            emailTitleLbl.Size = new Size(51, 21);
            emailTitleLbl.TabIndex = 7;
            emailTitleLbl.Text = "Email:";
            // 
            // applyBtn
            // 
            applyBtn.BackColor = Color.FromArgb(51, 89, 161);
            applyBtn.Cursor = Cursors.Hand;
            applyBtn.Dock = DockStyle.Bottom;
            applyBtn.FlatAppearance.BorderSize = 0;
            applyBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 68, 123);
            applyBtn.FlatStyle = FlatStyle.Flat;
            applyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            applyBtn.ForeColor = Color.White;
            applyBtn.Location = new Point(10, 347);
            applyBtn.Margin = new Padding(4);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(402, 42);
            applyBtn.TabIndex = 18;
            applyBtn.Text = "Apply";
            applyBtn.UseVisualStyleBackColor = false;
            applyBtn.Click += applyBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 248, 251);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(fileFormatsLbl);
            panel1.Controls.Add(uploadCvTitleLbl);
            panel1.Controls.Add(uploadBtn);
            panel1.Controls.Add(emailLbl);
            panel1.Controls.Add(phoneLbl);
            panel1.Controls.Add(locationLbl);
            panel1.Controls.Add(nameLbl);
            panel1.Controls.Add(applyBtn);
            panel1.Controls.Add(nameIcon);
            panel1.Controls.Add(emailTitleLbl);
            panel1.Controls.Add(locationIcon);
            panel1.Controls.Add(phoneTitleLbl);
            panel1.Controls.Add(phoneIcon);
            panel1.Controls.Add(locationTitleLbl);
            panel1.Controls.Add(emailIcon);
            panel1.Controls.Add(nameTitleLbl);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(424, 401);
            panel1.TabIndex = 19;
            // 
            // fileFormatsLbl
            // 
            fileFormatsLbl.AutoSize = true;
            fileFormatsLbl.Location = new Point(13, 283);
            fileFormatsLbl.Name = "fileFormatsLbl";
            fileFormatsLbl.Size = new Size(127, 21);
            fileFormatsLbl.TabIndex = 25;
            fileFormatsLbl.Text = "DOC, DOCX, PDF";
            // 
            // uploadCvTitleLbl
            // 
            uploadCvTitleLbl.AutoSize = true;
            uploadCvTitleLbl.Location = new Point(13, 193);
            uploadCvTitleLbl.Name = "uploadCvTitleLbl";
            uploadCvTitleLbl.Size = new Size(123, 21);
            uploadCvTitleLbl.TabIndex = 24;
            uploadCvTitleLbl.Text = "Upload your CV:";
            // 
            // uploadBtn
            // 
            uploadBtn.BackColor = Color.FromArgb(55, 65, 81);
            uploadBtn.Cursor = Cursors.Hand;
            uploadBtn.FlatAppearance.BorderSize = 0;
            uploadBtn.FlatStyle = FlatStyle.Flat;
            uploadBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uploadBtn.ForeColor = Color.White;
            uploadBtn.Location = new Point(13, 228);
            uploadBtn.Margin = new Padding(4);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(171, 42);
            uploadBtn.TabIndex = 23;
            uploadBtn.Text = "Choose file";
            uploadBtn.UseVisualStyleBackColor = false;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(98, 146);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(48, 21);
            emailLbl.TabIndex = 22;
            emailLbl.Text = "email";
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(104, 102);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(54, 21);
            phoneLbl.TabIndex = 21;
            phoneLbl.Text = "phone";
            // 
            // locationLbl
            // 
            locationLbl.AutoSize = true;
            locationLbl.Location = new Point(119, 57);
            locationLbl.Name = "locationLbl";
            locationLbl.Size = new Size(65, 21);
            locationLbl.TabIndex = 20;
            locationLbl.Text = "location";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(102, 13);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(49, 21);
            nameLbl.TabIndex = 19;
            nameLbl.Text = "name";
            // 
            // ApplyForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 441);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(480, 480);
            Name = "ApplyForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apply";
            Load += ApplyForm_Load;
            ((System.ComponentModel.ISupportInitialize)nameIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)phoneIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox nameIcon;
        private PictureBox locationIcon;
        private PictureBox phoneIcon;
        private PictureBox emailIcon;
        private Label nameTitleLbl;
        private Label locationTitleLbl;
        private Label phoneTitleLbl;
        private Label emailTitleLbl;
        private Button applyBtn;
        private Panel panel1;
        private Label emailLbl;
        private Label phoneLbl;
        private Label locationLbl;
        private Label nameLbl;
        private Button uploadBtn;
        private Label fileFormatsLbl;
        private Label uploadCvTitleLbl;
    }
}