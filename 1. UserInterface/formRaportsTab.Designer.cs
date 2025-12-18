namespace FitHub._1._UserInterface
{
    partial class formRaportsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRaportsTab));
            labelClassTypeClassManagement = new Label();
            comboBoxSubjectPrint = new ComboBox();
            labelDateClassManagement = new Label();
            dateTimePickerStart = new DateTimePicker();
            label1 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            labelMemberInformationMemberManagement = new Label();
            buttonPrint = new Button();
            pictureBox1 = new PictureBox();
            labelHelp_Statistics = new Label();
            pictureBox_Statistics1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Statistics1).BeginInit();
            SuspendLayout();
            // 
            // labelClassTypeClassManagement
            // 
            labelClassTypeClassManagement.AutoSize = true;
            labelClassTypeClassManagement.Font = new Font("Nirmala UI", 15F, FontStyle.Bold);
            labelClassTypeClassManagement.ForeColor = Color.FromArgb(73, 125, 201);
            labelClassTypeClassManagement.Location = new Point(22, 140);
            labelClassTypeClassManagement.Margin = new Padding(4, 0, 4, 0);
            labelClassTypeClassManagement.Name = "labelClassTypeClassManagement";
            labelClassTypeClassManagement.Size = new Size(239, 35);
            labelClassTypeClassManagement.TabIndex = 65;
            labelClassTypeClassManagement.Text = "Choose the subject";
            // 
            // comboBoxSubjectPrint
            // 
            comboBoxSubjectPrint.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            comboBoxSubjectPrint.FormattingEnabled = true;
            comboBoxSubjectPrint.Items.AddRange(new object[] { "All Members", "Active Members", "Inactive Members", "Popular Classes (Sum)" });
            comboBoxSubjectPrint.Location = new Point(279, 149);
            comboBoxSubjectPrint.Margin = new Padding(4);
            comboBoxSubjectPrint.Name = "comboBoxSubjectPrint";
            comboBoxSubjectPrint.Size = new Size(202, 28);
            comboBoxSubjectPrint.TabIndex = 64;
            // 
            // labelDateClassManagement
            // 
            labelDateClassManagement.AutoSize = true;
            labelDateClassManagement.Font = new Font("Nirmala UI", 15F, FontStyle.Bold);
            labelDateClassManagement.ForeColor = Color.FromArgb(73, 125, 201);
            labelDateClassManagement.Location = new Point(23, 211);
            labelDateClassManagement.Margin = new Padding(4, 0, 4, 0);
            labelDateClassManagement.Name = "labelDateClassManagement";
            labelDateClassManagement.Size = new Size(72, 35);
            labelDateClassManagement.TabIndex = 67;
            labelDateClassManagement.Text = "Start";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarFont = new Font("Nirmala UI", 9F);
            dateTimePickerStart.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            dateTimePickerStart.Location = new Point(279, 218);
            dateTimePickerStart.Margin = new Padding(4);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(231, 27);
            dateTimePickerStart.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(73, 125, 201);
            label1.Location = new Point(23, 281);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 35);
            label1.TabIndex = 69;
            label1.Text = "End";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CalendarFont = new Font("Nirmala UI", 9F);
            dateTimePickerEnd.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            dateTimePickerEnd.Location = new Point(279, 287);
            dateTimePickerEnd.Margin = new Padding(4);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(231, 27);
            dateTimePickerEnd.TabIndex = 68;
            // 
            // labelMemberInformationMemberManagement
            // 
            labelMemberInformationMemberManagement.AutoSize = true;
            labelMemberInformationMemberManagement.Font = new Font("Nirmala UI", 25F, FontStyle.Bold);
            labelMemberInformationMemberManagement.ForeColor = Color.FromArgb(73, 125, 201);
            labelMemberInformationMemberManagement.Location = new Point(15, 11);
            labelMemberInformationMemberManagement.Name = "labelMemberInformationMemberManagement";
            labelMemberInformationMemberManagement.Size = new Size(361, 57);
            labelMemberInformationMemberManagement.TabIndex = 70;
            labelMemberInformationMemberManagement.Text = "Statistics to print";
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.FromArgb(31, 34, 56);
            buttonPrint.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonPrint.ForeColor = Color.FromArgb(73, 125, 201);
            buttonPrint.Image = (Image)resources.GetObject("buttonPrint.Image");
            buttonPrint.ImageAlign = ContentAlignment.TopRight;
            buttonPrint.Location = new Point(26, 666);
            buttonPrint.Margin = new Padding(4);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(375, 41);
            buttonPrint.TabIndex = 71;
            buttonPrint.Text = "Print";
            buttonPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(488, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 466);
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            // 
            // labelHelp_Statistics
            // 
            labelHelp_Statistics.AutoSize = true;
            labelHelp_Statistics.BackColor = Color.FromArgb(74, 79, 99);
            labelHelp_Statistics.BorderStyle = BorderStyle.FixedSingle;
            labelHelp_Statistics.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelHelp_Statistics.ForeColor = Color.FromArgb(73, 125, 201);
            labelHelp_Statistics.Location = new Point(488, 126);
            labelHelp_Statistics.Name = "labelHelp_Statistics";
            labelHelp_Statistics.Padding = new Padding(1);
            labelHelp_Statistics.Size = new Size(336, 19);
            labelHelp_Statistics.TabIndex = 74;
            labelHelp_Statistics.Text = "Choose between different statistic types you want to print";
            labelHelp_Statistics.Visible = false;
            // 
            // pictureBox_Statistics1
            // 
            pictureBox_Statistics1.BackgroundImage = (Image)resources.GetObject("pictureBox_Statistics1.BackgroundImage");
            pictureBox_Statistics1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_Statistics1.Location = new Point(488, 152);
            pictureBox_Statistics1.Name = "pictureBox_Statistics1";
            pictureBox_Statistics1.Size = new Size(20, 20);
            pictureBox_Statistics1.TabIndex = 73;
            pictureBox_Statistics1.TabStop = false;
            pictureBox_Statistics1.MouseEnter += pictureBox_Statistics1_MouseEnter;
            pictureBox_Statistics1.MouseLeave += pictureBox_Statistics1_MouseLeave;
            // 
            // formRaportsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 56);
            ClientSize = new Size(1225, 738);
            Controls.Add(labelHelp_Statistics);
            Controls.Add(pictureBox_Statistics1);
            Controls.Add(buttonPrint);
            Controls.Add(labelDateClassManagement);
            Controls.Add(dateTimePickerStart);
            Controls.Add(labelClassTypeClassManagement);
            Controls.Add(comboBoxSubjectPrint);
            Controls.Add(label1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(labelMemberInformationMemberManagement);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRaportsTab";
            Text = "formRaportsTab";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Statistics1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelClassTypeClassManagement;
        private ComboBox comboBoxSubjectPrint;
        private Label labelDateClassManagement;
        private DateTimePicker dateTimePickerStart;
        private Label label1;
        private DateTimePicker dateTimePickerEnd;
        private Label labelMemberInformationMemberManagement;
        private Button buttonPrint;
        private PictureBox pictureBox1;
        private Label labelHelp_Statistics;
        private PictureBox pictureBox_Statistics1;
    }
}