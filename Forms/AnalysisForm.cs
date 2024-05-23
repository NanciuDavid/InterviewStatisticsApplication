using PROIECTWAP.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROIECTWAP.Forms
{
    public partial class AnalysisForm : Form
    {
        private List<AnalysisResult> results = new List<AnalysisResult>();

        public AnalysisForm()
        {
            InitializeComponent();
            LoadTheme();
            InitializeDataGridView();
            LoadResults();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Your text changed logic here (if needed)
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

            var departmentColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Department",
                HeaderText = "Department"
            };
            dataGridView1.Columns.Add(departmentColumn);

            var totalInterviewsColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalInterviews",
                HeaderText = "Total Interviews"
            };
            dataGridView1.Columns.Add(totalInterviewsColumn);

            var passedInterviewsColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAccepted",
                HeaderText = "Passed Interviews"
            };
            dataGridView1.Columns.Add(passedInterviewsColumn);

            var failedInterviewsColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalRejected",
                HeaderText = "Failed Interviews"
            };
            dataGridView1.Columns.Add(failedInterviewsColumn);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Data validation
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string department = textBox1.Text;
                int totalInterviews = int.Parse(textBox2.Text);
                int interviewsPassed = int.Parse(textBox3.Text);
                int interviewsFailed = int.Parse(textBox4.Text);

                var result = new AnalysisResult
                {
                    Department = department,
                    TotalInterviews = totalInterviews,
                    TotalAccepted = interviewsPassed,
                    TotalRejected = interviewsFailed
                };

                results.Add(result);

                // Refresh the DataGridView
                BindDataGridView();

                // Clear the text boxes and reset controls
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox1.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid data: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serialization.SerializeBinary(results, "results.dat");
            Serialization.SerializeXML(results, "results.xml");
            MessageBox.Show("Data saved successfully in binary and XML formats.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadResults()
        {
            results = Serialization.DeserializeBinary<AnalysisResult>("results.dat");
            if (results.Count == 0)
            {
                results = Serialization.DeserializeXML<AnalysisResult>("results.xml");
            }
            dataGridView1.DataSource = results;
        }

        private void BindDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = results;
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            // Deserialize the data
            results = Serialization.DeserializeBinary<AnalysisResult>("results.dat");
            if (results.Count == 0)
            {
                results = Serialization.DeserializeXML<AnalysisResult>("results.xml");
            }
            MessageBox.Show("Data loaded successfully from binary and XML formats.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = results;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    if (selectedIndex >= 0 && selectedIndex < results.Count)
                    {
                        results.RemoveAt(selectedIndex);
                        BindDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the interview: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadResults();
            MessageBox.Show("Data reloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    if (selectedIndex >= 0 && selectedIndex < results.Count)
                    {
                        results[selectedIndex].Department = textBox1.Text;
                        results[selectedIndex].TotalInterviews = int.Parse(textBox2.Text);
                        results[selectedIndex].TotalAccepted = int.Parse(textBox3.Text);
                        results[selectedIndex].TotalRejected = int.Parse(textBox4.Text);

                        BindDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the interview: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeserialize_Click_1(object sender, EventArgs e)
        {
            // Deserialize the data
            results = Serialization.DeserializeBinary<AnalysisResult>("results.dat");
            if (results.Count == 0)
            {
                results = Serialization.DeserializeXML<AnalysisResult>("results.xml");
            }
            MessageBox.Show("Data loaded successfully from binary and XML formats.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = results;
        }
    }
}
