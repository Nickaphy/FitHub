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
    public partial class formInstructorManagementTab : Form
    {
        public formInstructorManagementTab()
        {
            InitializeComponent();
        }

        private void pictureBox_InstructorManagement1_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement1.Location = new Point(pictureBox_InstructorManagement1.Right - 100, pictureBox_InstructorManagement1.Bottom + 10);
            labelHelp_InstructorManagement1.Visible = true;
        }

        private void pictureBox_InstructorManagement1_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement1.Visible = false;
        }

        private void pictureBox_InstructorManagement2_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement2.Location = new Point(pictureBox_InstructorManagement2.Right + 10, pictureBox_InstructorManagement2.Top);
            labelHelp_InstructorManagement2.Visible = true;
        }

        private void pictureBox_InstructorManagement2_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement2.Visible = false;
        }

        private void pictureBox_InstructorManagement3_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement33.Location = new Point(pictureBox_InstructorManagement3.Right + 10, pictureBox_InstructorManagement3.Top);
            labelHelp_InstructorManagement33.Visible = true;
        }

        private void pictureBox_InstructorManagement3_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement33.Visible = false;
        }
    }
}
