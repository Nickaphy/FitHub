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
            textBoxSearchBarBooking = new TextBox();
            buttonSearchBooking = new Button();
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
            buttonBooking.BackgroundImage = (Image)resources.GetObject("buttonBooking.BackgroundImage");
            buttonBooking.BackgroundImageLayout = ImageLayout.Center;
            buttonBooking.FlatAppearance.BorderSize = 0;
            buttonBooking.FlatStyle = FlatStyle.Flat;
            buttonBooking.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonBooking.ForeColor = Color.FromArgb(73, 125, 201);
            buttonBooking.Location = new Point(305, 275);
            buttonBooking.Margin = new Padding(4);
            buttonBooking.Name = "buttonBooking";
            buttonBooking.Size = new Size(45, 45);
            buttonBooking.TabIndex = 10;
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
            dataGridViewClassOverviewBooking.Location = new Point(404, 134);
            dataGridViewClassOverviewBooking.Margin = new Padding(4);
            dataGridViewClassOverviewBooking.Name = "dataGridViewClassOverviewBooking";
            dataGridViewClassOverviewBooking.RowHeadersWidth = 82;
            dataGridViewClassOverviewBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClassOverviewBooking.Size = new Size(479, 338);
            dataGridViewClassOverviewBooking.TabIndex = 9;
            // 
            // dataGridViewMemberBooking
            // 
            dataGridViewMemberBooking.BackgroundColor = SystemColors.Window;
            dataGridViewMemberBooking.BorderStyle = BorderStyle.None;
            dataGridViewMemberBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMemberBooking.Location = new Point(25, 134);
            dataGridViewMemberBooking.Margin = new Padding(4);
            dataGridViewMemberBooking.Name = "dataGridViewMemberBooking";
            dataGridViewMemberBooking.RowHeadersWidth = 82;
            dataGridViewMemberBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMemberBooking.Size = new Size(231, 338);
            dataGridViewMemberBooking.TabIndex = 8;
            // 
            // labelMemberBooking
            // 
            labelMemberBooking.AutoSize = true;
            labelMemberBooking.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            labelMemberBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelMemberBooking.Location = new Point(18, 83);
            labelMemberBooking.Name = "labelMemberBooking";
            labelMemberBooking.Size = new Size(91, 28);
            labelMemberBooking.TabIndex = 11;
            labelMemberBooking.Text = "Member";
            // 
            // labelClassOverviewBooking
            // 
            labelClassOverviewBooking.AutoSize = true;
            labelClassOverviewBooking.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            labelClassOverviewBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelClassOverviewBooking.Location = new Point(397, 83);
            labelClassOverviewBooking.Name = "labelClassOverviewBooking";
            labelClassOverviewBooking.Size = new Size(155, 28);
            labelClassOverviewBooking.TabIndex = 12;
            labelClassOverviewBooking.Text = "Class Overview";
            // 
            // textBoxSearchBarBooking
            // 
            textBoxSearchBarBooking.BackColor = Color.FromArgb(74, 79, 99);
            textBoxSearchBarBooking.BorderStyle = BorderStyle.None;
            textBoxSearchBarBooking.ForeColor = Color.FromArgb(73, 125, 201);
            textBoxSearchBarBooking.Location = new Point(680, 28);
            textBoxSearchBarBooking.Name = "textBoxSearchBarBooking";
            textBoxSearchBarBooking.Size = new Size(205, 20);
            textBoxSearchBarBooking.TabIndex = 13;
            textBoxSearchBarBooking.Text = "Search for...";
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
            buttonSearchBooking.Location = new Point(633, 21);
            buttonSearchBooking.Name = "buttonSearchBooking";
            buttonSearchBooking.Size = new Size(36, 35);
            buttonSearchBooking.TabIndex = 14;
            buttonSearchBooking.UseVisualStyleBackColor = true;
            // 
            // pictureBoxHelp_Booking
            // 
            pictureBoxHelp_Booking.BackgroundImage = (Image)resources.GetObject("pictureBoxHelp_Booking.BackgroundImage");
            pictureBoxHelp_Booking.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHelp_Booking.Location = new Point(109, 88);
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
            labelHelp.Location = new Point(109, 60);
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
            labelAddingMemberToClass.Location = new Point(317, 261);
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
            labelHelpClassOverviewBooking.Location = new Point(552, 61);
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
            pictureBoxHelpClassOverview.Location = new Point(552, 89);
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
            ClientSize = new Size(911, 498);
            Controls.Add(labelHelpClassOverviewBooking);
            Controls.Add(pictureBoxHelpClassOverview);
            Controls.Add(labelAddingMemberToClass);
            Controls.Add(labelHelp);
            Controls.Add(pictureBoxHelp_Booking);
            Controls.Add(buttonSearchBooking);
            Controls.Add(textBoxSearchBarBooking);
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
        private TextBox textBoxSearchBarBooking;
        private Button buttonSearchBooking;
        private PictureBox pictureBoxHelp_Booking;
        private Label labelHelp;
        private Label labelAddingMemberToClass;
        private Label labelHelpClassOverviewBooking;
        private PictureBox pictureBoxHelpClassOverview;
    }
}