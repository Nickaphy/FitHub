using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FitHub._1._UserInterface.RoundedCorners;

namespace FitHub._1._UserInterface
{
    public partial class FitHub_Login_UI : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam
        );

        public FitHub_Login_UI()
        {
            InitializeComponent();

            RoundedCornersHelper.Apply(this, 20);
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void FitHub_Login_UI_Load(object sender, EventArgs e)
        {

        }

        private void buttonCloseDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FitHub_Login_UI_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
