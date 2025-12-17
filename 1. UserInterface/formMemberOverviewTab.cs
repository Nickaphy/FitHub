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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitHub._1._UserInterface
{
    public partial class formMemberOverviewTab : Form
    {

        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;
        DalClasses dalclasses;
        DalPrintReport dalprintreport;

        public formMemberOverviewTab()
        {
            InitializeComponent();
            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            dalclasses = new DalClasses();
            dalprintreport = new DalPrintReport();

            List<Member> members = bll.GetAllMembersBLL();
            DataGridViewMembersMembersOverview.DataSource = members;


            UpdateMembers();
        }

        private void UpdateMembers()
        {
            List<Member> members = bll.GetAllMembersBLL();
            DataGridViewMembersMembersOverview.DataSource = members;
            
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

        private void buttonMemberHistory_Click(object sender, EventArgs e)
        {

            if (DataGridViewMembersMembersOverview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridViewMembersMembersOverview.SelectedRows[0];

                int memberID = Convert.ToInt32(selectedRow.Cells[0].Value);

                var history = bll.GetMemberHistory(memberID);

                dataGridViewMemberHistory.DataSource = history;

            }


        }

        private void buttonSearchMember_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            string searchTerm = textBoxSearchBarMember.Text;


            if (string.IsNullOrWhiteSpace(searchTerm) == false)
                searchTerm = char.ToUpperInvariant(searchTerm[0]) + searchTerm.Substring(1).ToLowerInvariant();

            List<Member> allMembers = bll.GetAllMembersBLL();
            var filteredMembers = allMembers.Where(m =>
                (m.FirstName != null && m.FirstName.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase)) ||
                (m.SurName != null && m.SurName.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase)) ||
                (m.Email != null && m.Email.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase)) ||
                (m.Telephone != null && m.Telephone.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
            ).ToList();
            DataGridViewMembersMembersOverview.DataSource = filteredMembers;
            textBoxSearchBarMember.Text = "";
            //Capitalize first


        }
    }
}
