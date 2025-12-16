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
    public partial class formClassInformation : Form
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


        public formClassInformation()
        {
            InitializeComponent();

            RoundedCornersHelper.Apply(this, 20);

        }

        private void buttonCloseDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxHelp_ClassInformation_MouseEnter(object sender, EventArgs e)
        {
            labelHelpClassinformation.Location = new Point(pictureBoxHelp_ClassInformation.Right + 10, pictureBoxHelp_ClassInformation.Top);
            labelHelpClassinformation.Visible = true;
        }

        private void pictureBoxHelp_ClassInformation_MouseLeave(object sender, EventArgs e)
        {
            labelHelpClassinformation.Visible = false;
        }

        private void formClassInformation_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
