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
    public partial class formClassOverviewTab : Form
    {
        public formClassOverviewTab()
        {
            InitializeComponent();
        }

        private void buttonAddInstructor_Click(object sender, EventArgs e)
        {
            formClassInformation formClassInformation = new formClassInformation();
            formClassInformation.Show();
        }

        private void pictureBoxHelp_ClassOverview1_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_ClassOverview1.Location = new Point(pictureBoxHelp_ClassOverview1.Left, pictureBoxHelp_ClassOverview1.Top - 30);
            labelHelp_ClassOverview1.Visible = true;
        }

        private void pictureBoxHelp_ClassOverview1_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_ClassOverview1.Visible = false;
        }

        private void pictureBoxHelp_ClassOverview2_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_ClassOverview2.Location = new Point(pictureBoxHelp_ClassOverview2.Right + 10, pictureBoxHelp_ClassOverview2.Top);
            labelHelp_ClassOverview2.Visible = true;
        }

        private void pictureBoxHelp_ClassOverview2_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_ClassOverview2.Visible = false;
        }
    }
}
