namespace FitHub
{
    partial class InstructorViewMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MembersForInstructorsDataGridView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)MembersForInstructorsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MembersForInstructorsDataGridView
            // 
            MembersForInstructorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembersForInstructorsDataGridView.Location = new Point(81, 119);
            MembersForInstructorsDataGridView.Name = "MembersForInstructorsDataGridView";
            MembersForInstructorsDataGridView.Size = new Size(532, 342);
            MembersForInstructorsDataGridView.TabIndex = 0;
            MembersForInstructorsDataGridView.CellContentClick += MembersForInstructorsDataGridView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 74);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 1;
            label1.Text = "Members on specific class";
            // 
            // InstructorViewMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 507);
            Controls.Add(label1);
            Controls.Add(MembersForInstructorsDataGridView);
            Name = "InstructorViewMembers";
            Text = "InstructorViewMembers";
            Load += InstructorViewMembers_Load;
            ((System.ComponentModel.ISupportInitialize)MembersForInstructorsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MembersForInstructorsDataGridView;
        private Label label1;
    }
}