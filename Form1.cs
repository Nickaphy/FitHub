namespace FitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BLL bll = new BLL();
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //DeleteMember();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
