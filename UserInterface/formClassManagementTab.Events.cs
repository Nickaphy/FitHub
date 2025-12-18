using System;
using System.Windows.Forms;

namespace FitHub._1._UserInterface
{
    public partial class formClassManagementTab
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                if (dataGridViewClassOverviewClassManagement != null)
                {
                    // Make sure grid is editable and user edits trigger handlers
                    dataGridViewClassOverviewClassManagement.ReadOnly = false;
                    dataGridViewClassOverviewClassManagement.AllowUserToAddRows = false;
                    dataGridViewClassOverviewClassManagement.EditMode = DataGridViewEditMode.EditOnEnter;

                    // Ensure handler is wired only once
                    dataGridViewClassOverviewClassManagement.CellEndEdit -= dataGridViewClassOverviewClassManagement_CellEndEdit;
                    dataGridViewClassOverviewClassManagement.CellEndEdit += dataGridViewClassOverviewClassManagement_CellEndEdit;
                }
            }
            catch
            {
                // Swallow any errors here to avoid breaking form load; developer can diagnose if needed
            }
        }
    }
}
