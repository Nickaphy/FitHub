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
    public partial class formBookingTab : Form
    {
        public formBookingTab()
        {
            InitializeComponent();
        }

        private void pictureBoxHelp_Booking_MouseEnter(object sender, EventArgs e)
        {
            labelHelp.Location = new Point(pictureBoxHelp_Booking.Right + 10, pictureBoxHelp_Booking.Top);
            labelHelp.Visible = true;
        }

        private void pictureBoxHelp_Booking_MouseLeave(object sender, EventArgs e)
        {
            labelHelp.Visible = false;
        }

        private void buttonBooking_MouseEnter(object sender, EventArgs e)
        {
            labelAddingMemberToClass.Location = new Point(buttonBooking.Left, buttonBooking.Top - 30);
            labelAddingMemberToClass.Visible = true;
        }

        private void buttonBooking_MouseLeave(object sender, EventArgs e)
        {
            labelAddingMemberToClass.Visible = false;
        }

        private void pictureBoxHelpClassOverview_MouseEnter(object sender, EventArgs e)
        {
            labelHelpClassOverviewBooking.Location = new Point(pictureBoxHelpClassOverview.Right + 10, pictureBoxHelpClassOverview.Top);
            labelHelpClassOverviewBooking.Visible = true;
        }

        private void pictureBoxHelpClassOverview_MouseLeave(object sender, EventArgs e)
        {
            labelHelpClassOverviewBooking.Visible = false;  
        }
    }
}
