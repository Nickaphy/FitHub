using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using FitHub._3._DataAccessLayer;
using FitHub.B_BLL;
using FitHub.B_BLL.ENT_OBJ;
using FitHub.C_DAL;
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
        //Initialisere gridview med data fra databasen fra start
        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;
        DalClasses dalclasses;
        DalPrintReport dalprintreport;


        public formBookingTab()
        {
            InitializeComponent();

            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            dalclasses = new DalClasses();
            dalprintreport = new DalPrintReport();

            List<Member> members = bll.GetAllMembersBLL();
            dataGridViewMemberBooking.DataSource = members;

            List<Class> classes = bll.GetAllClassesBLL();
            dataGridViewClassOverviewBooking.DataSource = classes;

            UpdateClasses();
        }

        private void UpdateClasses()
        {
            List<Class> classes = bll.GetAllClassesBLL();
            dataGridViewClassOverviewBooking.DataSource = classes;
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

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            var memberID = Convert.ToInt32(dataGridViewMemberBooking.SelectedRows[0].Cells[0].Value);
            var classID = Convert.ToInt32(dataGridViewClassOverviewBooking.SelectedRows[0].Cells[0].Value);
            bll.BookingClass(classID, memberID);

        }
    }
}
