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
    public partial class formMemberOverviewTab : Form
    {
        public formMemberOverviewTab()
        {
            InitializeComponent();
        }

        private void pictureBox_MemberOverview1_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_MemberOverview1.Location = new Point(pictureBox_MemberOverview1.Right + 10, pictureBox_MemberOverview1.Top);
            labelHelp_MemberOverview1.Visible = true;
        }

        private void pictureBox_MemberOverview1_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_MemberOverview1.Visible = false;
        }

        private void pictureBox_MemberOverview2_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_MemberOverview2.Location = new Point(pictureBox_MemberOverview2.Right + 10, pictureBox_MemberOverview2.Top);
            labelHelp_MemberOverview2.Visible = true;
        }

        private void pictureBox_MemberOverview2_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_MemberOverview2.Visible = false;
        }

        private void buttonMemberHistory_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_MemberOverview3.Location = new Point(buttonMemberHistory.Left, buttonMemberHistory.Top - 30);
            labelHelp_MemberOverview3.Visible = true;
        }

        private void buttonMemberHistory_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_MemberOverview3.Visible = false;
        }
    }
}
