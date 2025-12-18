using FitHub._3._DataAccessLayer;
using FitHub._2._BusinessLogicLayer.ENT_OBJ;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitHub._1._UserInterface
{
    public partial class formMemberManagementTab : Form
    {
        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;
        DalClasses dalclasses;
        DalPrintReport dalprintreport;


        public formMemberManagementTab()
        {
            InitializeComponent();

            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            dalclasses = new DalClasses();
            dalprintreport = new DalPrintReport();

            List<Member> members = bll.GetAllMembersBLL();
            dataGridViewClassOverviewClassManagement.DataSource = members;
            dataGridViewClassOverviewClassManagement.CellEndEdit += dataGridViewClassOverviewClassManagement_CellEndEdit;


        }


        private void UpdateMembers()
        {
            List<Member> members = bll.GetAllMembersBLL();
            dataGridViewClassOverviewClassManagement.DataSource = members;

        }

        public void dataGridViewClassOverviewClassManagement_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var memberID = dataGridViewClassOverviewClassManagement.Rows[e.RowIndex].Cells["MemberID"].Value;

            if (memberID == DBNull.Value || memberID == null) return;
            int memberID_ = Convert.ToInt32(memberID);


            string columnName = dataGridViewClassOverviewClassManagement.Columns[e.ColumnIndex].Name;
            object newValue = dataGridViewClassOverviewClassManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            switch (columnName)
            {
                case "FirstName":
                    dalMembers.UpdateSingleColumnMember(memberID_, "FirstName", newValue); break;

                case "SurName":
                    dalMembers.UpdateSingleColumnMember(memberID_, "SurName", newValue); break;

                case "Email":
                    dalMembers.UpdateSingleColumnMember(memberID_, "Email", newValue); break;

                case "Telephone":
                    dalMembers.UpdateSingleColumnMember(memberID_, "Telephone", newValue); break;

                case "MemberType":
                    dalMembers.UpdateSingleColumnMember(memberID_, "Membertype", newValue); break;
            }
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

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.FirstName = textBoxFirstNameMemberManagement.Text;
            member.SurName = textBoxSurNameMemberManagement.Text;
            member.Email = textBoxEmailMemberManagement.Text;
            member.Telephone = textBoxTlfMemberManagement.Text;
            member.Birthday = dateTimePicker2.Value;
            member.MemberType = comboBoxMemberTypeMemberManagement.Text;
            member.Active = "Active";

            bool wasAdded = bll.AddMemberBLL(member);
            if (wasAdded)
            {
                textBoxFirstNameMemberManagement.Text = "";
                textBoxSurNameMemberManagement.Text = "";
                textBoxEmailMemberManagement.Text = "";
                textBoxTlfMemberManagement.Text = "";
                comboBoxMemberTypeMemberManagement.Text = null;
            }

            //Call BLL to add member 
            UpdateMembers();



        }

        private void buttonDeleteMemberManagement_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewClassOverviewClassManagement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row");
                return;
            }

            // Get MemberID from selected row
            var memberID = Convert.ToInt32(
                dataGridViewClassOverviewClassManagement.SelectedRows[0].Cells[0].Value);

            // Ask user for confirmation
            if (MessageBox.Show("Are you sure?\n(Member will be deleted permanently!)", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Call BLL to delete member
                bll.DeleteMemberBLL(memberID);

                // Refresh members after delete
                dataGridViewClassOverviewClassManagement.DataSource = bll.GetAllMembersBLL();
            }

        }

        private void buttonActiveOnOffMemberManagement_Click(object sender, EventArgs e)
        {
            var memberID = Convert.ToInt32(dataGridViewClassOverviewClassManagement.SelectedRows[0].Cells[0].Value);
            var activityStatus = Convert.ToString(dataGridViewClassOverviewClassManagement.SelectedRows[0].Cells[7].Value);
            bll.ActivityStatus(memberID, activityStatus);
            UpdateMembers();


        }

        private void dataGridViewClassOverviewClassManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
