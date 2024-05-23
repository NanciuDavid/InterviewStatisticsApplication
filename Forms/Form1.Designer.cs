namespace PROIECTWAP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnDashboard = new Button();
            btnAnalysis = new Button();
            btnInterview = new Button();
            btnPerson = new Button();
            panelLogo = new Panel();
            githubPicture = new PictureBox();
            panelTitleBar = new Panel();
            btnCloseChild = new Button();
            lblTitle = new Label();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)githubPicture).BeginInit();
            panelTitleBar.SuspendLayout();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(btnAnalysis);
            panelMenu.Controls.Add(btnInterview);
            panelMenu.Controls.Add(btnPerson);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 536);
            panelMenu.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Montserrat", 12F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 260);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(220, 60);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "    Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnAnalysis
            // 
            btnAnalysis.Dock = DockStyle.Top;
            btnAnalysis.FlatAppearance.BorderSize = 0;
            btnAnalysis.FlatStyle = FlatStyle.Flat;
            btnAnalysis.Font = new Font("Montserrat", 12F);
            btnAnalysis.ForeColor = Color.White;
            btnAnalysis.Image = (Image)resources.GetObject("btnAnalysis.Image");
            btnAnalysis.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnalysis.Location = new Point(0, 200);
            btnAnalysis.Name = "btnAnalysis";
            btnAnalysis.Padding = new Padding(12, 0, 0, 0);
            btnAnalysis.Size = new Size(220, 60);
            btnAnalysis.TabIndex = 2;
            btnAnalysis.Text = "    Results";
            btnAnalysis.TextAlign = ContentAlignment.MiddleLeft;
            btnAnalysis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnalysis.UseVisualStyleBackColor = true;
            btnAnalysis.Click += btnAnalysis_Click;
            // 
            // btnInterview
            // 
            btnInterview.Dock = DockStyle.Top;
            btnInterview.FlatAppearance.BorderSize = 0;
            btnInterview.FlatStyle = FlatStyle.Flat;
            btnInterview.Font = new Font("Montserrat", 12F);
            btnInterview.ForeColor = Color.White;
            btnInterview.Image = (Image)resources.GetObject("btnInterview.Image");
            btnInterview.ImageAlign = ContentAlignment.MiddleLeft;
            btnInterview.Location = new Point(0, 140);
            btnInterview.Name = "btnInterview";
            btnInterview.Padding = new Padding(12, 0, 0, 0);
            btnInterview.Size = new Size(220, 60);
            btnInterview.TabIndex = 1;
            btnInterview.Text = "    Interview";
            btnInterview.TextAlign = ContentAlignment.MiddleLeft;
            btnInterview.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInterview.UseVisualStyleBackColor = true;
            btnInterview.Click += btnInterview_Click;
            // 
            // btnPerson
            // 
            btnPerson.Dock = DockStyle.Top;
            btnPerson.FlatAppearance.BorderSize = 0;
            btnPerson.FlatStyle = FlatStyle.Flat;
            btnPerson.Font = new Font("Montserrat", 12F);
            btnPerson.ForeColor = Color.White;
            btnPerson.Image = Properties.Resources.user__1_;
            btnPerson.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerson.Location = new Point(0, 80);
            btnPerson.Name = "btnPerson";
            btnPerson.Padding = new Padding(12, 0, 0, 0);
            btnPerson.Size = new Size(220, 60);
            btnPerson.TabIndex = 0;
            btnPerson.Text = "    Person";
            btnPerson.TextAlign = ContentAlignment.MiddleLeft;
            btnPerson.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPerson.UseVisualStyleBackColor = true;
            btnPerson.Click += btnPerson_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(githubPicture);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(12, 0, 0, 0);
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // githubPicture
            // 
            githubPicture.BackgroundImageLayout = ImageLayout.None;
            githubPicture.Image = (Image)resources.GetObject("githubPicture.Image");
            githubPicture.Location = new Point(39, 12);
            githubPicture.Name = "githubPicture";
            githubPicture.Size = new Size(100, 50);
            githubPicture.SizeMode = PictureBoxSizeMode.Zoom;
            githubPicture.TabIndex = 0;
            githubPicture.TabStop = false;
            githubPicture.Click += githubPicture_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnCloseChild);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(628, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // btnCloseChild
            // 
            btnCloseChild.Dock = DockStyle.Left;
            btnCloseChild.FlatAppearance.BorderSize = 0;
            btnCloseChild.FlatStyle = FlatStyle.Flat;
            btnCloseChild.Image = (Image)resources.GetObject("btnCloseChild.Image");
            btnCloseChild.Location = new Point(0, 0);
            btnCloseChild.Name = "btnCloseChild";
            btnCloseChild.Size = new Size(75, 80);
            btnCloseChild.TabIndex = 1;
            btnCloseChild.UseVisualStyleBackColor = true;
            btnCloseChild.Click += btnCloseChild_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(258, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(628, 456);
            panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 307);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(848, 536);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)githubPicture).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnPerson;
        private Button btnDashboard;
        private Button btnAnalysis;
        private Button btnInterview;
        private Panel panelTitleBar;
        private Label label1;
        private Label lblTitle;
        private PictureBox githubPicture;
        private Panel panelDesktop;
        private Button btnCloseChild;
        private PictureBox pictureBox1;
    }
}
