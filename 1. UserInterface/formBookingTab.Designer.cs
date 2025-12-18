namespace FitHub._1._UserInterface
{
    partial class formBookingTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBookingTab));
            buttonBooking = new Button();
            dataGridViewClassOverviewBooking = new DataGridView();
            dataGridViewMemberBooking = new DataGridView();
            labelMemberBooking = new Label();
            labelClassOverviewBooking = new Label();
            pictureBoxHelp_Booking = new PictureBox();
            labelHelp = new Label();
            labelAddingMemberToClass = new Label();
            labelHelpClassOverviewBooking = new Label();
            pictureBoxHelpClassOverview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassOverviewBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMemberBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_Booking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelpClassOverview).BeginInit();
            SuspendLayout();
            // 
            // buttonBooking
            // 
            buttonBooking.BackColor = Color.FromArgb(31, 34, 56);
            buttonBooking.BackgroundImageLayout = ImageLayout.Center;
            buttonBooking.FlatStyle = FlatStyle.Flat;
            buttonBooking.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonBooking.ForeColor = Color.FromArgb(73, 125, 201);
            buttonBooking.Image = (Image)resources.GetObject("buttonBooking.Image");
            buttonBooking.Location = new Point(441, 364);
            buttonBooking.Margin = new Padding(4);
            buttonBooking.Name = "buttonBooking";
            buttonBooking.Size = new Size(128, 62);
            buttonBooking.TabIndex = 10;
            buttonBooking.Text = "Add member";
            buttonBooking.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBooking.UseVisualStyleBackColor = false;
            buttonBooking.Click += buttonBooking_Click;
            buttonBooking.MouseEnter += buttonBooking_MouseEnter;
            buttonBooking.MouseLeave += buttonBooking_MouseLeave;
            // 
            // dataGridViewClassOverviewBooking
            // 
            dataGridViewClassOverviewBooking.BackgroundColor = SystemColors.Window;
            dataGridViewClassOverviewBooking.BorderStyle = BorderStyle.None;
            dataGridViewClassOverviewBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClassOverviewBooking.Location = new Point(592, 128);
            dataGridViewClassOverviewBooking.Margin = new Padding(4);
            dataGridViewClassOverviewBooking.Name = "dataGridViewClassOverviewBooking";
            dataGridViewClassOverviewBooking.RowHeadersVisible = false;
            dataGridViewClassOverviewBooking.RowHeadersWidth = 82;
            dataGridViewClassOverviewBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClassOverviewBooking.Size = new Size(606, 582);
            dataGridViewClassOverviewBooking.TabIndex = 9;
            // 
            // dataGridViewMemberBooking
            // 
            dataGridViewMemberBooking.BackgroundColor = SystemColors.Window;
            dataGridViewMemberBooking.BorderStyle = BorderStyle.None;
            dataGridViewMemberBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMemberBooking.Location = new Point(26, 128);
            dataGridViewMemberBooking.Margin = new Padding(4);
            dataGridViewMemberBooking.Name = "dataGridViewMemberBooking";
            dataGridViewMemberBooking.RowHeadersVisible = false;
            dataGridViewMemberBooking.RowHeadersWidth = 82;
            dataGridViewMemberBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMemberBooking.Size = new Size(395, 584);
            dataGridViewMemberBooking.TabIndex = 8;
            // 
            // labelMemberBooking
            // 
            labelMemberBooking.AutoSize = true;
            labelMemberBooking.Font = new Font("Nirmala UI", 20F, FontStyle.Bold);
            labelMemberBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelMemberBooking.Location = new Point(19, 59);
            labelMemberBooking.Name = "labelMemberBooking";
            labelMemberBooking.Size = new Size(155, 46);
            labelMemberBooking.TabIndex = 11;
            labelMemberBooking.Text = "Member";
            // 
            // labelClassOverviewBooking
            // 
            labelClassOverviewBooking.AutoSize = true;
            labelClassOverviewBooking.Font = new Font("Nirmala UI", 20F, FontStyle.Bold);
            labelClassOverviewBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelClassOverviewBooking.Location = new Point(584, 59);
            labelClassOverviewBooking.Name = "labelClassOverviewBooking";
            labelClassOverviewBooking.Size = new Size(258, 46);
            labelClassOverviewBooking.TabIndex = 12;
            labelClassOverviewBooking.Text = "Class Overview";
            // 
            // pictureBoxHelp_Booking
            // 
            pictureBoxHelp_Booking.BackgroundImage = (Image)resources.GetObject("pictureBoxHelp_Booking.BackgroundImage");
            pictureBoxHelp_Booking.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHelp_Booking.Location = new Point(170, 78);
            pictureBoxHelp_Booking.Name = "pictureBoxHelp_Booking";
            pictureBoxHelp_Booking.Size = new Size(20, 20);
            pictureBoxHelp_Booking.TabIndex = 15;
            pictureBoxHelp_Booking.TabStop = false;
            pictureBoxHelp_Booking.MouseEnter += pictureBoxHelp_Booking_MouseEnter;
            pictureBoxHelp_Booking.MouseLeave += pictureBoxHelp_Booking_MouseLeave;
            // 
            // labelHelp
            // 
            labelHelp.AutoSize = true;
            labelHelp.BackColor = Color.FromArgb(74, 79, 99);
            labelHelp.BorderStyle = BorderStyle.FixedSingle;
            labelHelp.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelHelp.ForeColor = Color.FromArgb(73, 125, 201);
            labelHelp.Location = new Point(168, 52);
            labelHelp.Name = "labelHelp";
            labelHelp.Padding = new Padding(1);
            labelHelp.Size = new Size(158, 19);
            labelHelp.TabIndex = 16;
            labelHelp.Text = "A list showing all members";
            labelHelp.Visible = false;
            // 
            // labelAddingMemberToClass
            // 
            labelAddingMemberToClass.AutoSize = true;
            labelAddingMemberToClass.BackColor = Color.FromArgb(74, 79, 99);
            labelAddingMemberToClass.BorderStyle = BorderStyle.FixedSingle;
            labelAddingMemberToClass.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelAddingMemberToClass.ForeColor = Color.FromArgb(73, 125, 201);
            labelAddingMemberToClass.Location = new Point(496, 332);
            labelAddingMemberToClass.Name = "labelAddingMemberToClass";
            labelAddingMemberToClass.Padding = new Padding(1);
            labelAddingMemberToClass.Size = new Size(162, 19);
            labelAddingMemberToClass.TabIndex = 17;
            labelAddingMemberToClass.Text = "Adding a member to a class";
            labelAddingMemberToClass.Visible = false;
            // 
            // labelHelpClassOverviewBooking
            // 
            labelHelpClassOverviewBooking.AutoSize = true;
            labelHelpClassOverviewBooking.BackColor = Color.FromArgb(74, 79, 99);
            labelHelpClassOverviewBooking.BorderStyle = BorderStyle.FixedSingle;
            labelHelpClassOverviewBooking.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelHelpClassOverviewBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelHelpClassOverviewBooking.Location = new Point(837, 52);
            labelHelpClassOverviewBooking.Name = "labelHelpClassOverviewBooking";
            labelHelpClassOverviewBooking.Padding = new Padding(1);
            labelHelpClassOverviewBooking.Size = new Size(142, 19);
            labelHelpClassOverviewBooking.TabIndex = 19;
            labelHelpClassOverviewBooking.Text = "A list showing all classes";
            labelHelpClassOverviewBooking.Visible = false;
            // 
            // pictureBoxHelpClassOverview
            // 
            pictureBoxHelpClassOverview.BackgroundImage = (Image)resources.GetObject("pictureBoxHelpClassOverview.BackgroundImage");
            pictureBoxHelpClassOverview.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHelpClassOverview.Location = new Point(838, 78);
            pictureBoxHelpClassOverview.Name = "pictureBoxHelpClassOverview";
            pictureBoxHelpClassOverview.Size = new Size(20, 20);
            pictureBoxHelpClassOverview.TabIndex = 18;
            pictureBoxHelpClassOverview.TabStop = false;
            pictureBoxHelpClassOverview.MouseEnter += pictureBoxHelpClassOverview_MouseEnter;
            pictureBoxHelpClassOverview.MouseLeave += pictureBoxHelpClassOverview_MouseLeave;
            // 
            // formBookingTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 56);
            ClientSize = new Size(1225, 738);
            Controls.Add(labelHelpClassOverviewBooking);
            Controls.Add(pictureBoxHelpClassOverview);
            Controls.Add(labelAddingMemberToClass);
            Controls.Add(labelHelp);
            Controls.Add(pictureBoxHelp_Booking);
            Controls.Add(labelClassOverviewBooking);
            Controls.Add(labelMemberBooking);
            Controls.Add(buttonBooking);
            Controls.Add(dataGridViewClassOverviewBooking);
            Controls.Add(dataGridViewMemberBooking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formBookingTab";
            Text = "formBookingTab";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassOverviewBooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMemberBooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_Booking).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelpClassOverview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBooking;
        private DataGridView dataGridViewClassOverviewBooking;
        private DataGridView dataGridViewMemberBooking;
        private Label labelMemberBooking;
        private Label labelClassOverviewBooking;
        private PictureBox pictureBoxHelp_Booking;
        private Label labelHelp;
        private Label labelAddingMemberToClass;
        private Label labelHelpClassOverviewBooking;
        private PictureBox pictureBoxHelpClassOverview;
    }
}