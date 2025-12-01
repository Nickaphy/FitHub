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
            string firstName = textBox1.Text;
            string surName = textBox2.Text;
            string email = textBox3.Text;
            string telephone = textBox4.Text;
            int memberType = int.Parse(comboBox1.Text);
            string active = "Active";
            //Call BLL to add member 
            bll.AddMemberBLL(firstName, surName, email, telephone, memberType, active);
            UpdateMembers();


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
    }
}



