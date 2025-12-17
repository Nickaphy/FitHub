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
using static FitHub.B_BLL.BLL;

namespace FitHub._1._UserInterface
{   
    public partial class formRaportsTab : Form
    {
        BLL bll;
        DalMembers dalMembers;
        DalInstructor dalinstructor;
        DalClasses dalclasses;
        DalPrintReport dalprintreport;
        public formRaportsTab()
        {
            InitializeComponent();
            bll = new BLL();
            dalinstructor = new DalInstructor();
            dalMembers = new DalMembers();
            dalclasses = new DalClasses();
            dalprintreport = new DalPrintReport();
        }

        private PrintReportBLL bll2 = new PrintReportBLL();

        private void pictureBox_Statistics1_MouseEnter(object sender, EventArgs e)
        {
            labelHelp_Statistics.Location = new Point(pictureBox_Statistics1.Right + 10, pictureBox_Statistics1.Top);
            labelHelp_Statistics.Visible = true;
        }

        private void pictureBox_Statistics1_MouseLeave(object sender, EventArgs e)
        {
            labelHelp_Statistics.Visible = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string selectedReport = comboBoxSubjectPrint.Text;
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

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
    }
}
