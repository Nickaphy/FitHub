
using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using FitHub._3._DataAccessLayer;
using FitHub.B_BLL;
using FitHub.B_BLL.ENT_OBJ;
using FitHub.C_DAL;
using System.Windows.Forms;

namespace FitHub
{
    public partial class MainForm : Form
    {

        //Initialisere gridview med data fra databasen fra start
        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;
        public MainForm()
        {
            InitializeComponent();
            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;

            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            InstructorGridView.DataSource = instructors;


        }

        //delete member button
        public void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var memberID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                BLL.DeleteMemberBLL(memberID);

                //refresh members after delete
                List<Member> members = bll.GetAllMembersBLL();
                dataGridView1.DataSource = members;
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
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
            bll.AddMemberBLL(member);
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

        private void InstructorCert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




