﻿using PROIECTWAP.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROIECTWAP.Forms
{
    public partial class PersonsForm : Form
    {
        private List<Person> people;

        public PersonsForm()
        {
            InitializeComponent();
            LoadTheme();
            people = new List<Person>();
            InitializeDataGridView();
            LoadPeople();
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
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            };
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn phoneColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PhoneNumber",
                HeaderText = "Phone"
            };
            dataGridView1.Columns.Add(phoneColumn);

            DataGridViewTextBoxColumn addressColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address",
                HeaderText = "Address"
            };
            dataGridView1.Columns.Add(addressColumn);

            DataGridViewTextBoxColumn ageColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Age",
                HeaderText = "Age"
            };
            dataGridView1.Columns.Add(ageColumn);

            DataGridViewTextBoxColumn genderColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gender",
                HeaderText = "Gender"
            };
            dataGridView1.Columns.Add(genderColumn);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Data validation
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Age validation
            if (int.Parse(textBox4.Text) < 18)
            {
                MessageBox.Show("Age must be greater than 18", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add a new person to the list
            people.Add(new Person
            {
                Name = textBox1.Text,
                PhoneNumber = textBox2.Text,
                Address = textBox3.Text,
                Age = int.Parse(textBox4.Text),
                Gender = radioButton1.Checked ? "Male" : "Female",
            });

            // Refresh the DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = people;

            // Clear the text boxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // Focus the first text box
            textBox1.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serialization.SerializeBinary(people, "people.dat");
            Serialization.SerializeXML(people, "people.xml");
            MessageBox.Show("Data saved successfully in binary and xml.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadPeople()
        {
            people = Serialization.DeserializeBinary<Person>("people.dat");
            if (people.Count == 0)
            {
                people = Serialization.DeserializeXML<Person>("people.xml");
            }
            dataGridView1.DataSource = people;
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            //deserialize the data
            people = Serialization.DeserializeBinary<Person>("people.dat");
            if (people.Count == 0)
            {
                people = Serialization.DeserializeXML<Person>("people.xml");
            }
            MessageBox.Show("Data exported successfully from binary and xml.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = people;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //delete the selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                people.RemoveAt(dataGridView1.SelectedRows[0].Index);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = people;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          //update data

          if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    if (selectedIndex >= 0 && selectedIndex < people.Count)
                    {
                        people[selectedIndex].Name = textBox1.Text;
                        people[selectedIndex].PhoneNumber = textBox2.Text;
                        people[selectedIndex].Address = textBox3.Text;
                        people[selectedIndex].Age = int.Parse(textBox4.Text);
                        people[selectedIndex].Gender = radioButton1.Checked ? "Male" : "Female";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }
    }
}
