using System.Windows.Forms;

namespace FitHub
{
    public partial class InstructorViewMembers : Form
    {
        public InstructorViewMembers()
        {
            InitializeComponent();
        }

        public void SetMembers(List<InstructorViewMembersDTO> members)
        {
            MembersForInstructorsDataGridView.DataSource = members;
            MembersForInstructorsDataGridView.AutoResizeColumns();
        }

        public void MembersForInstructorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void InstructorViewMembers_Load(object sender, EventArgs e)
        {

        }

        internal void LoadMemberData(List<InstructorViewMembersDTO> instructorViewMembers)
        {
            throw new NotImplementedException();
        }
    }
}
