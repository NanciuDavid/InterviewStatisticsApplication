using PROIECTWAP.Classes;
using PROIECTWAP.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PROIECTWAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChild.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChild.Visible = true;
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

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new DashboardForm(), sender);
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AnalysisForm(), sender);
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new InterviewForm(), sender);
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new PersonsForm(), sender);
        }

        private void githubPicture_Click(object sender, EventArgs e)
        {

            string githubUrl = "https://github.com/NanciuDavid";


            Process.Start(new ProcessStartInfo
            {
                FileName = githubUrl,
                UseShellExecute = true
            });
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            ThemeColor.PrimaryColor = Color.FromArgb(0, 150, 136);
            ThemeColor.SecondaryColor = Color.FromArgb(0, 150, 136);
        }

        //create alt-shortcut for btnCloseChild

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.C))
            {
                btnCloseChild.PerformClick();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.X))
            {
                btnMaximize.PerformClick();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.M))
            {
                btnMinimize.PerformClick();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.F4))
            {
                btnClose.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //close application
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(this.WindowState == FormWindowState.Normal)
            this.WindowState = FormWindowState.Maximized;
           

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
           if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            } else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }

      

    }
}
