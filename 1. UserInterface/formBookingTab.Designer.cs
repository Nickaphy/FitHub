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
            textBoxSearchBar = new TextBox();
            buttonSearchBooking = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassOverviewBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMemberBooking).BeginInit();
            SuspendLayout();
            // 
            // buttonBooking
            // 
            buttonBooking.BackColor = Color.FromArgb(31, 34, 56);
            buttonBooking.FlatStyle = FlatStyle.Flat;
            buttonBooking.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonBooking.ForeColor = Color.FromArgb(73, 125, 201);
            buttonBooking.Location = new Point(273, 260);
            buttonBooking.Margin = new Padding(4);
            buttonBooking.Name = "buttonBooking";
            buttonBooking.Size = new Size(111, 31);
            buttonBooking.TabIndex = 10;
            buttonBooking.Text = "Book member";
            buttonBooking.UseVisualStyleBackColor = false;
            // 
            // dataGridViewClassOverviewBooking
            // 
            dataGridViewClassOverviewBooking.BackgroundColor = SystemColors.Window;
            dataGridViewClassOverviewBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClassOverviewBooking.Location = new Point(404, 144);
            dataGridViewClassOverviewBooking.Margin = new Padding(4);
            dataGridViewClassOverviewBooking.Name = "dataGridViewClassOverviewBooking";
            dataGridViewClassOverviewBooking.RowHeadersWidth = 82;
            dataGridViewClassOverviewBooking.Size = new Size(479, 328);
            dataGridViewClassOverviewBooking.TabIndex = 9;
            // 
            // dataGridViewMemberBooking
            // 
            dataGridViewMemberBooking.BackgroundColor = SystemColors.Window;
            dataGridViewMemberBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMemberBooking.Location = new Point(24, 144);
            dataGridViewMemberBooking.Margin = new Padding(4);
            dataGridViewMemberBooking.Name = "dataGridViewMemberBooking";
            dataGridViewMemberBooking.RowHeadersWidth = 82;
            dataGridViewMemberBooking.Size = new Size(231, 328);
            dataGridViewMemberBooking.TabIndex = 8;
            // 
            // labelMemberBooking
            // 
            labelMemberBooking.AutoSize = true;
            labelMemberBooking.Font = new Font("Nirmala UI", 15F, FontStyle.Bold);
            labelMemberBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelMemberBooking.Location = new Point(24, 84);
            labelMemberBooking.Name = "labelMemberBooking";
            labelMemberBooking.Size = new Size(116, 35);
            labelMemberBooking.TabIndex = 11;
            labelMemberBooking.Text = "Member";
            // 
            // labelClassOverviewBooking
            // 
            labelClassOverviewBooking.AutoSize = true;
            labelClassOverviewBooking.Font = new Font("Nirmala UI", 15F, FontStyle.Bold);
            labelClassOverviewBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelClassOverviewBooking.Location = new Point(404, 84);
            labelClassOverviewBooking.Name = "labelClassOverviewBooking";
            labelClassOverviewBooking.Size = new Size(193, 35);
            labelClassOverviewBooking.TabIndex = 12;
            labelClassOverviewBooking.Text = "Class Overview";
            // 
            // textBoxSearchBar
            // 
            textBoxSearchBar.BackColor = Color.FromArgb(74, 79, 99);
            textBoxSearchBar.BorderStyle = BorderStyle.None;
            textBoxSearchBar.ForeColor = Color.FromArgb(73, 125, 201);
            textBoxSearchBar.Location = new Point(678, 24);
            textBoxSearchBar.Name = "textBoxSearchBar";
            textBoxSearchBar.Size = new Size(205, 20);
            textBoxSearchBar.TabIndex = 13;
            textBoxSearchBar.Text = "Search for...";
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
            buttonSearchBooking.Location = new Point(631, 17);
            buttonSearchBooking.Name = "buttonSearchBooking";
            buttonSearchBooking.Size = new Size(36, 35);
            buttonSearchBooking.TabIndex = 14;
            buttonSearchBooking.UseVisualStyleBackColor = true;
            // 
            // formBookingTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 56);
            ClientSize = new Size(911, 498);
            Controls.Add(buttonSearchBooking);
            Controls.Add(textBoxSearchBar);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBooking;
        private DataGridView dataGridViewClassOverviewBooking;
        private DataGridView dataGridViewMemberBooking;
        private Label labelMemberBooking;
        private Label labelClassOverviewBooking;
        private TextBox textBoxSearchBar;
        private Button buttonSearchBooking;
    }
}