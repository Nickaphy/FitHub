namespace FitHub._1._UserInterface
{
    partial class formClassOverviewTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formClassOverviewTab));
            InstructorGridViewInstructorManagement = new DataGridView();
            dataGridView1 = new DataGridView();
            labelMemberBooking = new Label();
            label1 = new Label();
            buttonSearchBooking = new Button();
            textBoxSearchBarBooking = new TextBox();
            buttonBooking = new Button();
            buttonAddInstructor = new Button();
            ((System.ComponentModel.ISupportInitialize)InstructorGridViewInstructorManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // InstructorGridViewInstructorManagement
            // 
            InstructorGridViewInstructorManagement.AccessibleRole = AccessibleRole.Cursor;
            InstructorGridViewInstructorManagement.BackgroundColor = SystemColors.Window;
            InstructorGridViewInstructorManagement.BorderStyle = BorderStyle.None;
            InstructorGridViewInstructorManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InstructorGridViewInstructorManagement.Location = new Point(26, 145);
            InstructorGridViewInstructorManagement.Margin = new Padding(4);
            InstructorGridViewInstructorManagement.Name = "InstructorGridViewInstructorManagement";
            InstructorGridViewInstructorManagement.RowHeadersWidth = 82;
            InstructorGridViewInstructorManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InstructorGridViewInstructorManagement.Size = new Size(290, 326);
            InstructorGridViewInstructorManagement.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.Cursor;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(377, 216);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(240, 255);
            dataGridView1.TabIndex = 51;
            // 
            // labelMemberBooking
            // 
            labelMemberBooking.AutoSize = true;
            labelMemberBooking.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            labelMemberBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelMemberBooking.Location = new Point(20, 96);
            labelMemberBooking.Name = "labelMemberBooking";
            labelMemberBooking.Size = new Size(114, 28);
            labelMemberBooking.TabIndex = 52;
            labelMemberBooking.Text = "Instructors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(73, 125, 201);
            label1.Location = new Point(371, 160);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 53;
            label1.Text = "Classes";
            // 
            // buttonSearchBooking
            // 
            buttonSearchBooking.BackgroundImage = (Image)resources.GetObject("buttonSearchBooking.BackgroundImage");
            buttonSearchBooking.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearchBooking.FlatAppearance.BorderColor = Color.FromArgb(31, 34, 56);
            buttonSearchBooking.FlatStyle = FlatStyle.Flat;
            buttonSearchBooking.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchBooking.ForeColor = SystemColors.ButtonHighlight;
            buttonSearchBooking.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearchBooking.Location = new Point(633, 22);
            buttonSearchBooking.Name = "buttonSearchBooking";
            buttonSearchBooking.Size = new Size(36, 35);
            buttonSearchBooking.TabIndex = 16;
            buttonSearchBooking.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchBarBooking
            // 
            textBoxSearchBarBooking.BackColor = Color.FromArgb(74, 79, 99);
            textBoxSearchBarBooking.BorderStyle = BorderStyle.None;
            textBoxSearchBarBooking.ForeColor = Color.FromArgb(73, 125, 201);
            textBoxSearchBarBooking.Location = new Point(680, 29);
            textBoxSearchBarBooking.Name = "textBoxSearchBarBooking";
            textBoxSearchBarBooking.Size = new Size(205, 20);
            textBoxSearchBarBooking.TabIndex = 15;
            textBoxSearchBarBooking.Text = "Search for...";
            // 
            // buttonBooking
            // 
            buttonBooking.BackColor = Color.FromArgb(31, 34, 56);
            buttonBooking.FlatStyle = FlatStyle.Flat;
            buttonBooking.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonBooking.ForeColor = Color.FromArgb(73, 125, 201);
            buttonBooking.Location = new Point(175, 93);
            buttonBooking.Margin = new Padding(4);
            buttonBooking.Name = "buttonBooking";
            buttonBooking.Size = new Size(141, 31);
            buttonBooking.TabIndex = 55;
            buttonBooking.Text = "Retrieve Classes";
            buttonBooking.UseVisualStyleBackColor = false;
            // 
            // buttonAddInstructor
            // 
            buttonAddInstructor.BackColor = Color.FromArgb(31, 34, 56);
            buttonAddInstructor.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddInstructor.FlatStyle = FlatStyle.Flat;
            buttonAddInstructor.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonAddInstructor.ForeColor = Color.FromArgb(73, 125, 201);
            buttonAddInstructor.Image = (Image)resources.GetObject("buttonAddInstructor.Image");
            buttonAddInstructor.ImageAlign = ContentAlignment.TopRight;
            buttonAddInstructor.Location = new Point(675, 430);
            buttonAddInstructor.Margin = new Padding(4);
            buttonAddInstructor.Name = "buttonAddInstructor";
            buttonAddInstructor.Size = new Size(210, 41);
            buttonAddInstructor.TabIndex = 56;
            buttonAddInstructor.Text = "Show Members";
            buttonAddInstructor.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddInstructor.UseVisualStyleBackColor = false;
            // 
            // formClassOverviewTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 56);
            ClientSize = new Size(911, 498);
            Controls.Add(buttonAddInstructor);
            Controls.Add(buttonBooking);
            Controls.Add(dataGridView1);
            Controls.Add(InstructorGridViewInstructorManagement);
            Controls.Add(labelMemberBooking);
            Controls.Add(label1);
            Controls.Add(buttonSearchBooking);
            Controls.Add(textBoxSearchBarBooking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formClassOverviewTab";
            Text = "formClassOverviewTab";
            ((System.ComponentModel.ISupportInitialize)InstructorGridViewInstructorManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView InstructorGridViewInstructorManagement;
        private DataGridView dataGridView1;
        private Label labelMemberBooking;
        private Label label1;
        private Button buttonSearchBooking;
        private TextBox textBoxSearchBarBooking;
        private Button buttonBooking;
        private Button buttonAddInstructor;
    }
}