namespace FitHub._1._UserInterface
{
    partial class formClassInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formClassInformation));
            dataGridViewClassInformation = new DataGridView();
            labelClassOverviewBooking = new Label();
            pictureBox1 = new PictureBox();
            buttonCloseDown = new Button();
            panel1 = new Panel();
            labelHelpClassinformation = new Label();
            pictureBoxHelp_ClassInformation = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassInformation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassInformation).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClassInformation
            // 
            dataGridViewClassInformation.BackgroundColor = SystemColors.Window;
            dataGridViewClassInformation.BorderStyle = BorderStyle.None;
            dataGridViewClassInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClassInformation.Location = new Point(22, 81);
            dataGridViewClassInformation.Margin = new Padding(4);
            dataGridViewClassInformation.Name = "dataGridViewClassInformation";
            dataGridViewClassInformation.RowHeadersWidth = 82;
            dataGridViewClassInformation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClassInformation.Size = new Size(354, 390);
            dataGridViewClassInformation.TabIndex = 10;
            // 
            // labelClassOverviewBooking
            // 
            labelClassOverviewBooking.AutoSize = true;
            labelClassOverviewBooking.BackColor = Color.FromArgb(31, 34, 56);
            labelClassOverviewBooking.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            labelClassOverviewBooking.ForeColor = Color.FromArgb(73, 125, 201);
            labelClassOverviewBooking.Location = new Point(19, 30);
            labelClassOverviewBooking.Name = "labelClassOverviewBooking";
            labelClassOverviewBooking.Size = new Size(259, 28);
            labelClassOverviewBooking.TabIndex = 68;
            labelClassOverviewBooking.Text = "Members on specific class";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(31, 34, 56);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(467, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 330);
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // buttonCloseDown
            // 
            buttonCloseDown.FlatAppearance.BorderColor = Color.FromArgb(31, 34, 56);
            buttonCloseDown.FlatStyle = FlatStyle.Flat;
            buttonCloseDown.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCloseDown.ForeColor = SystemColors.ButtonHighlight;
            buttonCloseDown.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCloseDown.Location = new Point(975, 10);
            buttonCloseDown.Name = "buttonCloseDown";
            buttonCloseDown.Size = new Size(34, 35);
            buttonCloseDown.TabIndex = 71;
            buttonCloseDown.Text = "X";
            buttonCloseDown.UseVisualStyleBackColor = true;
            buttonCloseDown.Click += buttonCloseDown_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 34, 56);
            panel1.Controls.Add(labelHelpClassinformation);
            panel1.Controls.Add(pictureBoxHelp_ClassInformation);
            panel1.Controls.Add(dataGridViewClassInformation);
            panel1.Controls.Add(labelClassOverviewBooking);
            panel1.Location = new Point(58, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 498);
            panel1.TabIndex = 72;
            // 
            // labelHelpClassinformation
            // 
            labelHelpClassinformation.AutoSize = true;
            labelHelpClassinformation.BackColor = Color.FromArgb(74, 79, 99);
            labelHelpClassinformation.BorderStyle = BorderStyle.FixedSingle;
            labelHelpClassinformation.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            labelHelpClassinformation.ForeColor = Color.FromArgb(73, 125, 201);
            labelHelpClassinformation.Location = new Point(276, 9);
            labelHelpClassinformation.Name = "labelHelpClassinformation";
            labelHelpClassinformation.Padding = new Padding(1);
            labelHelpClassinformation.Size = new Size(307, 19);
            labelHelpClassinformation.TabIndex = 70;
            labelHelpClassinformation.Text = "A list of all the members assigned to this specific class";
            labelHelpClassinformation.Visible = false;
            // 
            // pictureBoxHelp_ClassInformation
            // 
            pictureBoxHelp_ClassInformation.BackgroundImage = (Image)resources.GetObject("pictureBoxHelp_ClassInformation.BackgroundImage");
            pictureBoxHelp_ClassInformation.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHelp_ClassInformation.Location = new Point(276, 37);
            pictureBoxHelp_ClassInformation.Name = "pictureBoxHelp_ClassInformation";
            pictureBoxHelp_ClassInformation.Size = new Size(20, 20);
            pictureBoxHelp_ClassInformation.TabIndex = 69;
            pictureBoxHelp_ClassInformation.TabStop = false;
            pictureBoxHelp_ClassInformation.MouseEnter += pictureBoxHelp_ClassInformation_MouseEnter;
            pictureBoxHelp_ClassInformation.MouseLeave += pictureBoxHelp_ClassInformation_MouseLeave;
            // 
            // formClassInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 84);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1018, 597);
            Controls.Add(buttonCloseDown);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formClassInformation";
            Text = "formClassInformation";
            MouseDown += formClassInformation_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassInformation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp_ClassInformation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClassInformation;
        private Label labelClassOverviewBooking;
        private PictureBox pictureBox1;
        private Button buttonCloseDown;
        private Panel panel1;
        private Label labelHelpClassinformation;
        private PictureBox pictureBoxHelp_ClassInformation;
    }
}