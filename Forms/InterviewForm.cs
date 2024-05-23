using PROIECTWAP.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROIECTWAP.Forms
{
    public partial class InterviewForm : Form
    {
        private List<Interview> interviews;

        public InterviewForm()
        {
            InitializeComponent();
            LoadTheme();
            interviews = new List<Interview>();
            InitializeDataGridView();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns is Button button)
                {
                    button.BackColor = ThemeColor.PrimaryColor;
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            if (label5 != null)
            {
                label5.ForeColor = ThemeColor.SecondaryColor;
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            // Create and add columns
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID"
            };
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn durationColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Duration",
                HeaderText = "Duration"
            };
            dataGridView1.Columns.Add(durationColumn);

            DataGridViewTextBoxColumn timeColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Time",
                HeaderText = "Time"
            };
            dataGridView1.Columns.Add(timeColumn);

            DataGridViewTextBoxColumn locationColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Location",
                HeaderText = "Location"
            };
            dataGridView1.Columns.Add(locationColumn);

            DataGridViewTextBoxColumn resultColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Result",
                HeaderText = "Result"
            };
            dataGridView1.Columns.Add(resultColumn);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Data validation
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int interviewID = int.Parse(textBox1.Text);
                string interviewDuration = textBox2.Text;
                string interviewTime = dateTimePicker1.Value.ToShortTimeString(); // Ensure you're using Value property
                string interviewLocation = textBox3.Text;
                string interviewResult = radioButton1.Checked ? "Accepted" : "Rejected";

                Interview newInterview = new Interview(interviewID, interviewDuration, interviewTime, interviewLocation, interviewResult);
                interviews.Add(newInterview);

                // Refresh the DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = interviews;

                // Clear the text boxes and reset controls
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                dateTimePicker1.Value = DateTime.Now;
                textBox1.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid data: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Interview selectedInterview = (Interview)dataGridView1.SelectedRows[0].DataBoundItem;
                interviews.Remove(selectedInterview);

                // Refresh the DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = interviews;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes and reset controls
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serialization.SerializeBinary(interviews);
            Serialization.SerializeXML(interviews);
            MessageBox.Show("Data saved successfully in binary and XML.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
