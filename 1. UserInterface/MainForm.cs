using FitHub._1._UserInterface;
using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using FitHub._3._DataAccessLayer;
using FitHub.B_BLL;
using FitHub.B_BLL.ENT_OBJ;
using FitHub.C_DAL;
using FitHub_UserInterface;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static FitHub._1._UserInterface.RoundedCorners;

namespace FitHub
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam
        );

        private void MoveNavPanel(Button btn)
        {
            panelNavagation.Height = btn.Height;
            panelNavagation.Top = btn.Top;
            panelNavagation.Left = btn.Left;
            //BackColor = Color.FromArgb(45, 51, 73);
        }

        //Initialisere gridview med data fra databasen fra start
        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;

        public MainForm()
        {
            InitializeComponent();
            RoundedCornersHelper.Apply(this, 20); // Apply rounded corners to the form
            panelNavagation.Height = buttonBookingTab.Height; // Set initial height to match the first button
            panelNavagation.Top = buttonBookingTab.Top; // Set initial top position to match the first button
            panelNavagation.Left = buttonBookingTab.Left; // Set initial left position to match the first button
            //buttonBookingTab.BackColor = Color.FromArgb(45, 51, 73);  // Highlight the first button initially
            labelTitle.Text = "Booking";
            this.panelFormLoader.Controls.Clear();
            formBookingTab FormBookingTab_Vrb = new formBookingTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormBookingTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormBookingTab_Vrb);
            FormBookingTab_Vrb.Show();
            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;
            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            InstructorGridView.DataSource = instructors;
        }

        //add member button
        public void button1_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.FirstName = textBox1.Text;
            member.SurName = textBox2.Text;
            member.Email = textBox3.Text;
            member.Telephone = textBox4.Text;
            member.Birthday = dateTimePicker2.Value;
            member.MemberType = comboBox1.Text;
            member.Active = "Active";
            bool wasAdded = bll.AddMemberBLL(member);
            if (wasAdded)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
            }
            //Call BLL to add member
            UpdateMembers();
        }

        private void UpdateMembers()
        {
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;
        }

        public void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var memberID = dataGridView1.Rows[e.RowIndex].Cells["MemberID"].Value;
            if (memberID == DBNull.Value || memberID == null) return;
            int memberID_ = Convert.ToInt32(memberID);
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            object newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            switch (columnName)
            {
                case "FirstName":
                    dalMembers.UpdateSingleColumnMember(memberID_, "FirstName", newValue);
                    break;
                case "SurName":
                    dalMembers.UpdateSingleColumnMember(memberID_, "SurName", newValue);
                    break;
                case "Email":
                    dalMembers.UpdateSingleColumnMember(memberID_, "Email", newValue);
                    break;
                case "Telephone":
                    dalMembers.UpdateSingleColumnMember(memberID_, "Telephone", newValue);
                    break;
                case "MemberType":
                    dalMembers.UpdateSingleColumnMember(memberID_, "Membertype", newValue);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var memberID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var activityStatus = Convert.ToString(dataGridView1.SelectedRows[0].Cells[7].Value);
            bll.ActivityStatus(memberID, activityStatus);
            UpdateMembers();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();
            instructor.FirstName = textBox10.Text;
            instructor.SurName = textBox9.Text;
            instructor.Email = textBox8.Text;
            instructor.Telephone = textBox7.Text;
            instructor.Certification = InstructorCert.Text;
            bool wasAdded = bll.AddInstructorBLL(instructor);
            if (wasAdded)
            {
                textBox10.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";
                InstructorCert.Text = "";
            }
            //Call BLL to add member
            bll.AddInstructorBLL(instructor);
            UpdateInstructors();
        }

        private void UpdateInstructors()
        {
            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            InstructorGridView.DataSource = instructors;
        }

        //delete instructor button
        public void button10_Click(object sender, EventArgs e)
        {
            if (InstructorGridView.SelectedRows.Count > 0)
            {
                DalInstructor dalinstructor = new DalInstructor();
                DataGridViewRow selectedRow = InstructorGridView.SelectedRows[0];
                var instructorID = Convert.ToInt32(selectedRow.Cells[0].Value);
                dalinstructor.DeleteInstructor(instructorID);
                UpdateInstructors();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void InstructorGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var instructorID = InstructorGridView.Rows[e.RowIndex].Cells["InstructorID"].Value;
            if (instructorID == DBNull.Value || instructorID == null) return;
            int instructorID_ = Convert.ToInt32(instructorID);
            string columnName = InstructorGridView.Columns[e.ColumnIndex].Name;
            object newValue = InstructorGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            switch (columnName)
            {
                case "FirstName":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "FirstName", newValue);
                    break;
                case "SurName":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "SurName", newValue);
                    break;
                case "Email":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "Email", newValue);
                    break;
                case "Telephone":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "Telephone", newValue);
                    break;
                case "Certifications":
                    dalinstructor.UpdateSingleColumnInstructor(instructorID_, "Certifications", newValue);
                    break;
            }
        }

        private void buttonClassManagement_Click(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
            labelTitle.Text = "Class Management";
            this.panelFormLoader.Controls.Clear();
            formClassManagementTab FormClassManagementTab_Vrb = new formClassManagementTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormClassManagementTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormClassManagementTab_Vrb);
            FormClassManagementTab_Vrb.Show();
        }

        private void buttonMemberManagement_Click(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
            labelTitle.Text = "Member Management";
            this.panelFormLoader.Controls.Clear();
            formMemberManagementTab FormMemberManagementTab_Vrb = new formMemberManagementTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormMemberManagementTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormMemberManagementTab_Vrb);
            FormMemberManagementTab_Vrb.Show();
        }

        private void buttonInstructorManagemant_Click(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
            labelTitle.Text = "Instructor Management";
            this.panelFormLoader.Controls.Clear();
            formInstructorManagementTab FormInstructorManagementTab_Vrb = new formInstructorManagementTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormInstructorManagementTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormInstructorManagementTab_Vrb);
            FormInstructorManagementTab_Vrb.Show();
        }

        private void buttonMemberOverview_Click(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
            labelTitle.Text = "Member Overview";
            this.panelFormLoader.Controls.Clear();
            formMemberOverviewTab FormMemberOverviewTab_Vrb = new formMemberOverviewTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormMemberOverviewTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormMemberOverviewTab_Vrb);
            FormMemberOverviewTab_Vrb.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
            labelTitle.Text = "Statistics Reports";
            this.panelFormLoader.Controls.Clear();
            formRaportsTab FormRaportsTab_Vrb = new formRaportsTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormRaportsTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormRaportsTab_Vrb);
            FormRaportsTab_Vrb.Show();
        }

        private void buttonBookingTab_Click(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
            labelTitle.Text = "Booking";
            this.panelFormLoader.Controls.Clear();
            formBookingTab FormBookingTab_Vrb = new formBookingTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormBookingTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormBookingTab_Vrb);
            FormBookingTab_Vrb.Show();
        }

        private void buttonBookingTab_leave(object sender, EventArgs e)
        {
            buttonBookingTab.BackColor = Color.FromArgb(31, 34, 56);
        }

        private void buttonClassManagement_leave(object sender, EventArgs e)
        {
            buttonClassManagement.BackColor = Color.FromArgb(31, 34, 56);
        }

        private void buttonMemberManagement_leave(object sender, EventArgs e)
        {
            buttonMemberManagement.BackColor = Color.FromArgb(31, 34, 56);
        }

        private void buttonInstructorManagemant_leave(object sender, EventArgs e)
        {
            buttonInstructorManagemant.BackColor = Color.FromArgb(31, 34, 56);
        }

        private void buttonMemberOverview_leave(object sender, EventArgs e)
        {
            buttonMemberOverview.BackColor = Color.FromArgb(31, 34, 56);
        }

        private void button2_leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(31, 34, 56);
        }

        private void buttonCloseDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClassOverview_Click(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
            labelTitle.Text = "Class Overview";
            this.panelFormLoader.Controls.Clear();
            formClassOverviewTab FormClassOverviewTab_Vrb = new formClassOverviewTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormClassOverviewTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormClassOverviewTab_Vrb);
            FormClassOverviewTab_Vrb.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
            /*panelNavagation.Height = buttonLogout.Height;
            panelNavagation.Top = buttonLogout.Top;
            panelNavagation.Left = buttonLogout.Left;
            buttonLogout.BackColor = Color.FromArgb(45, 51, 73);*/
            FitHub_Login_UI fithub_Login_UI = new FitHub_Login_UI();
            fithub_Login_UI.Show();
            this.Hide();
        }

        private void buttonLogout_leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonBookingTab_MouseEnter(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
        }

        private void buttonClassManagement_MouseEnter(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
        }

        private void buttonMemberManagement_MouseEnter(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
        }

        private void buttonInstructorManagemant_MouseEnter(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
        }

        private void buttonMemberOverview_MouseEnter(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
        }

        private void buttonLogout_MouseEnter(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
        }

        private void buttonClassOverview_leave(object sender, EventArgs e)
        {
            buttonClassOverview.BackColor = Color.FromArgb(31, 34, 56);
        }

        private void buttonClassOverview_MouseEnter(object sender, EventArgs e)
        {
            MoveNavPanel((Button)sender);
        }

        private void buttonBookingTab_Hover(object sender, EventArgs e)
        {
            //buttonClassOverview.BackColor = Color.FromArgb(158, 161, 176);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
    }
}




