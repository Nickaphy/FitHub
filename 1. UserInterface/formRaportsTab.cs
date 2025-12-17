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
    public partial class formRaportsTab : Form
    {
        public formRaportsTab()
        {
            InitializeComponent();
        }

        private void pictureBox_Statistics1_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_Statistics.Location = new Point(pictureBox_Statistics1.Right + 10, pictureBox_Statistics1.Top);
            labelHelp_Statistics.Visible = true;
        }

        private void pictureBox_Statistics1_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_Statistics.Visible = false;
        }
    }
}
