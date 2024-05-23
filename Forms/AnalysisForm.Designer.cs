namespace PROIECTWAP.Forms
{
    partial class AnalysisForm
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
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnUpdate = new Button();
            label7 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Montserrat", 9.749999F);
            btnSave.Location = new Point(153, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 39);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Montserrat", 9.749999F);
            btnClear.Location = new Point(591, 377);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 39);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Montserrat", 9.749999F);
            btnDelete.Location = new Point(446, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 39);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(455, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(362, 282);
            dataGridView1.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(579, 21);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 27;
            label5.Text = "Stored Data";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Montserrat", 9.749999F);
            btnUpdate.Location = new Point(301, 377);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 39);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 120);
            label7.Name = "label7";
            label7.Size = new Size(150, 22);
            label7.TabIndex = 45;
            label7.Text = "No.  of Interviews ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(183, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 40;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 213);
            label3.Name = "label3";
            label3.Size = new Size(145, 22);
            label3.TabIndex = 39;
            label3.Text = "Failed Interviews";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 168);
            label2.Name = "label2";
            label2.Size = new Size(154, 22);
            label2.TabIndex = 37;
            label2.Text = "Passed Interviews";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 80);
            label6.Name = "label6";
            label6.Size = new Size(109, 22);
            label6.TabIndex = 35;
            label6.Text = "Department";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(184, 80, 66);
            label1.Location = new Point(282, 186);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(183, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 46;
            // 
            // AnalysisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 232, 209);
            ClientSize = new Size(848, 461);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(btnUpdate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AnalysisForm";
            Text = "AnalysisForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button btnUpdate;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
    }
}