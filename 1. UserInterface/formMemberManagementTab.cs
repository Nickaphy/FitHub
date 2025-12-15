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
    public partial class formMemberManagementTab : Form
    {
        public formMemberManagementTab()
        {
            InitializeComponent();
        }

        private void pictureBoxHelp_MemberManagement1_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_MemberManagement1.Location = new Point(pictureBoxHelp_MemberManagement1.Right - 200, pictureBoxHelp_MemberManagement1.Bottom + 10);
            labelHelp_MemberManagement1.Visible = true;
        }

        private void pictureBoxHelp_MemberManagement1_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_MemberManagement1.Visible = false;
        }

        private void pictureBoxHelp_MemberManagement2_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_MemberManagement2.Location = new Point(pictureBox_MemberManagement2.Right + 10, pictureBox_MemberManagement2.Top);
            labelHelp_MemberManagement2.Visible = true;
        }

        private void pictureBoxHelp_MemberManagement2_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_MemberManagement2.Visible = false;
        }

        private void pictureBox_MemberManagement3_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_MemberManagement3.Location = new Point(pictureBox_MemberManagement3.Right + 10, pictureBox_MemberManagement3.Top);
            labelHelp_MemberManagement3.Visible = true;
        }

        private void pictureBox_MemberManagement3_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_MemberManagement3.Visible = false;
        }
    }
}
