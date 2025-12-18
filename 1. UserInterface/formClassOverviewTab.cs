using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using FitHub._3._DataAccessLayer;
using FitHub.B_BLL;
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
    public partial class formClassOverviewTab : Form
    {
        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;
        DalClasses dalclasses;
        DalPrintReport dalprintreport;
        public formClassOverviewTab()
        {
            InitializeComponent();
            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            dalclasses = new DalClasses();
            dalprintreport = new DalPrintReport();

            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            DataGridViewInstructor.DataSource = instructors;

        }

        //Takes classID from gridview and shows in view. -Lucas
        public void buttonAddInstructor_Click(object sender, EventArgs e)
        {

            if (dataGridViewClasses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewClasses.SelectedRows[0];

                int classID = Convert.ToInt32(selectedRow.Cells[5].Value);

                var instructorViewMembers = bll.GetInstructorViewMembers(classID);

                //Open form for specific class and show class members
                var instructorViewMembersForm = new formClassInformation();
                instructorViewMembersForm.SetMembers(instructorViewMembers); 
                instructorViewMembersForm.Show();
            }
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

        // Retrieves and displays the class history for the selected instructor - Lucas
        private void buttonRetrieveClasses_Click(object sender, EventArgs e)
        {
            if (DataGridViewInstructor.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridViewInstructor.SelectedRows[0];

                int instructorID = Convert.ToInt32(selectedRow.Cells[0].Value);

                var classHistory = bll.GetClassHistory(instructorID);

                dataGridViewClasses.DataSource = classHistory;
            }
        }
    }
}
