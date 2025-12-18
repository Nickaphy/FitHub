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
using static FitHub.B_BLL.BLL;

namespace FitHub._1._UserInterface
{
    public partial class formClassManagementTab : Form
    {
        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;
        DalClasses dalclasses;
        DalPrintReport dalprintreport;

        public formClassManagementTab()
        {
            InitializeComponent();
            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            dalclasses = new DalClasses();
            dalprintreport = new DalPrintReport();

            List<Class> classes = bll.GetAllClassesBLL();
            dataGridViewClassOverviewClassManagement.DataSource = classes;
            dataGridViewClassOverviewClassManagement.CellEndEdit += dataGridViewClassOverviewClassManagement_CellEndEdit;
            dataGridViewClassOverviewClassManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClassInstructorDropBox();
        }

        // Event handling for figuring out which item in a cell is chosen -Nicklas and Søren
        private void dataGridViewClassOverviewClassManagement_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var classID = dataGridViewClassOverviewClassManagement.Rows[e.RowIndex].Cells["ClassID"].Value;

            if (classID == DBNull.Value || classID == null) return;
            int classID_ = Convert.ToInt32(classID);

            string columnName = dataGridViewClassOverviewClassManagement.Columns[e.ColumnIndex].Name;
            object newValue = dataGridViewClassOverviewClassManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            switch (columnName)
            {
                case "ClassType":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassType", newValue); break;

                case "ClassDate":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassDate", newValue); break;

                case "ClassTime":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassTime", newValue); break;

                case "ClassCapacity":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassCapacity", newValue); break;

                case "ClassLocation":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassLocation", newValue); break;

                case "InstructorID":
                    dalclasses.UpdateSingleColumnClass(classID_, "InstructorID", newValue); break;
            }
        }


        private void UpdateClasses()
        {
            List<Class> classes = bll.GetAllClassesBLL();
            dataGridViewClassOverviewClassManagement.DataSource = classes;
        }

        // Populates the instructor drop-down box with instructor names and IDs - Nicklas and Erik
        public void ClassInstructorDropBox()
        {
            comboBoxInstructorClassManagement.Items.Clear();

            var instructors = bll.GetAllInstructorsBLL();
            foreach (var ins in instructors)
            {
                var fullName = string.IsNullOrWhiteSpace(ins.FirstName) && string.IsNullOrWhiteSpace(ins.SurName)
                    ? "(Unknown)"
                    : $"{ins.InstructorID} {ins.FirstName} {ins.SurName}".Trim();

                comboBoxInstructorClassManagement.Items.Add(fullName);
            }
            // leave no selection by default
            comboBoxInstructorClassManagement.SelectedIndex = -1;
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


        //Creating class, and clearing textfields and ComboBoxes -Everyone
        private void buttonCreateClass_Click(object sender, EventArgs e)
        {
            Class classes = new Class();

            classes.ClassType = comboBoxClassTypeClassManagement.Text;
            classes.ClassDate = dateTimePickerDateClassManagement.Value;
            classes.ClassTime = comboBoxTimeClassManagement.Text;
            classes.ClassCapacity = textBoxCapacityClassManagement.Text;
            classes.ClassLocation = textBoxLocationClassManagement.Text;
            classes.InstructorID = Convert.ToInt32(comboBoxInstructorClassManagement.Text.Split(' ')[0]);
            classes.FirstName = comboBoxInstructorClassManagement.Text;
            classes.SurName = comboBoxInstructorClassManagement.Text;

            bool wasAdded = bll.AddClassBLL(classes);

            if (wasAdded)
            {
                comboBoxClassTypeClassManagement.Text = null;
                comboBoxTimeClassManagement.Text = null;
                textBoxCapacityClassManagement.Text = "";
                textBoxLocationClassManagement.Text = "";
                comboBoxInstructorClassManagement.Text = null;
            }
            UpdateClasses();
        }
    }
}
