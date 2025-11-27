using System.Windows.Forms;

namespace FitHub
{
    public partial class Form1 : Form
    {
        //Initialisere gridview med data fra databasen fra start
        public Form1()
        {
            InitializeComponent();
            BLL bll = new BLL();
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            var memberID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            BLL.DeleteMemberBLL(memberID);
            //refresh members after delete
            BLL bll = new BLL();
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
        }

        //Handling cell click event to get the selected row's MemberID
        string memberID;
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validating that user is clicking on a row, not the header
            if ( dataGridView1.SelectedRows.Count > 0)
            { 
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var memberID = Convert.ToInt32(selectedRow.Cells[0].Value); 
            }
            else
            {
                MessageBox.Show("Please select a row first");
            }
        }
    }
}



