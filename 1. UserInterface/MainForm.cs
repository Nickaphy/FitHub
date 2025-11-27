using FitHub.B_BLL;
using FitHub.B_BLL.ENT_OBJ;
using System.Windows.Forms;

namespace FitHub
{
    public partial class MainForm : Form
    {
        
        //Initialisere gridview med data fra databasen fra start
            BLL bll;
        public MainForm()
        {
            InitializeComponent();
            bll = new BLL();
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
            int memberType = Convert.ToInt32(textBox5.Text);
            //Call BLL to add member 
            bll.AddMemberBLL(firstName, surName, email, telephone, memberType);
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
    }
}



