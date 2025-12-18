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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitHub._1._UserInterface
{
    public partial class formInstructorManagementTab : Form
    {

        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;
        DalClasses dalclasses;
        DalPrintReport dalprintreport;

        public formInstructorManagementTab()
        {
            InitializeComponent();

            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            dalclasses = new DalClasses();
            dalprintreport = new DalPrintReport();

            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            dataGridViewInstructorOverviewInstructorManagement.DataSource = instructors;
            //fix for new UI and in cell editing -Nicklas
            dataGridViewInstructorOverviewInstructorManagement.CellEndEdit += dataGridViewInstructorOverviewInstructorManagement_CellEndEdit;
        }

        private void UpdateInstructors()
        {
            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            dataGridViewInstructorOverviewInstructorManagement.DataSource = instructors;
        }

        //Event handling for figuring out which item in a cell is chosen and calling the correct update method -Søren and Nicklas
        private void dataGridViewInstructorOverviewInstructorManagement_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var instructorID = dataGridViewInstructorOverviewInstructorManagement.Rows[e.RowIndex].Cells["InstructorID"].Value;

            if (instructorID == DBNull.Value || instructorID == null) return;
            int instructorID_ = Convert.ToInt32(instructorID);

            string columnName = dataGridViewInstructorOverviewInstructorManagement.Columns[e.ColumnIndex].Name;
            object newValue = dataGridViewInstructorOverviewInstructorManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            switch (columnName)
            {
                case "FirstName":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "FirstName", newValue); break;

                case "SurName":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "SurName", newValue); break;

                case "Email":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "Email", newValue); break;

                case "Telephone":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "Telephone", newValue); break;

                case "Certifications":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "Certifications", newValue); break;
            }
        }

        // Populates the instructor dropdown box -Everyone
        public void ClassInstructorDropBox()
        {
            comboBoxInstructorCertInstructorManagement.Items.Clear();

            var instructors = bll.GetAllInstructorsBLL();
            foreach (var ins in instructors)
            {
                var fullName = string.IsNullOrWhiteSpace(ins.FirstName) && string.IsNullOrWhiteSpace(ins.SurName)
                    ? "(Unknown)"
                    : $"{ins.InstructorID} {ins.FirstName} {ins.SurName}".Trim();

                comboBoxInstructorCertInstructorManagement.Items.Add(fullName);
            }
            // leave no selection by default
            comboBoxInstructorCertInstructorManagement.SelectedIndex = -1;
        }

        // -Lasse
        private void pictureBox_InstructorManagement1_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement1.Location = new Point(pictureBox_InstructorManagement1.Right - 100, pictureBox_InstructorManagement1.Bottom + 10);
            labelHelp_InstructorManagement1.Visible = true;
        }
        // -Lasse
        private void pictureBox_InstructorManagement1_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement1.Visible = false;
        }
        // -Lasse
        private void pictureBox_InstructorManagement2_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement2.Location = new Point(pictureBox_InstructorManagement2.Right + 10, pictureBox_InstructorManagement2.Top);
            labelHelp_InstructorManagement2.Visible = true;
        }
        // -Lasse
        private void pictureBox_InstructorManagement2_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement2.Visible = false;
        }
        // -Lasse
        private void pictureBox_InstructorManagement3_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement33.Location = new Point(pictureBox_InstructorManagement3.Right + 10, pictureBox_InstructorManagement3.Top);
            labelHelp_InstructorManagement33.Visible = true;
        }

        // -Lasse
        private void pictureBox_InstructorManagement3_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_InstructorManagement33.Visible = false;
        }
        // -Lasse
        private void buttonAddInstructor_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor
            {
                FirstName = textBoxFirstNameInstructorManagement.Text,
                SurName = textBoxSurNameInstructorManagement.Text,
                Email = textBoxEmailInstructorManagement.Text,
                Telephone = textBoxTLFInstructorManagement.Text,
                Certification = comboBoxInstructorCertInstructorManagement.Text
            };

            bool wasAdded = bll.AddInstructorBLL(instructor);

            if (wasAdded)
            {

                textBoxFirstNameInstructorManagement.Text = "";
                textBoxSurNameInstructorManagement.Text = "";
                textBoxEmailInstructorManagement.Text = "";
                textBoxTLFInstructorManagement.Text = "";
                comboBoxInstructorCertInstructorManagement.Text = null;

                // Refresh UI lists
                UpdateInstructors();
                ClassInstructorDropBox();
            }
        }

        
        void buttonDeleteInstructor_Click(object sender, EventArgs e)
        {
            if (dataGridViewInstructorOverviewInstructorManagement.SelectedRows.Count > 0)
            {
                DalInstructor dalinstructor = new DalInstructor();
                DataGridViewRow selectedRow = dataGridViewInstructorOverviewInstructorManagement.SelectedRows[0];
                var instructorID = Convert.ToInt32(selectedRow.Cells[0].Value);
                dalinstructor.DeleteInstructor(instructorID);

                UpdateInstructors();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }
    }
}
