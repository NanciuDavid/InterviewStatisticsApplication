using PROIECTWAP.Classes;
using PROIECTWAP.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROIECTWAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private Button currentButton;
        private Random random;
        private int tempIndex;

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private Form activeForm = null;

        private void btnDashboard_Click(object sender, EventArgs e)
        {
          ActivateButton(sender);
           
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

    }
}
