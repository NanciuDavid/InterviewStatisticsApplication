﻿namespace PROIECTWAP.Forms
{
    partial class PersonsForm
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(184, 80, 66);
            label1.Location = new Point(234, 183);
            label1.Name = "label1";
            label1.Size = new Size(292, 38);
            label1.TabIndex = 2;
            label1.Text = "PERSONS FORM";
            // 
            // PersonsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 232, 209);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonsForm";
            Text = "PersonsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}