using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHub._1._UserInterface
{
    public partial class formClassManagementTab : Form
    {
        public formClassManagementTab()
        {
            InitializeComponent();
        }

        private void pictureBoxHelp_ClassManagement1_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_ClassManagement1.Location = new Point(pictureBoxHelp_ClassManagement1.Right - 100, pictureBoxHelp_ClassManagement1.Bottom + 10);
            labelHelp_ClassManagement1.Visible = true;
        }

        private void pictureBoxHelp_ClassManagement1_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_ClassManagement1.Visible = false;
        }

        private void pictureBox_ClassManagement2_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_ClassManagement2.Location = new Point(pictureBox_ClassManagement2.Right + 10, pictureBox_ClassManagement2.Top);
            labelHelp_ClassManagement2.Visible = true;
        }

        private void pictureBox_ClassManagement2_MouseLEave(object sender, EventArgs e)
        {
            labelHelp_ClassManagement2.Visible = false;
        }

        private void pictureBox_ClassManagement3_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_ClassManagement3.Location = new Point(pictureBox_ClassManagement3.Right + 10, pictureBox_ClassManagement3.Top);
            labelHelp_ClassManagement3.Visible = true;
        }

        private void pictureBox_ClassManagement3_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_ClassManagement3.Visible = false;
        }

        private void pictureBox_ClassManagement4_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_ClassManagement4.Location = new Point(pictureBox_ClassManagement4.Right + 10, pictureBox_ClassManagement4.Top);
            labelHelp_ClassManagement4.Visible = true;
        }

        private void pictureBox_ClassManagement4_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_ClassManagement4.Visible = false;
        }
    }
}
