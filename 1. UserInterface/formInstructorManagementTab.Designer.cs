namespace FitHub._1._UserInterface
{
    partial class formInstructorManagementTab
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
            InstructorCert = new ComboBox();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            button9 = new Button();
            InstructorGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)InstructorGridView).BeginInit();
            SuspendLayout();
            // 
            // InstructorCert
            // 
            InstructorCert.DropDownStyle = ComboBoxStyle.DropDownList;
            InstructorCert.FormattingEnabled = true;
            InstructorCert.Items.AddRange(new object[] { "Trail Running", "Forrest Yoga" });
            InstructorCert.Location = new Point(11, 258);
            InstructorCert.Margin = new Padding(2);
            InstructorCert.Name = "InstructorCert";
            InstructorCert.Size = new Size(150, 28);
            InstructorCert.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 236);
            label12.Margin = new Padding(1, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(90, 20);
            label12.TabIndex = 41;
            label12.Text = "Certification";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 187);
            label14.Margin = new Padding(1, 0, 1, 0);
            label14.Name = "label14";
            label14.Size = new Size(26, 20);
            label14.TabIndex = 40;
            label14.Text = "Tlf";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 135);
            label15.Margin = new Padding(1, 0, 1, 0);
            label15.Name = "label15";
            label15.Size = new Size(46, 20);
            label15.TabIndex = 39;
            label15.Text = "Email";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(11, 90);
            label16.Margin = new Padding(1, 0, 1, 0);
            label16.Name = "label16";
            label16.Size = new Size(74, 20);
            label16.TabIndex = 38;
            label16.Text = "Sur Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 42);
            label17.Margin = new Padding(1, 0, 1, 0);
            label17.Name = "label17";
            label17.Size = new Size(80, 20);
            label17.TabIndex = 37;
            label17.Text = "First Name";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(11, 207);
            textBox7.Margin = new Padding(1);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 36;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(11, 157);
            textBox8.Margin = new Padding(1);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 35;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(11, 110);
            textBox9.Margin = new Padding(1);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 34;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(11, 65);
            textBox10.Margin = new Padding(1);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 33;
            // 
            // button9
            // 
            button9.Location = new Point(11, 302);
            button9.Margin = new Padding(1);
            button9.Name = "button9";
            button9.Size = new Size(92, 29);
            button9.TabIndex = 32;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            // 
            // InstructorGridView
            // 
            InstructorGridView.AccessibleRole = AccessibleRole.Cursor;
            InstructorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InstructorGridView.Location = new Point(238, 13);
            InstructorGridView.Margin = new Padding(4);
            InstructorGridView.Name = "InstructorGridView";
            InstructorGridView.RowHeadersWidth = 82;
            InstructorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InstructorGridView.Size = new Size(631, 489);
            InstructorGridView.TabIndex = 31;
            // 
            // formInstructorManagementTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 126, 150);
            ClientSize = new Size(911, 498);
            Controls.Add(InstructorCert);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(button9);
            Controls.Add(InstructorGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formInstructorManagementTab";
            Text = "formInstructorManagementTab";
            ((System.ComponentModel.ISupportInitialize)InstructorGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox InstructorCert;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button button9;
        private DataGridView InstructorGridView;
    }
}