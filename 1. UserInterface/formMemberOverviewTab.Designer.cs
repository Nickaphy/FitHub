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
            InstructorGridViewInstructorManagement = new DataGridView();
            buttonSearchInstructorManagement = new Button();
            textBoxSearchBarInstructorManagement = new TextBox();
            labelMemberBooking = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            buttonBooking = new Button();
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
            InstructorGridViewInstructorManagement.Location = new Point(26, 131);
            InstructorGridViewInstructorManagement.Margin = new Padding(4);
            InstructorGridViewInstructorManagement.Name = "InstructorGridViewInstructorManagement";
            InstructorGridViewInstructorManagement.RowHeadersWidth = 82;
            InstructorGridViewInstructorManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InstructorGridViewInstructorManagement.Size = new Size(191, 339);
            InstructorGridViewInstructorManagement.TabIndex = 51;
            // 
            // buttonSearchInstructorManagement
            // 
            buttonSearchInstructorManagement.BackgroundImage = (Image)resources.GetObject("buttonSearchInstructorManagement.BackgroundImage");
            buttonSearchInstructorManagement.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearchInstructorManagement.FlatAppearance.BorderColor = Color.FromArgb(31, 34, 56);
            buttonSearchInstructorManagement.FlatStyle = FlatStyle.Flat;
            buttonSearchInstructorManagement.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchInstructorManagement.ForeColor = SystemColors.ButtonHighlight;
            buttonSearchInstructorManagement.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearchInstructorManagement.Location = new Point(630, 23);
            buttonSearchInstructorManagement.Name = "buttonSearchInstructorManagement";
            buttonSearchInstructorManagement.Size = new Size(36, 35);
            buttonSearchInstructorManagement.TabIndex = 61;
            buttonSearchInstructorManagement.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchBarInstructorManagement
            // 
            textBoxSearchBarInstructorManagement.BackColor = Color.FromArgb(74, 79, 99);
            textBoxSearchBarInstructorManagement.BorderStyle = BorderStyle.None;
            textBoxSearchBarInstructorManagement.ForeColor = Color.FromArgb(73, 125, 201);
            textBoxSearchBarInstructorManagement.Location = new Point(677, 30);
            textBoxSearchBarInstructorManagement.Name = "textBoxSearchBarInstructorManagement";
            textBoxSearchBarInstructorManagement.Size = new Size(205, 20);
            textBoxSearchBarInstructorManagement.TabIndex = 60;
            textBoxSearchBarInstructorManagement.Text = "Search for...";
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
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.Cursor;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 131);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(550, 339);
            dataGridView1.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(73, 125, 201);
            label1.Location = new Point(330, 87);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 64;
            label1.Text = "Member History";
            // 
            // buttonBooking
            // 
            buttonBooking.BackColor = Color.FromArgb(31, 34, 56);
            buttonBooking.BackgroundImage = (Image)resources.GetObject("buttonBooking.BackgroundImage");
            buttonBooking.BackgroundImageLayout = ImageLayout.Center;
            buttonBooking.FlatStyle = FlatStyle.Flat;
            buttonBooking.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonBooking.ForeColor = Color.FromArgb(73, 125, 201);
            buttonBooking.Location = new Point(250, 262);
            buttonBooking.Margin = new Padding(4);
            buttonBooking.Name = "buttonBooking";
            buttonBooking.Size = new Size(50, 50);
            buttonBooking.TabIndex = 65;
            buttonBooking.UseVisualStyleBackColor = false;
            // 
            // formMemberOverviewTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 56);
            ClientSize = new Size(911, 498);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearchInstructorManagement);
            Controls.Add(textBoxSearchBarInstructorManagement);
            Controls.Add(InstructorGridViewInstructorManagement);
            Controls.Add(labelMemberBooking);
            Controls.Add(label1);
            Controls.Add(buttonBooking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMemberOverviewTab";
            Text = "formMemberOverviewTab";
            ((System.ComponentModel.ISupportInitialize)InstructorGridViewInstructorManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView InstructorGridViewInstructorManagement;
        private Button buttonSearchInstructorManagement;
        private TextBox textBoxSearchBarInstructorManagement;
        private Label labelMemberBooking;
        private DataGridView dataGridView1;
        private Label label1;
        private Button buttonBooking;
    }
}