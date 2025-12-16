namespace FitHub
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            MemberDeleteButton = new Button();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            BookingButton = new Button();
            label13 = new Label();
            BookingClassGrid = new DataGridView();
            BookingMemberGrid = new DataGridView();
            tabPage4 = new TabPage();
            label11 = new Label();
            InstructorIDComboBox = new ComboBox();
            button5 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            ClassLocationTextBox = new TextBox();
            ClassCapacityTextBox = new TextBox();
            ClassTimeComboBox = new ComboBox();
            ClassCalender = new DateTimePicker();
            ClassTypeComboBox = new ComboBox();
            ClassManGrid = new DataGridView();
            tabPage2 = new TabPage();
            label18 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            tabPage5 = new TabPage();
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
            button10 = new Button();
            InstructorGridView = new DataGridView();
            tabPage6 = new TabPage();
            GetMemberHistory = new Button();
            label20 = new Label();
            label21 = new Label();
            scopeMemberHistoryDataGrid = new DataGridView();
            SearchAllMembersDataGrid = new DataGridView();
            SeeMembersButton = new TabPage();
            SeeMembers1Button = new Button();
            button2 = new Button();
            Instructor = new Label();
            label19 = new Label();
            scopeClassHistoryView = new DataGridView();
            searchInstructorDataGridView = new DataGridView();
            tabPage1 = new TabPage();
            PrintReportButton = new Button();
            PrintToPicker = new DateTimePicker();
            PrintFromPicker = new DateTimePicker();
            PrintDropBoxLabel = new Label();
            PrintDropBox = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            saveFileDialog1 = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookingClassGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookingMemberGrid).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClassManGrid).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InstructorGridView).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scopeMemberHistoryDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchAllMembersDataGrid).BeginInit();
            SeeMembersButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scopeClassHistoryView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchInstructorDataGridView).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // MemberDeleteButton
            // 
            MemberDeleteButton.Location = new Point(291, 623);
            MemberDeleteButton.Margin = new Padding(1, 2, 1, 2);
            MemberDeleteButton.Name = "MemberDeleteButton";
            MemberDeleteButton.Size = new Size(181, 37);
            MemberDeleteButton.TabIndex = 0;
            MemberDeleteButton.Text = "Delete";
            MemberDeleteButton.UseVisualStyleBackColor = true;
            MemberDeleteButton.Click += button1_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(SeeMembersButton);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Margin = new Padding(1, 2, 1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2383, 900);
            tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BookingButton);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(BookingClassGrid);
            tabPage3.Controls.Add(BookingMemberGrid);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(1, 2, 1, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(2375, 862);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Booking";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BookingButton
            // 
            BookingButton.Location = new Point(339, 335);
            BookingButton.Margin = new Padding(4, 5, 4, 5);
            BookingButton.Name = "BookingButton";
            BookingButton.Size = new Size(139, 38);
            BookingButton.TabIndex = 7;
            BookingButton.Text = "Book member";
            BookingButton.UseVisualStyleBackColor = true;
            BookingButton.Click += BookingButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 25);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(87, 25);
            label13.TabIndex = 5;
            label13.Text = "Members";
            // 
            // BookingClassGrid
            // 
            BookingClassGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingClassGrid.Location = new Point(491, 3);
            BookingClassGrid.Margin = new Padding(4, 5, 4, 5);
            BookingClassGrid.Name = "BookingClassGrid";
            BookingClassGrid.RowHeadersWidth = 82;
            BookingClassGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingClassGrid.Size = new Size(2000, 800);
            BookingClassGrid.TabIndex = 3;
            // 
            // BookingMemberGrid
            // 
            BookingMemberGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingMemberGrid.Location = new Point(11, 75);
            BookingMemberGrid.Margin = new Padding(4, 5, 4, 5);
            BookingMemberGrid.Name = "BookingMemberGrid";
            BookingMemberGrid.RowHeadersWidth = 82;
            BookingMemberGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingMemberGrid.Size = new Size(319, 610);
            BookingMemberGrid.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(InstructorIDComboBox);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(ClassLocationTextBox);
            tabPage4.Controls.Add(ClassCapacityTextBox);
            tabPage4.Controls.Add(ClassTimeComboBox);
            tabPage4.Controls.Add(ClassCalender);
            tabPage4.Controls.Add(ClassTypeComboBox);
            tabPage4.Controls.Add(ClassManGrid);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Margin = new Padding(1, 2, 1, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(2375, 862);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Class Management";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 637);
            label11.Name = "label11";
            label11.Size = new Size(96, 25);
            label11.TabIndex = 14;
            label11.Text = "Instructors";
            // 
            // InstructorIDComboBox
            // 
            InstructorIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InstructorIDComboBox.FormattingEnabled = true;
            InstructorIDComboBox.Location = new Point(11, 663);
            InstructorIDComboBox.Margin = new Padding(3, 2, 3, 2);
            InstructorIDComboBox.Name = "InstructorIDComboBox";
            InstructorIDComboBox.Size = new Size(187, 33);
            InstructorIDComboBox.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(311, 602);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(126, 37);
            button5.TabIndex = 12;
            button5.Text = "Make team";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 50);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 25);
            label10.TabIndex = 10;
            label10.Text = "Class Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 163);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 25);
            label9.TabIndex = 9;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 277);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(50, 25);
            label8.TabIndex = 8;
            label8.Text = "Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 402);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 7;
            label7.Text = "Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 535);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 6;
            label6.Text = "Location";
            // 
            // ClassLocationTextBox
            // 
            ClassLocationTextBox.Location = new Point(11, 565);
            ClassLocationTextBox.Margin = new Padding(4, 5, 4, 5);
            ClassLocationTextBox.Name = "ClassLocationTextBox";
            ClassLocationTextBox.Size = new Size(171, 31);
            ClassLocationTextBox.TabIndex = 5;
            // 
            // ClassCapacityTextBox
            // 
            ClassCapacityTextBox.Location = new Point(11, 432);
            ClassCapacityTextBox.Margin = new Padding(4, 5, 4, 5);
            ClassCapacityTextBox.Name = "ClassCapacityTextBox";
            ClassCapacityTextBox.Size = new Size(171, 31);
            ClassCapacityTextBox.TabIndex = 4;
            // 
            // ClassTimeComboBox
            // 
            ClassTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassTimeComboBox.FormattingEnabled = true;
            ClassTimeComboBox.Items.AddRange(new object[] { "10.00", "10.30", "11.00", "11.30", "12.00", "12.30", "13.00", "13.30", "14.00", "14.30", "15.00", "15.30", "16.00", "16.30", "17.00", "17.30", "18.00", "18.30", "19.00", "19.30", "20.00", "20.30" });
            ClassTimeComboBox.Location = new Point(11, 307);
            ClassTimeComboBox.Margin = new Padding(4, 5, 4, 5);
            ClassTimeComboBox.Name = "ClassTimeComboBox";
            ClassTimeComboBox.Size = new Size(171, 33);
            ClassTimeComboBox.TabIndex = 3;
            // 
            // ClassCalender
            // 
            ClassCalender.Location = new Point(11, 193);
            ClassCalender.Margin = new Padding(4, 5, 4, 5);
            ClassCalender.Name = "ClassCalender";
            ClassCalender.Size = new Size(284, 31);
            ClassCalender.TabIndex = 2;
            // 
            // ClassTypeComboBox
            // 
            ClassTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassTypeComboBox.FormattingEnabled = true;
            ClassTypeComboBox.Items.AddRange(new object[] { "Trail running", "Forrest Yoga" });
            ClassTypeComboBox.Location = new Point(11, 80);
            ClassTypeComboBox.Margin = new Padding(4, 5, 4, 5);
            ClassTypeComboBox.Name = "ClassTypeComboBox";
            ClassTypeComboBox.Size = new Size(171, 33);
            ClassTypeComboBox.TabIndex = 1;
            // 
            // ClassManGrid
            // 
            ClassManGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassManGrid.Location = new Point(491, 3);
            ClassManGrid.Margin = new Padding(1, 2, 1, 2);
            ClassManGrid.Name = "ClassManGrid";
            ClassManGrid.RowHeadersWidth = 82;
            ClassManGrid.Size = new Size(2000, 800);
            ClassManGrid.TabIndex = 0;
            ClassManGrid.CellContentClick += ClassManGrid_CellContentClick;
            ClassManGrid.CellEndEdit += ClassManGrid_CellEndEdit;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(MemberDeleteButton);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(1, 2, 1, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(1, 2, 1, 2);
            tabPage2.Size = new Size(2375, 862);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Member Management";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(54, 275);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(83, 25);
            label18.TabIndex = 19;
            label18.Text = "Birthdate";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(50, 300);
            dateTimePicker2.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(284, 31);
            dateTimePicker2.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(291, 565);
            button3.Margin = new Padding(1, 2, 1, 2);
            button3.Name = "button3";
            button3.Size = new Size(181, 37);
            button3.TabIndex = 17;
            button3.Text = "Active On/Off";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(491, 3);
            dataGridView1.Margin = new Padding(1, 2, 1, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(2000, 800);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Basic", "Premium", "VIP" });
            comboBox1.Location = new Point(50, 370);
            comboBox1.Margin = new Padding(1, 2, 1, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 33);
            comboBox1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 343);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 15;
            label5.Text = "Member Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 210);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 25);
            label4.TabIndex = 14;
            label4.Text = "Tlf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 153);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 98);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 12;
            label2.Text = "Sur Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 38);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 11;
            label1.Text = "First Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(50, 235);
            textBox4.Margin = new Padding(1, 2, 1, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 31);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 182);
            textBox3.Margin = new Padding(1, 2, 1, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 123);
            textBox2.Margin = new Padding(1, 2, 1, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 67);
            textBox1.Margin = new Padding(1, 2, 1, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 31);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(50, 427);
            button1.Margin = new Padding(1, 2, 1, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 37);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(InstructorCert);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(label15);
            tabPage5.Controls.Add(label16);
            tabPage5.Controls.Add(label17);
            tabPage5.Controls.Add(textBox7);
            tabPage5.Controls.Add(textBox8);
            tabPage5.Controls.Add(textBox9);
            tabPage5.Controls.Add(textBox10);
            tabPage5.Controls.Add(button9);
            tabPage5.Controls.Add(button10);
            tabPage5.Controls.Add(InstructorGridView);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Margin = new Padding(1, 2, 1, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(2375, 862);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Instructor Management";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // InstructorCert
            // 
            InstructorCert.DropDownStyle = ComboBoxStyle.DropDownList;
            InstructorCert.FormattingEnabled = true;
            InstructorCert.Items.AddRange(new object[] { "Trail Running", "Forrest Yoga" });
            InstructorCert.Location = new Point(46, 312);
            InstructorCert.Margin = new Padding(3, 2, 3, 2);
            InstructorCert.Name = "InstructorCert";
            InstructorCert.Size = new Size(187, 33);
            InstructorCert.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 283);
            label12.Margin = new Padding(1, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(106, 25);
            label12.TabIndex = 29;
            label12.Text = "Certification";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(50, 222);
            label14.Margin = new Padding(1, 0, 1, 0);
            label14.Name = "label14";
            label14.Size = new Size(31, 25);
            label14.TabIndex = 28;
            label14.Text = "Tlf";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(46, 157);
            label15.Margin = new Padding(1, 0, 1, 0);
            label15.Name = "label15";
            label15.Size = new Size(54, 25);
            label15.TabIndex = 27;
            label15.Text = "Email";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(46, 102);
            label16.Margin = new Padding(1, 0, 1, 0);
            label16.Name = "label16";
            label16.Size = new Size(90, 25);
            label16.TabIndex = 26;
            label16.Text = "Sur Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(46, 42);
            label17.Margin = new Padding(1, 0, 1, 0);
            label17.Name = "label17";
            label17.Size = new Size(97, 25);
            label17.TabIndex = 25;
            label17.Text = "First Name";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(46, 247);
            textBox7.Margin = new Padding(1, 2, 1, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(155, 31);
            textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(46, 185);
            textBox8.Margin = new Padding(1, 2, 1, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(155, 31);
            textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(46, 127);
            textBox9.Margin = new Padding(1, 2, 1, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(155, 31);
            textBox9.TabIndex = 21;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(50, 67);
            textBox10.Margin = new Padding(1, 2, 1, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(155, 31);
            textBox10.TabIndex = 20;
            // 
            // button9
            // 
            button9.Location = new Point(46, 367);
            button9.Margin = new Padding(1, 2, 1, 2);
            button9.Name = "button9";
            button9.Size = new Size(114, 37);
            button9.TabIndex = 19;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(291, 623);
            button10.Margin = new Padding(1, 2, 1, 2);
            button10.Name = "button10";
            button10.Size = new Size(181, 37);
            button10.TabIndex = 18;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // InstructorGridView
            // 
            InstructorGridView.AccessibleRole = AccessibleRole.Cursor;
            InstructorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InstructorGridView.Location = new Point(491, 3);
            InstructorGridView.Margin = new Padding(4, 5, 4, 5);
            InstructorGridView.Name = "InstructorGridView";
            InstructorGridView.RowHeadersWidth = 82;
            InstructorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InstructorGridView.Size = new Size(2000, 800);
            InstructorGridView.TabIndex = 1;
            InstructorGridView.CellEndEdit += InstructorGridView_CellEndEdit;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(GetMemberHistory);
            tabPage6.Controls.Add(label20);
            tabPage6.Controls.Add(label21);
            tabPage6.Controls.Add(scopeMemberHistoryDataGrid);
            tabPage6.Controls.Add(SearchAllMembersDataGrid);
            tabPage6.Location = new Point(4, 34);
            tabPage6.Margin = new Padding(1, 2, 1, 2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(2375, 862);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Member Overview";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // GetMemberHistory
            // 
            GetMemberHistory.Location = new Point(640, 415);
            GetMemberHistory.Margin = new Padding(4, 5, 4, 5);
            GetMemberHistory.Name = "GetMemberHistory";
            GetMemberHistory.Size = new Size(120, 50);
            GetMemberHistory.TabIndex = 9;
            GetMemberHistory.Text = "Get History";
            GetMemberHistory.UseVisualStyleBackColor = true;
            GetMemberHistory.Click += GetMemberHistory_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(76, 73);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(87, 25);
            label20.TabIndex = 8;
            label20.Text = "Members";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(847, 73);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(141, 25);
            label21.TabIndex = 7;
            label21.Text = "Member History";
            // 
            // scopeMemberHistoryDataGrid
            // 
            scopeMemberHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scopeMemberHistoryDataGrid.Location = new Point(847, 103);
            scopeMemberHistoryDataGrid.Margin = new Padding(4, 5, 4, 5);
            scopeMemberHistoryDataGrid.Name = "scopeMemberHistoryDataGrid";
            scopeMemberHistoryDataGrid.RowHeadersWidth = 62;
            scopeMemberHistoryDataGrid.Size = new Size(2000, 587);
            scopeMemberHistoryDataGrid.TabIndex = 6;
            // 
            // SearchAllMembersDataGrid
            // 
            SearchAllMembersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchAllMembersDataGrid.Location = new Point(76, 103);
            SearchAllMembersDataGrid.Margin = new Padding(4, 5, 4, 5);
            SearchAllMembersDataGrid.Name = "SearchAllMembersDataGrid";
            SearchAllMembersDataGrid.RowHeadersWidth = 62;
            SearchAllMembersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchAllMembersDataGrid.Size = new Size(477, 587);
            SearchAllMembersDataGrid.TabIndex = 5;
            SearchAllMembersDataGrid.CellContentClick += SearchAllMembersDataGrid_CellContentClick;
            // 
            // SeeMembersButton
            // 
            SeeMembersButton.Controls.Add(SeeMembers1Button);
            SeeMembersButton.Controls.Add(button2);
            SeeMembersButton.Controls.Add(Instructor);
            SeeMembersButton.Controls.Add(label19);
            SeeMembersButton.Controls.Add(scopeClassHistoryView);
            SeeMembersButton.Controls.Add(searchInstructorDataGridView);
            SeeMembersButton.Location = new Point(4, 34);
            SeeMembersButton.Name = "SeeMembersButton";
            SeeMembersButton.Size = new Size(2375, 862);
            SeeMembersButton.TabIndex = 6;
            SeeMembersButton.Text = "Class Overview";
            SeeMembersButton.UseVisualStyleBackColor = true;
            // 
            // SeeMembers1Button
            // 
            SeeMembers1Button.Location = new Point(467, 388);
            SeeMembers1Button.Name = "SeeMembers1Button";
            SeeMembers1Button.Size = new Size(91, 30);
            SeeMembers1Button.TabIndex = 5;
            SeeMembers1Button.Text = "See Members";
            SeeMembers1Button.UseVisualStyleBackColor = true;
            SeeMembers1Button.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(364, 388);
            button2.Name = "button2";
            button2.Size = new Size(120, 50);
            button2.TabIndex = 4;
            button2.Text = "Get History";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Instructor
            // 
            Instructor.AutoSize = true;
            Instructor.Location = new Point(34, 80);
            Instructor.Margin = new Padding(4, 0, 4, 0);
            Instructor.Name = "Instructor";
            Instructor.Size = new Size(88, 25);
            Instructor.TabIndex = 3;
            Instructor.Text = "Instructor";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(806, 80);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(69, 25);
            label19.TabIndex = 2;
            label19.Text = "Classes";
            // 
            // scopeClassHistoryView
            // 
            scopeClassHistoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scopeClassHistoryView.Location = new Point(806, 110);
            scopeClassHistoryView.Margin = new Padding(4, 5, 4, 5);
            scopeClassHistoryView.Name = "scopeClassHistoryView";
            scopeClassHistoryView.RowHeadersWidth = 62;
            scopeClassHistoryView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            scopeClassHistoryView.Size = new Size(427, 352);
            scopeClassHistoryView.TabIndex = 1;
            // 
            // searchInstructorDataGridView
            // 
            searchInstructorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchInstructorDataGridView.Location = new Point(34, 110);
            searchInstructorDataGridView.Margin = new Padding(4, 5, 4, 5);
            searchInstructorDataGridView.Name = "searchInstructorDataGridView";
            searchInstructorDataGridView.RowHeadersWidth = 62;
            searchInstructorDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchInstructorDataGridView.Size = new Size(477, 587);
            searchInstructorDataGridView.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(PrintReportButton);
            tabPage1.Controls.Add(PrintToPicker);
            tabPage1.Controls.Add(PrintFromPicker);
            tabPage1.Controls.Add(PrintDropBoxLabel);
            tabPage1.Controls.Add(PrintDropBox);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(2375, 862);
            tabPage1.TabIndex = 7;
            tabPage1.Text = "Reports";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // PrintReportButton
            // 
            PrintReportButton.Location = new Point(789, 535);
            PrintReportButton.Name = "PrintReportButton";
            PrintReportButton.Size = new Size(165, 34);
            PrintReportButton.TabIndex = 4;
            PrintReportButton.Text = "Print Report";
            PrintReportButton.UseVisualStyleBackColor = true;
            PrintReportButton.Click += PrintReportButton_Click;
            // 
            // PrintToPicker
            // 
            PrintToPicker.Location = new Point(654, 352);
            PrintToPicker.Name = "PrintToPicker";
            PrintToPicker.Size = new Size(300, 31);
            PrintToPicker.TabIndex = 3;
            // 
            // PrintFromPicker
            // 
            PrintFromPicker.Location = new Point(654, 212);
            PrintFromPicker.Name = "PrintFromPicker";
            PrintFromPicker.Size = new Size(300, 31);
            PrintFromPicker.TabIndex = 2;
            // 
            // PrintDropBoxLabel
            // 
            PrintDropBoxLabel.AutoSize = true;
            PrintDropBoxLabel.Location = new Point(126, 170);
            PrintDropBoxLabel.Name = "PrintDropBoxLabel";
            PrintDropBoxLabel.Size = new Size(197, 25);
            PrintDropBoxLabel.TabIndex = 1;
            PrintDropBoxLabel.Text = "Choose subject to print";
            // 
            // PrintDropBox
            // 
            PrintDropBox.FormattingEnabled = true;
            PrintDropBox.Items.AddRange(new object[] { "All Members", "Active Members", "Inactive Members", "Popular Classes (Sum)" });
            PrintDropBox.Location = new Point(126, 210);
            PrintDropBox.Name = "PrintDropBox";
            PrintDropBox.Size = new Size(387, 33);
            PrintDropBox.TabIndex = 0;
            PrintDropBox.SelectedIndexChanged += PrintDropBox_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2388, 925);
            Controls.Add(tabControl1);
            Margin = new Padding(1, 2, 1, 2);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookingClassGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookingMemberGrid).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClassManGrid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InstructorGridView).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scopeMemberHistoryDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchAllMembersDataGrid).EndInit();
            SeeMembersButton.ResumeLayout(false);
            SeeMembersButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scopeClassHistoryView).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchInstructorDataGridView).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button MemberDeleteButton;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView ClassManGrid;
        private Button button1;
        private TextBox ClassLocationTextBox;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
        private Button button3;
        private TextBox ClassCapacityTextBox;
        private ComboBox ClassTimeComboBox;
        private DateTimePicker ClassCalender;
        private ComboBox ClassTypeComboBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button5;
        private Label label13;
        private DataGridView BookingClassGrid;
        private DataGridView BookingMemberGrid;
        private Button BookingButton;
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
        private Button button10;
        private DataGridView InstructorGridView;
        private Label label18;
        private DateTimePicker dateTimePicker2;
        private ComboBox InstructorCert;
        private Label label11;
        private ComboBox InstructorIDComboBox;
        private TabPage SeeMembersButton;
        private Button button2;
        private Label Instructor;
        private Label label19;
        private DataGridView scopeClassHistoryView;
        private DataGridView searchInstructorDataGridView;
        private Button GetMemberHistory;
        private Label label20;
        private Label label21;
        private DataGridView scopeMemberHistoryDataGrid;
        private DataGridView SearchAllMembersDataGrid;
        private TabPage tabPage1;
        private Button SeeMembers1Button;
        private ComboBox PrintDropBox;
        private DateTimePicker PrintToPicker;
        private DateTimePicker PrintFromPicker;
        private Label PrintDropBoxLabel;
        private Button PrintReportButton;
        private SaveFileDialog saveFileDialog1;
    }
}
