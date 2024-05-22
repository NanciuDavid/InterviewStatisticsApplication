namespace PROIECTWAP.Forms
{
    partial class DashboardForm
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
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(184, 80, 66);
            label1.Location = new Point(216, 158);
            label1.Name = "label1";
            label1.Size = new Size(348, 38);
            label1.TabIndex = 2;
            label1.Text = "DASHBOARD FORM";
            // 
            // DashboardForm
            // 
            BackColor = Color.FromArgb(231, 232, 209);
            ClientSize = new Size(784, 411);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}