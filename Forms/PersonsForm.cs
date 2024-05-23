using PROIECTWAP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button button = (Button)btns;
                    button.BackColor = ThemeColor.PrimaryColor;
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                label5.ForeColor = ThemeColor.SecondaryColor;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new person from the input data
            Person person = new Person
            {
                Name = textBox1.Text,
                PhoneNumber = textBox2.Text,
                Address = textBox3.Text,
                Age = int.Parse(textBox4.Text),
                Gender = radioButton1.Checked ? "Male" : "Female"
            };

            // Add the person to the list
            people.Add(person);
            // Refresh the DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = people;
        }
    }
}
