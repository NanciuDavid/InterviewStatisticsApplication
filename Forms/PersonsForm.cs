﻿using PROIECTWAP.Classes;
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
        public PersonsForm()
        {
            InitializeComponent();
            LoadTheme();
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
    }
}
