
using FitHub._2._BusinessLogicLayer.ENT_OBJ;
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
        public MainForm()
        {
            InitializeComponent();
            bll = new BLL();
            dalMembers = new DalMembers();
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;

            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            dataGridView4.DataSource = instructors;

        }

        //delete member button
        public void button1_Click_1(object sender, EventArgs e)
        {
            var memberID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            BLL.DeleteMemberBLL(memberID);
            //refresh members after delete
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;
        }



        //Handling cell click event to get the selected row's MemberID
        string memberID;
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validating that user is clicking on a row, not the header
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var memberID = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Please select a row first");
            }
        }

        // Updating a single fieldbox and saving it to the field itself and the database.
        private void button2_Click(object sender, EventArgs e)
        {

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
            
            //Call BLL to add member 
            bll.AddMemberBLL(member);
            UpdateMembers();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";


        }

        private void UpdateMembers()
        {
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;
        }


        private void label3_Click(object sender, EventArgs e)
        {

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
                    dalMembers.UpdateSingleColumn(memberID_, "FirstName", newValue); break;

                case "SurName":
                    dalMembers.UpdateSingleColumn(memberID_, "SurName", newValue); break;

                case "Email":
                    dalMembers.UpdateSingleColumn(memberID_, "Email", newValue); break;

                case "Telephone":
                    dalMembers.UpdateSingleColumn(memberID_, "Telephone", newValue); break;

                case "MemberType":
                    dalMembers.UpdateSingleColumn(memberID_, "Membertype", newValue); break;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var memberID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var activityStatus = Convert.ToString(dataGridView1.SelectedRows[0].Cells[7].Value);
            bll.ActivityStatus(memberID, activityStatus);
            UpdateMembers();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();
            instructor.FirstName = textBox10.Text;
            instructor.SurName = textBox9.Text;
            instructor.Email = textBox8.Text;
            instructor.Telephone = textBox7.Text;
            instructor.Certification = textBox12.Text;

            
            
            //Call BLL to add member 
            bll.AddInstructorBLL(instructor);
            UpdateInstructors();

            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox12.Text = "";
        }

        private void UpdateInstructors()
        {
            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            dataGridView4.DataSource = instructors;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



