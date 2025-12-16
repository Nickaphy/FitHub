using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using FitHub._3._DataAccessLayer;
using FitHub.B_BLL;
using FitHub.B_BLL.ENT_OBJ;
using FitHub.C_DAL;
using System.Text;
using System.Windows.Forms;
using static FitHub.B_BLL.BLL;

namespace FitHub
{
    public partial class MainForm : Form
    {

        //Initialisere gridview med data fra databasen fra start
        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;
        DalClasses dalclasses;
        DalPrintReport dalprintreport;
        public MainForm()
        {
            InitializeComponent();
            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            dalclasses = new DalClasses();
            dalprintreport = new DalPrintReport();

            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;
            BookingMemberGrid.DataSource = members;
            SearchAllMembersDataGrid.DataSource = members;

            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            InstructorGridView.DataSource = instructors;
            searchInstructorDataGridView.DataSource = instructors;

            List<Class> classes = bll.GetAllClassesBLL();
            ClassManGrid.DataSource = classes;
            BookingClassGrid.DataSource = classes;

            ClassInstructorDropBox();
        }

        //delete member button
        public void btton1_Click_1(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row");
                return;
            }

            // Get MemberID from selected row
            var memberID = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells[0].Value);

            // Ask user for confirmation
            if (MessageBox.Show("Are you sure?\n(Member will be deleted permanently!)", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Call BLL to delete member
                bll.DeleteMemberBLL(memberID);

                // Refresh members after delete
                dataGridView1.DataSource = bll.GetAllMembersBLL();
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
                comboBox1.Text = null;
            }

            //Call BLL to add member 
            UpdateMembers();
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

        public void button9_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor
            {
                FirstName = textBox10.Text,
                SurName = textBox9.Text,
                Email = textBox8.Text,
                Telephone = textBox7.Text,
                Certification = InstructorCert.Text
            };

            bool wasAdded = bll.AddInstructorBLL(instructor);

            if (wasAdded)
            {

                textBox10.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";
                InstructorCert.Text = null;

                // Refresh UI lists
                UpdateInstructors();
                ClassInstructorDropBox();

            }
        }

        private void UpdateClasses()
        {
            List<Class> classes = bll.GetAllClassesBLL();
            ClassManGrid.DataSource = classes;
            BookingClassGrid.DataSource = classes;
        }
        private void UpdateInstructors()
        {
            List<Instructor> instructors = bll.GetAllInstructorsBLL();
            InstructorGridView.DataSource = instructors;
        }
        private void UpdateMembers()
        {
            List<Member> members = bll.GetAllMembersBLL();
            dataGridView1.DataSource = members;
            BookingMemberGrid.DataSource = members;
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

        public void ClassInstructorDropBox()
        {
            InstructorIDComboBox.Items.Clear();

            var instructors = bll.GetAllInstructorsBLL();
            foreach (var ins in instructors)
            {
                var fullName = string.IsNullOrWhiteSpace(ins.FirstName) && string.IsNullOrWhiteSpace(ins.SurName)
                    ? "(Unknown)"
                    : $"{ins.InstructorID} {ins.FirstName} {ins.SurName}".Trim();

                InstructorIDComboBox.Items.Add(fullName);
            }

            // leave no selection by default
            InstructorIDComboBox.SelectedIndex = -1;
        }


        private void ClassManGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClassManGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var classID = ClassManGrid.Rows[e.RowIndex].Cells["ClassID"].Value;

            if (classID == DBNull.Value || classID == null) return;
            int classID_ = Convert.ToInt32(classID);


            string columnName = ClassManGrid.Columns[e.ColumnIndex].Name;
            object newValue = ClassManGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            switch (columnName)
            {
                case "ClassType":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassType", newValue); break;

                case "ClassDate":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassDate", newValue); break;

                case "ClassTime":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassTime", newValue); break;

                case "ClassCapacity":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassCapacity", newValue); break;

                case "ClassLocation":
                    dalclasses.UpdateSingleColumnClass(classID_, "ClassLocation", newValue); break;

                case "InstructorID":
                    dalclasses.UpdateSingleColumnClass(classID_, "InstructorID", newValue); break;
            }
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            var memberID = Convert.ToInt32(BookingMemberGrid.SelectedRows[0].Cells[0].Value);
            var classID = Convert.ToInt32(BookingClassGrid.SelectedRows[0].Cells[0].Value);
            bll.BookingClass(classID, memberID);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (searchInstructorDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = searchInstructorDataGridView.SelectedRows[0];

                int instructorID = Convert.ToInt32(selectedRow.Cells[0].Value);

                var classHistory = bll.GetClassHistory(instructorID);

                scopeClassHistoryView.DataSource = classHistory;
            }

        }

        private void GetMemberHistory_Click(object sender, EventArgs e)
        {


            if (SearchAllMembersDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SearchAllMembersDataGrid.SelectedRows[0];

                int memberID = Convert.ToInt32(selectedRow.Cells[0].Value);

                var history = bll.GetMemberHistory(memberID);

                scopeMemberHistoryDataGrid.DataSource = history;

            }

        }



        private void SearchAllMembersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (scopeClassHistoryView.SelectedRows.Count > 0)
            {
                // InstructorViewMembers newForm = new InstructorViewMembers();
                //newForm.Show();

                DataGridViewRow selectedRow = scopeClassHistoryView.SelectedRows[0];

                int classID = Convert.ToInt32(selectedRow.Cells[5].Value);

                var instructorViewMembers = bll.GetInstructorViewMembers(classID);

                var instructorViewMembersForm = new InstructorViewMembers();
                instructorViewMembersForm.SetMembers(instructorViewMembers); // <-- brug medoden
                instructorViewMembersForm.Show();


            }
        }

        private PrintReportBLL bll2 = new PrintReportBLL();

        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            string selectedReport = PrintDropBox.Text;
            DateTime startDate = PrintFromPicker.Value;
            DateTime endDate = PrintToPicker.Value;

            // Use time-constrained overload for popularity report, otherwise keep existing call
            List<Member> members;
            if (selectedReport == "Popular Classes (Sum)")
            {
                members = bll2.GetMembersForReport(selectedReport, startDate, endDate);
            }
            else
            {
                members = bll2.GetMembersForReport(selectedReport);
            }

            if (members.Count == -1)
            {
                MessageBox.Show("No members found for this report.");
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Save As";
                saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveDialog.DefaultExt = "txt";
                saveDialog.AddExtension = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder content = new StringBuilder();

                    // Optional header
                    content.AppendLine($"Report: {selectedReport}");

                    // Include selected time constraint in header when applicable
                    if (selectedReport == "Popular Classes (Sum)")
                    {
                        content.AppendLine($"Period: {startDate:yyyy-MM-dd} - {endDate:yyyy-MM-dd}");
                    }

                    content.AppendLine(new string('-', 40));

                    foreach (var member in members)
                    {
                        if (selectedReport == "Popular Classes (Sum)")
                        {
                            content.AppendLine(
                                $"{member.ClassType} | Total members: {member.TotalMembers}");
                        }
                        else
                        {
                            content.AppendLine(
                                $"{member.FirstName} {member.SurName} | {member.Telephone} | {member.Email} | {member.Active}");
                        }
                    }

                    File.WriteAllText(saveDialog.FileName, content.ToString());
                }
            }
        }


        private void PrintDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Member member = new Member();
            string searchTerm = textBox5.Text;


            if (string.IsNullOrWhiteSpace(searchTerm) == false)
                searchTerm = char.ToUpperInvariant(searchTerm[0]) + searchTerm.Substring(1).ToLowerInvariant();

            List<Member> allMembers = bll.GetAllMembersBLL();
            var filteredMembers = allMembers.Where(m =>
                (m.FirstName != null && m.FirstName.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase)) ||
                (m.SurName != null && m.SurName.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase)) ||
                (m.Email != null && m.Email.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase)) ||
                (m.Telephone != null && m.Telephone.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
            ).ToList();
            SearchAllMembersDataGrid.DataSource = filteredMembers;
            //Capitalize first
        }

        private void ButtonMakeTeam_Click_1(object sender, EventArgs e)
        {
            Class classes = new Class();

            classes.ClassType = ClassTypeComboBox.Text;
            classes.ClassDate = ClassCalender.Value;
            classes.ClassTime = ClassTimeComboBox.Text;
            classes.ClassCapacity = ClassCapacityTextBox.Text;
            classes.ClassLocation = ClassLocationTextBox.Text;
            classes.InstructorID = Convert.ToInt32(InstructorIDComboBox.Text.Split(' ')[0]);
            classes.FirstName = InstructorIDComboBox.Text;
            classes.SurName = InstructorIDComboBox.Text;

            bool wasAdded = bll.AddClassBLL(classes);

            if (wasAdded)
            {
                ClassTypeComboBox.Text = null;
                ClassTimeComboBox.Text = null;
                ClassCapacityTextBox.Text = "";
                ClassLocationTextBox.Text = "";
                InstructorIDComboBox.Text = null;
            }
            UpdateClasses();
        }
    }
}

































































