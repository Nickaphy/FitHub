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
            labelHelp_ClassOverview1 = new Label();
            pictureBoxHelp_ClassOverview1 = new PictureBox();
            labelHelp_ClassOverview2 = new Label();
            pictureBoxHelp_ClassOverview2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)InstructorGridViewInstructorManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassOverview1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassOverview2).BeginInit();
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
            dataGridView1.Location = new Point(377, 145);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(240, 326);
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
            label1.Location = new Point(377, 96);
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
            buttonAddInstructor.Click += buttonAddInstructor_Click;
            // 
            // labelHelp_ClassOverview1
            // 
            labelHelp_ClassOverview1.AutoSize = true;
            labelHelp_ClassOverview1.BackColor = Color.FromArgb(74, 79, 99);
            labelHelp_ClassOverview1.BorderStyle = BorderStyle.FixedSingle;
            labelHelp_ClassOverview1.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelHelp_ClassOverview1.ForeColor = Color.FromArgb(73, 125, 201);
            labelHelp_ClassOverview1.Location = new Point(133, 73);
            labelHelp_ClassOverview1.Name = "labelHelp_ClassOverview1";
            labelHelp_ClassOverview1.Padding = new Padding(1);
            labelHelp_ClassOverview1.Size = new Size(197, 19);
            labelHelp_ClassOverview1.TabIndex = 74;
            labelHelp_ClassOverview1.Text = "An overview of all the instructors";
            labelHelp_ClassOverview1.Visible = false;
            // 
            // pictureBoxHelp_ClassOverview1
            // 
            pictureBoxHelp_ClassOverview1.BackgroundImage = (Image)resources.GetObject("pictureBoxHelp_ClassOverview1.BackgroundImage");
            pictureBoxHelp_ClassOverview1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHelp_ClassOverview1.Location = new Point(133, 101);
            pictureBoxHelp_ClassOverview1.Name = "pictureBoxHelp_ClassOverview1";
            pictureBoxHelp_ClassOverview1.Size = new Size(20, 20);
            pictureBoxHelp_ClassOverview1.TabIndex = 73;
            pictureBoxHelp_ClassOverview1.TabStop = false;
            pictureBoxHelp_ClassOverview1.MouseEnter += pictureBoxHelp_ClassOverview1_MouseEnter;
            pictureBoxHelp_ClassOverview1.MouseLeave += pictureBoxHelp_ClassOverview1_MouseLeave;
            // 
            // labelHelp_ClassOverview2
            // 
            labelHelp_ClassOverview2.AutoSize = true;
            labelHelp_ClassOverview2.BackColor = Color.FromArgb(74, 79, 99);
            labelHelp_ClassOverview2.BorderStyle = BorderStyle.FixedSingle;
            labelHelp_ClassOverview2.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelHelp_ClassOverview2.ForeColor = Color.FromArgb(73, 125, 201);
            labelHelp_ClassOverview2.Location = new Point(458, 73);
            labelHelp_ClassOverview2.Name = "labelHelp_ClassOverview2";
            labelHelp_ClassOverview2.Padding = new Padding(1);
            labelHelp_ClassOverview2.Size = new Size(261, 19);
            labelHelp_ClassOverview2.TabIndex = 76;
            labelHelp_ClassOverview2.Text = "An overview of an specific instructors classes";
            labelHelp_ClassOverview2.Visible = false;
            // 
            // pictureBoxHelp_ClassOverview2
            // 
            pictureBoxHelp_ClassOverview2.BackgroundImage = (Image)resources.GetObject("pictureBoxHelp_ClassOverview2.BackgroundImage");
            pictureBoxHelp_ClassOverview2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHelp_ClassOverview2.Location = new Point(458, 101);
            pictureBoxHelp_ClassOverview2.Name = "pictureBoxHelp_ClassOverview2";
            pictureBoxHelp_ClassOverview2.Size = new Size(20, 20);
            pictureBoxHelp_ClassOverview2.TabIndex = 75;
            pictureBoxHelp_ClassOverview2.TabStop = false;
            pictureBoxHelp_ClassOverview2.MouseEnter += pictureBoxHelp_ClassOverview2_MouseEnter;
            pictureBoxHelp_ClassOverview2.MouseLeave += pictureBoxHelp_ClassOverview2_MouseLeave;
            // 
            // formClassOverviewTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 56);
            ClientSize = new Size(911, 498);
            Controls.Add(labelHelp_ClassOverview2);
            Controls.Add(pictureBoxHelp_ClassOverview2);
            Controls.Add(labelHelp_ClassOverview1);
            Controls.Add(pictureBoxHelp_ClassOverview1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassOverview1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassOverview2).EndInit();
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
        private Label labelHelp_ClassOverview1;
        private PictureBox pictureBoxHelp_ClassOverview1;
        private Label labelHelp_ClassOverview2;
        private PictureBox pictureBoxHelp_ClassOverview2;
    }
}