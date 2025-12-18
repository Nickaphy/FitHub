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
            DataGridViewInstructor = new DataGridView();
            dataGridViewClasses = new DataGridView();
            labelMemberBooking = new Label();
            label1 = new Label();
            buttonRetrieveClasses = new Button();
            buttonAddInstructor = new Button();
            labelHelp_ClassOverview1 = new Label();
            pictureBoxHelp_ClassOverview1 = new PictureBox();
            labelHelp_ClassOverview2 = new Label();
            pictureBoxHelp_ClassOverview2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInstructor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassOverview1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassOverview2).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewInstructor
            // 
            DataGridViewInstructor.AccessibleRole = AccessibleRole.Cursor;
            DataGridViewInstructor.BackgroundColor = SystemColors.Window;
            DataGridViewInstructor.BorderStyle = BorderStyle.None;
            DataGridViewInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewInstructor.Location = new Point(42, 232);
            DataGridViewInstructor.Margin = new Padding(6);
            DataGridViewInstructor.Name = "DataGridViewInstructor";
            DataGridViewInstructor.RowHeadersVisible = false;
            DataGridViewInstructor.RowHeadersWidth = 82;
            DataGridViewInstructor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewInstructor.Size = new Size(471, 522);
            DataGridViewInstructor.TabIndex = 32;
            // 
            // dataGridViewClasses
            // 
            dataGridViewClasses.AccessibleRole = AccessibleRole.Cursor;
            dataGridViewClasses.BackgroundColor = SystemColors.Window;
            dataGridViewClasses.BorderStyle = BorderStyle.None;
            dataGridViewClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClasses.Location = new Point(613, 232);
            dataGridViewClasses.Margin = new Padding(6);
            dataGridViewClasses.Name = "dataGridViewClasses";
            dataGridViewClasses.RowHeadersVisible = false;
            dataGridViewClasses.RowHeadersWidth = 82;
            dataGridViewClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClasses.Size = new Size(390, 522);
            dataGridViewClasses.TabIndex = 51;
            // 
            // labelMemberBooking
            // 
            labelMemberBooking.AutoSize = true;
            labelMemberBooking.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            labelMemberBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelMemberBooking.Location = new Point(32, 154);
            labelMemberBooking.Margin = new Padding(5, 0, 5, 0);
            labelMemberBooking.Name = "labelMemberBooking";
            labelMemberBooking.Size = new Size(181, 45);
            labelMemberBooking.TabIndex = 52;
            labelMemberBooking.Text = "Instructors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(73, 125, 201);
            label1.Location = new Point(613, 154);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 45);
            label1.TabIndex = 53;
            label1.Text = "Classes";
            // 
            // buttonRetrieveClasses
            // 
            buttonRetrieveClasses.BackColor = Color.FromArgb(31, 34, 56);
            buttonRetrieveClasses.FlatStyle = FlatStyle.Flat;
            buttonRetrieveClasses.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonRetrieveClasses.ForeColor = Color.FromArgb(73, 125, 201);
            buttonRetrieveClasses.Location = new Point(284, 149);
            buttonRetrieveClasses.Margin = new Padding(6);
            buttonRetrieveClasses.Name = "buttonRetrieveClasses";
            buttonRetrieveClasses.Size = new Size(229, 50);
            buttonRetrieveClasses.TabIndex = 55;
            buttonRetrieveClasses.Text = "Retrieve Classes";
            buttonRetrieveClasses.UseVisualStyleBackColor = false;
            buttonRetrieveClasses.Click += buttonRetrieveClasses_Click;
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
            buttonAddInstructor.Location = new Point(1097, 688);
            buttonAddInstructor.Margin = new Padding(6);
            buttonAddInstructor.Name = "buttonAddInstructor";
            buttonAddInstructor.Size = new Size(341, 66);
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
            labelHelp_ClassOverview1.Location = new Point(216, 117);
            labelHelp_ClassOverview1.Margin = new Padding(5, 0, 5, 0);
            labelHelp_ClassOverview1.Name = "labelHelp_ClassOverview1";
            labelHelp_ClassOverview1.Padding = new Padding(2);
            labelHelp_ClassOverview1.Size = new Size(312, 31);
            labelHelp_ClassOverview1.TabIndex = 74;
            labelHelp_ClassOverview1.Text = "An overview of all the instructors";
            labelHelp_ClassOverview1.Visible = false;
            // 
            // pictureBoxHelp_ClassOverview1
            // 
            pictureBoxHelp_ClassOverview1.BackgroundImage = (Image)resources.GetObject("pictureBoxHelp_ClassOverview1.BackgroundImage");
            pictureBoxHelp_ClassOverview1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHelp_ClassOverview1.Location = new Point(216, 162);
            pictureBoxHelp_ClassOverview1.Margin = new Padding(5);
            pictureBoxHelp_ClassOverview1.Name = "pictureBoxHelp_ClassOverview1";
            pictureBoxHelp_ClassOverview1.Size = new Size(32, 32);
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
            labelHelp_ClassOverview2.Location = new Point(744, 117);
            labelHelp_ClassOverview2.Margin = new Padding(5, 0, 5, 0);
            labelHelp_ClassOverview2.Name = "labelHelp_ClassOverview2";
            labelHelp_ClassOverview2.Padding = new Padding(2);
            labelHelp_ClassOverview2.Size = new Size(414, 31);
            labelHelp_ClassOverview2.TabIndex = 76;
            labelHelp_ClassOverview2.Text = "An overview of an specific instructors classes";
            labelHelp_ClassOverview2.Visible = false;
            // 
            // pictureBoxHelp_ClassOverview2
            // 
            pictureBoxHelp_ClassOverview2.BackgroundImage = (Image)resources.GetObject("pictureBoxHelp_ClassOverview2.BackgroundImage");
            pictureBoxHelp_ClassOverview2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHelp_ClassOverview2.Location = new Point(744, 162);
            pictureBoxHelp_ClassOverview2.Margin = new Padding(5);
            pictureBoxHelp_ClassOverview2.Name = "pictureBoxHelp_ClassOverview2";
            pictureBoxHelp_ClassOverview2.Size = new Size(32, 32);
            pictureBoxHelp_ClassOverview2.TabIndex = 75;
            pictureBoxHelp_ClassOverview2.TabStop = false;
            pictureBoxHelp_ClassOverview2.MouseEnter += pictureBoxHelp_ClassOverview2_MouseEnter;
            pictureBoxHelp_ClassOverview2.MouseLeave += pictureBoxHelp_ClassOverview2_MouseLeave;
            // 
            // formClassOverviewTab
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 56);
            ClientSize = new Size(1480, 797);
            Controls.Add(labelHelp_ClassOverview2);
            Controls.Add(pictureBoxHelp_ClassOverview2);
            Controls.Add(labelHelp_ClassOverview1);
            Controls.Add(pictureBoxHelp_ClassOverview1);
            Controls.Add(buttonAddInstructor);
            Controls.Add(buttonRetrieveClasses);
            Controls.Add(dataGridViewClasses);
            Controls.Add(DataGridViewInstructor);
            Controls.Add(labelMemberBooking);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "formClassOverviewTab";
            Text = "formClassOverviewTab";
            ((System.ComponentModel.ISupportInitialize)DataGridViewInstructor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassOverview1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassOverview2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewInstructor;
        private DataGridView dataGridViewClasses;
        private Label labelMemberBooking;
        private Label label1;
        private Button buttonRetrieveClasses;
        private Button buttonAddInstructor;
        private Label labelHelp_ClassOverview1;
        private PictureBox pictureBoxHelp_ClassOverview1;
        private Label labelHelp_ClassOverview2;
        private PictureBox pictureBoxHelp_ClassOverview2;
    }
}