namespace FitHub._1._UserInterface
{
    partial class formMemberOverviewTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMemberOverviewTab));
            DataGridViewMembersMembersOverview = new DataGridView();
            buttonSearchMember = new Button();
            textBoxSearchBarMember = new TextBox();
            labelMemberBooking = new Label();
            dataGridViewMemberHistory = new DataGridView();
            label1 = new Label();
            buttonMemberHistory = new Button();
            labelHelp_MemberOverview1 = new Label();
            pictureBox_MemberOverview1 = new PictureBox();
            labelHelp_MemberOverview2 = new Label();
            pictureBox_MemberOverview2 = new PictureBox();
            labelHelp_MemberOverview3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMembersMembersOverview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMemberHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_MemberOverview1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_MemberOverview2).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewMembersMembersOverview
            // 
            DataGridViewMembersMembersOverview.AccessibleRole = AccessibleRole.Cursor;
            DataGridViewMembersMembersOverview.BackgroundColor = SystemColors.Window;
            DataGridViewMembersMembersOverview.BorderStyle = BorderStyle.None;
            DataGridViewMembersMembersOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMembersMembersOverview.Location = new Point(26, 131);
            DataGridViewMembersMembersOverview.Margin = new Padding(4);
            DataGridViewMembersMembersOverview.Name = "DataGridViewMembersMembersOverview";
            DataGridViewMembersMembersOverview.RowHeadersWidth = 82;
            DataGridViewMembersMembersOverview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMembersMembersOverview.Size = new Size(191, 339);
            DataGridViewMembersMembersOverview.TabIndex = 51;
            // 
            // buttonSearchMember
            // 
            buttonSearchMember.BackgroundImage = (Image)resources.GetObject("buttonSearchMember.BackgroundImage");
            buttonSearchMember.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearchMember.FlatAppearance.BorderColor = Color.FromArgb(31, 34, 56);
            buttonSearchMember.FlatStyle = FlatStyle.Flat;
            buttonSearchMember.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchMember.ForeColor = SystemColors.ButtonHighlight;
            buttonSearchMember.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearchMember.Location = new Point(388, 168);
            buttonSearchMember.Name = "buttonSearchMember";
            buttonSearchMember.Size = new Size(36, 35);
            buttonSearchMember.TabIndex = 61;
            buttonSearchMember.UseVisualStyleBackColor = true;
            buttonSearchMember.Click += buttonSearchMember_Click;
            // 
            // textBoxSearchBarMember
            // 
            textBoxSearchBarMember.BackColor = Color.FromArgb(74, 79, 99);
            textBoxSearchBarMember.BorderStyle = BorderStyle.None;
            textBoxSearchBarMember.ForeColor = Color.FromArgb(73, 125, 201);
            textBoxSearchBarMember.Location = new Point(255, 176);
            textBoxSearchBarMember.Name = "textBoxSearchBarMember";
            textBoxSearchBarMember.Size = new Size(133, 20);
            textBoxSearchBarMember.TabIndex = 60;
            textBoxSearchBarMember.Text = "Search for...";
            // 
            // labelMemberBooking
            // 
            labelMemberBooking.AutoSize = true;
            labelMemberBooking.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            labelMemberBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelMemberBooking.Location = new Point(20, 88);
            labelMemberBooking.Name = "labelMemberBooking";
            labelMemberBooking.Size = new Size(100, 28);
            labelMemberBooking.TabIndex = 62;
            labelMemberBooking.Text = "Members";
            // 
            // dataGridViewMemberHistory
            // 
            dataGridViewMemberHistory.AccessibleRole = AccessibleRole.Cursor;
            dataGridViewMemberHistory.BackgroundColor = SystemColors.Window;
            dataGridViewMemberHistory.BorderStyle = BorderStyle.None;
            dataGridViewMemberHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMemberHistory.Location = new Point(451, 131);
            dataGridViewMemberHistory.Margin = new Padding(4);
            dataGridViewMemberHistory.Name = "dataGridViewMemberHistory";
            dataGridViewMemberHistory.RowHeadersWidth = 82;
            dataGridViewMemberHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMemberHistory.Size = new Size(431, 339);
            dataGridViewMemberHistory.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(73, 125, 201);
            label1.Location = new Point(446, 87);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 64;
            label1.Text = "Member History";
            // 
            // buttonMemberHistory
            // 
            buttonMemberHistory.BackColor = Color.FromArgb(31, 34, 56);
            buttonMemberHistory.BackgroundImage = (Image)resources.GetObject("buttonMemberHistory.BackgroundImage");
            buttonMemberHistory.BackgroundImageLayout = ImageLayout.Center;
            buttonMemberHistory.FlatAppearance.BorderSize = 0;
            buttonMemberHistory.FlatStyle = FlatStyle.Flat;
            buttonMemberHistory.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonMemberHistory.ForeColor = Color.FromArgb(73, 125, 201);
            buttonMemberHistory.Location = new Point(311, 267);
            buttonMemberHistory.Margin = new Padding(4);
            buttonMemberHistory.Name = "buttonMemberHistory";
            buttonMemberHistory.Size = new Size(50, 50);
            buttonMemberHistory.TabIndex = 65;
            buttonMemberHistory.UseVisualStyleBackColor = false;
            buttonMemberHistory.Click += buttonMemberHistory_Click;
            buttonMemberHistory.MouseEnter += buttonMemberHistory_MouseEnter;
            buttonMemberHistory.MouseLeave += buttonMemberHistory_MouseLeave;
            // 
            // labelHelp_MemberOverview1
            // 
            labelHelp_MemberOverview1.AutoSize = true;
            labelHelp_MemberOverview1.BackColor = Color.FromArgb(74, 79, 99);
            labelHelp_MemberOverview1.BorderStyle = BorderStyle.FixedSingle;
            labelHelp_MemberOverview1.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelHelp_MemberOverview1.ForeColor = Color.FromArgb(73, 125, 201);
            labelHelp_MemberOverview1.Location = new Point(120, 67);
            labelHelp_MemberOverview1.Name = "labelHelp_MemberOverview1";
            labelHelp_MemberOverview1.Padding = new Padding(1);
            labelHelp_MemberOverview1.Size = new Size(158, 19);
            labelHelp_MemberOverview1.TabIndex = 67;
            labelHelp_MemberOverview1.Text = "A list showing all members";
            labelHelp_MemberOverview1.Visible = false;
            // 
            // pictureBox_MemberOverview1
            // 
            pictureBox_MemberOverview1.BackgroundImage = (Image)resources.GetObject("pictureBox_MemberOverview1.BackgroundImage");
            pictureBox_MemberOverview1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_MemberOverview1.Location = new Point(120, 95);
            pictureBox_MemberOverview1.Name = "pictureBox_MemberOverview1";
            pictureBox_MemberOverview1.Size = new Size(20, 20);
            pictureBox_MemberOverview1.TabIndex = 66;
            pictureBox_MemberOverview1.TabStop = false;
            pictureBox_MemberOverview1.MouseEnter += pictureBox_MemberOverview1_MouseEnter;
            pictureBox_MemberOverview1.MouseLeave += pictureBox_MemberOverview1_MouseLeave;
            // 
            // labelHelp_MemberOverview2
            // 
            labelHelp_MemberOverview2.AutoSize = true;
            labelHelp_MemberOverview2.BackColor = Color.FromArgb(74, 79, 99);
            labelHelp_MemberOverview2.BorderStyle = BorderStyle.FixedSingle;
            labelHelp_MemberOverview2.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelHelp_MemberOverview2.ForeColor = Color.FromArgb(73, 125, 201);
            labelHelp_MemberOverview2.Location = new Point(614, 67);
            labelHelp_MemberOverview2.Name = "labelHelp_MemberOverview2";
            labelHelp_MemberOverview2.Padding = new Padding(1);
            labelHelp_MemberOverview2.Size = new Size(300, 19);
            labelHelp_MemberOverview2.TabIndex = 69;
            labelHelp_MemberOverview2.Text = "A list showing a members complete member history";
            labelHelp_MemberOverview2.Visible = false;
            // 
            // pictureBox_MemberOverview2
            // 
            pictureBox_MemberOverview2.BackgroundImage = (Image)resources.GetObject("pictureBox_MemberOverview2.BackgroundImage");
            pictureBox_MemberOverview2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_MemberOverview2.Location = new Point(614, 95);
            pictureBox_MemberOverview2.Name = "pictureBox_MemberOverview2";
            pictureBox_MemberOverview2.Size = new Size(20, 20);
            pictureBox_MemberOverview2.TabIndex = 68;
            pictureBox_MemberOverview2.TabStop = false;
            pictureBox_MemberOverview2.MouseEnter += pictureBox_MemberOverview2_MouseEnter;
            pictureBox_MemberOverview2.MouseLeave += pictureBox_MemberOverview2_MouseLeave;
            // 
            // labelHelp_MemberOverview3
            // 
            labelHelp_MemberOverview3.AutoSize = true;
            labelHelp_MemberOverview3.BackColor = Color.FromArgb(74, 79, 99);
            labelHelp_MemberOverview3.BorderStyle = BorderStyle.FixedSingle;
            labelHelp_MemberOverview3.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelHelp_MemberOverview3.ForeColor = Color.FromArgb(73, 125, 201);
            labelHelp_MemberOverview3.Location = new Point(325, 312);
            labelHelp_MemberOverview3.Name = "labelHelp_MemberOverview3";
            labelHelp_MemberOverview3.Padding = new Padding(1);
            labelHelp_MemberOverview3.Size = new Size(500, 19);
            labelHelp_MemberOverview3.TabIndex = 70;
            labelHelp_MemberOverview3.Text = "When clicking this button, the member history list will show a complete member history";
            labelHelp_MemberOverview3.Visible = false;
            // 
            // formMemberOverviewTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 56);
            ClientSize = new Size(911, 498);
            Controls.Add(labelHelp_MemberOverview3);
            Controls.Add(labelHelp_MemberOverview2);
            Controls.Add(pictureBox_MemberOverview2);
            Controls.Add(labelHelp_MemberOverview1);
            Controls.Add(pictureBox_MemberOverview1);
            Controls.Add(dataGridViewMemberHistory);
            Controls.Add(textBoxSearchBarMember);
            Controls.Add(DataGridViewMembersMembersOverview);
            Controls.Add(labelMemberBooking);
            Controls.Add(label1);
            Controls.Add(buttonMemberHistory);
            Controls.Add(buttonSearchMember);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMemberOverviewTab";
            Text = "formMemberOverviewTab";
            ((System.ComponentModel.ISupportInitialize)DataGridViewMembersMembersOverview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMemberHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_MemberOverview1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_MemberOverview2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DataGridViewMembersMembersOverview;
        private Button buttonSearchMember;
        private TextBox textBoxSearchBarMember;
        private Label labelMemberBooking;
        private DataGridView dataGridViewMemberHistory;
        private Label label1;
        private Button buttonMemberHistory;
        private Label labelHelp_MemberOverview1;
        private PictureBox pictureBox_MemberOverview1;
        private Label labelHelp_MemberOverview2;
        private PictureBox pictureBox_MemberOverview2;
        private Label labelHelp_MemberOverview3;
    }
}