namespace PROIECTWAP.Forms
{
    partial class InterviewForm
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
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            btnUpdate = new Button();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(184, 80, 66);
            label1.Location = new Point(257, 181);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 1;
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
            btnSave.Click += btnSave_Click;
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
            btnClear.Text = "Deserialize";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
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
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(283, 266);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.Text = "Rejected";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(162, 266);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "Accepted";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 263);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 24;
            label4.Text = "Feedback";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 213);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 22;
            label3.Text = "Location";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 164);
            label2.Name = "label2";
            label2.Size = new Size(48, 22);
            label2.TabIndex = 20;
            label2.Text = "Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 19;
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
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(102, 73);
            label6.Name = "label6";
            label6.Size = new Size(28, 22);
            label6.TabIndex = 17;
            label6.Text = "ID";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 163);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(52, 120);
            label7.Name = "label7";
            label7.Size = new Size(83, 22);
            label7.TabIndex = 33;
            label7.Text = "Duration ";
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Montserrat", 9.749999F);
            btnAdd.Location = new Point(354, 137);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 39);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // InterviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 232, 209);
            ClientSize = new Size(844, 457);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "InterviewForm";
            Text = "InterviewForm";
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button btnUpdate;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Button btnAdd;
    }
}