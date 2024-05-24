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
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnCloseChild = new Button();
            lblTitle = new Label();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            githubRedirect1 = new GithubRedirect();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
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
            panelLogo.Controls.Add(githubRedirect1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(12, 0, 0, 0);
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChild);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(628, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(523, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(559, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(595, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
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
            // githubRedirect1
            // 
            githubRedirect1.Location = new Point(16, -34);
            githubRedirect1.Name = "githubRedirect1";
            githubRedirect1.Size = new Size(204, 131);
            githubRedirect1.TabIndex = 0;
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
        private Panel panelDesktop;
        private Button btnCloseChild;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
        private GithubRedirect githubRedirect1;
    }
}
