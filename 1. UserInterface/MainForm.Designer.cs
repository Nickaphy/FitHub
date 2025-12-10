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
            tabPage7 = new TabPage();
            button2 = new Button();
            Classes = new Label();
            label19 = new Label();
            scopeClassesHistoryGridView = new DataGridView();
            searchClassesDataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
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
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scopeClassesHistoryGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchClassesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MemberDeleteButton
            // 
            MemberDeleteButton.Location = new Point(204, 374);
            MemberDeleteButton.Margin = new Padding(1);
            MemberDeleteButton.Name = "MemberDeleteButton";
            MemberDeleteButton.Size = new Size(127, 22);
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
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Margin = new Padding(1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1121, 485);
            tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BookingButton);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(BookingClassGrid);
            tabPage3.Controls.Add(BookingMemberGrid);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(1);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1113, 457);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Booking";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BookingButton
            // 
            BookingButton.Location = new Point(237, 201);
            BookingButton.Name = "BookingButton";
            BookingButton.Size = new Size(97, 23);
            BookingButton.TabIndex = 7;
            BookingButton.Text = "Book member";
            BookingButton.UseVisualStyleBackColor = true;
            BookingButton.Click += BookingButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 15);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 5;
            label13.Text = "Members";
            // 
            // BookingClassGrid
            // 
            BookingClassGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingClassGrid.Location = new Point(340, 3);
            BookingClassGrid.Name = "BookingClassGrid";
            BookingClassGrid.RowHeadersWidth = 82;
            BookingClassGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingClassGrid.Size = new Size(711, 408);
            BookingClassGrid.TabIndex = 3;
            // 
            // BookingMemberGrid
            // 
            BookingMemberGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingMemberGrid.Location = new Point(8, 45);
            BookingMemberGrid.Name = "BookingMemberGrid";
            BookingMemberGrid.RowHeadersWidth = 82;
            BookingMemberGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingMemberGrid.Size = new Size(223, 366);
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
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(1);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1113, 457);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Class Management";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 382);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 14;
            label11.Text = "Instructors";
            // 
            // InstructorIDComboBox
            // 
            InstructorIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InstructorIDComboBox.FormattingEnabled = true;
            InstructorIDComboBox.Location = new Point(8, 398);
            InstructorIDComboBox.Margin = new Padding(2, 1, 2, 1);
            InstructorIDComboBox.Name = "InstructorIDComboBox";
            InstructorIDComboBox.Size = new Size(132, 23);
            InstructorIDComboBox.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(218, 361);
            button5.Name = "button5";
            button5.Size = new Size(88, 22);
            button5.TabIndex = 12;
            button5.Text = "Make team";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 30);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 10;
            label10.Text = "Class Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 98);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 9;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 166);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 8;
            label8.Text = "Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 241);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 7;
            label7.Text = "Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 321);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 6;
            label6.Text = "Location";
            // 
            // ClassLocationTextBox
            // 
            ClassLocationTextBox.Location = new Point(8, 339);
            ClassLocationTextBox.Name = "ClassLocationTextBox";
            ClassLocationTextBox.Size = new Size(121, 23);
            ClassLocationTextBox.TabIndex = 5;
            // 
            // ClassCapacityTextBox
            // 
            ClassCapacityTextBox.Location = new Point(8, 259);
            ClassCapacityTextBox.Name = "ClassCapacityTextBox";
            ClassCapacityTextBox.Size = new Size(121, 23);
            ClassCapacityTextBox.TabIndex = 4;
            // 
            // ClassTimeComboBox
            // 
            ClassTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassTimeComboBox.FormattingEnabled = true;
            ClassTimeComboBox.Items.AddRange(new object[] { "10.00", "10.30", "11.00", "11.30", "12.00", "12.30", "13.00", "13.30", "14.00", "14.30", "15.00", "15.30", "16.00", "16.30", "17.00", "17.30", "18.00", "18.30", "19.00", "19.30", "20.00", "20.30" });
            ClassTimeComboBox.Location = new Point(8, 184);
            ClassTimeComboBox.Name = "ClassTimeComboBox";
            ClassTimeComboBox.Size = new Size(121, 23);
            ClassTimeComboBox.TabIndex = 3;
            // 
            // ClassCalender
            // 
            ClassCalender.Location = new Point(8, 116);
            ClassCalender.Name = "ClassCalender";
            ClassCalender.Size = new Size(200, 23);
            ClassCalender.TabIndex = 2;
            // 
            // ClassTypeComboBox
            // 
            ClassTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassTypeComboBox.FormattingEnabled = true;
            ClassTypeComboBox.Items.AddRange(new object[] { "Trail running", "Forrest Yoga" });
            ClassTypeComboBox.Location = new Point(8, 48);
            ClassTypeComboBox.Name = "ClassTypeComboBox";
            ClassTypeComboBox.Size = new Size(121, 23);
            ClassTypeComboBox.TabIndex = 1;
            // 
            // ClassManGrid
            // 
            ClassManGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassManGrid.Location = new Point(556, 0);
            ClassManGrid.Margin = new Padding(1);
            ClassManGrid.Name = "ClassManGrid";
            ClassManGrid.RowHeadersWidth = 82;
            ClassManGrid.Size = new Size(559, 464);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(1);
            tabPage2.Size = new Size(1113, 457);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Member Management";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(38, 165);
            label18.Name = "label18";
            label18.Size = new Size(55, 15);
            label18.TabIndex = 19;
            label18.Text = "Birthdate";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(35, 180);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(204, 339);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(127, 22);
            button3.TabIndex = 17;
            button3.Text = "Active On/Off";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 2);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(769, 406);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Basic", "Premium", "VIP" });
            comboBox1.Location = new Point(35, 222);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 206);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 15;
            label5.Text = "Member Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 126);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 14;
            label4.Text = "Tlf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 92);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 59);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 12;
            label2.Text = "Sur Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 23);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 11;
            label1.Text = "First Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(35, 141);
            textBox4.Margin = new Padding(1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(35, 109);
            textBox3.Margin = new Padding(1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 74);
            textBox2.Margin = new Padding(1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 40);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(35, 256);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(80, 22);
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
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(1);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1113, 457);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Instructor Management";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // InstructorCert
            // 
            InstructorCert.DropDownStyle = ComboBoxStyle.DropDownList;
            InstructorCert.FormattingEnabled = true;
            InstructorCert.Items.AddRange(new object[] { "Trail Running", "Forrest Yoga" });
            InstructorCert.Location = new Point(32, 187);
            InstructorCert.Margin = new Padding(2, 1, 2, 1);
            InstructorCert.Name = "InstructorCert";
            InstructorCert.Size = new Size(132, 23);
            InstructorCert.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 170);
            label12.Margin = new Padding(1, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 29;
            label12.Text = "Certification";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(35, 133);
            label14.Margin = new Padding(1, 0, 1, 0);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 28;
            label14.Text = "Tlf";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(32, 94);
            label15.Margin = new Padding(1, 0, 1, 0);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 27;
            label15.Text = "Email";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(32, 61);
            label16.Margin = new Padding(1, 0, 1, 0);
            label16.Name = "label16";
            label16.Size = new Size(59, 15);
            label16.TabIndex = 26;
            label16.Text = "Sur Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(32, 25);
            label17.Margin = new Padding(1, 0, 1, 0);
            label17.Name = "label17";
            label17.Size = new Size(64, 15);
            label17.TabIndex = 25;
            label17.Text = "First Name";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(32, 148);
            textBox7.Margin = new Padding(1);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(110, 23);
            textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(32, 111);
            textBox8.Margin = new Padding(1);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(110, 23);
            textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(32, 76);
            textBox9.Margin = new Padding(1);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(110, 23);
            textBox9.TabIndex = 21;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(32, 42);
            textBox10.Margin = new Padding(1);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(110, 23);
            textBox10.TabIndex = 20;
            // 
            // button9
            // 
            button9.Location = new Point(32, 220);
            button9.Margin = new Padding(1);
            button9.Name = "button9";
            button9.Size = new Size(80, 22);
            button9.TabIndex = 19;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(298, 330);
            button10.Margin = new Padding(1);
            button10.Name = "button10";
            button10.Size = new Size(127, 22);
            button10.TabIndex = 18;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // InstructorGridView
            // 
            InstructorGridView.AccessibleRole = AccessibleRole.Cursor;
            InstructorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InstructorGridView.Location = new Point(452, 3);
            InstructorGridView.Name = "InstructorGridView";
            InstructorGridView.RowHeadersWidth = 82;
            InstructorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InstructorGridView.Size = new Size(658, 454);
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
            tabPage6.Location = new Point(4, 24);
            tabPage6.Margin = new Padding(1);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1113, 457);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Member Overview";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // GetMemberHistory
            // 
            GetMemberHistory.Location = new Point(448, 249);
            GetMemberHistory.Name = "GetMemberHistory";
            GetMemberHistory.Size = new Size(84, 30);
            GetMemberHistory.TabIndex = 9;
            GetMemberHistory.Text = "Get History";
            GetMemberHistory.UseVisualStyleBackColor = true;
            GetMemberHistory.Click += GetMemberHistory_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(53, 44);
            label20.Name = "label20";
            label20.Size = new Size(57, 15);
            label20.TabIndex = 8;
            label20.Text = "Members";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(593, 44);
            label21.Name = "label21";
            label21.Size = new Size(93, 15);
            label21.TabIndex = 7;
            label21.Text = "Member History";
            // 
            // scopeMemberHistoryDataGrid
            // 
            scopeMemberHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scopeMemberHistoryDataGrid.Location = new Point(593, 62);
            scopeMemberHistoryDataGrid.Name = "scopeMemberHistoryDataGrid";
            scopeMemberHistoryDataGrid.Size = new Size(427, 352);
            scopeMemberHistoryDataGrid.TabIndex = 6;
            // 
            // SearchAllMembersDataGrid
            // 
            SearchAllMembersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchAllMembersDataGrid.Location = new Point(53, 62);
            SearchAllMembersDataGrid.Name = "SearchAllMembersDataGrid";
            SearchAllMembersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchAllMembersDataGrid.Size = new Size(334, 352);
            SearchAllMembersDataGrid.TabIndex = 5;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(button2);
            tabPage7.Controls.Add(Classes);
            tabPage7.Controls.Add(label19);
            tabPage7.Controls.Add(scopeClassesHistoryGridView);
            tabPage7.Controls.Add(searchClassesDataGridView);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1113, 457);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Class Overview";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(419, 253);
            button2.Name = "button2";
            button2.Size = new Size(84, 30);
            button2.TabIndex = 4;
            button2.Text = "Get History";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Classes
            // 
            Classes.AutoSize = true;
            Classes.Location = new Point(24, 48);
            Classes.Name = "Classes";
            Classes.Size = new Size(45, 15);
            Classes.TabIndex = 3;
            Classes.Text = "Classes";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(564, 48);
            label19.Name = "label19";
            label19.Size = new Size(75, 15);
            label19.TabIndex = 2;
            label19.Text = "Class History";
            // 
            // scopeClassesHistoryGridView
            // 
            scopeClassesHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scopeClassesHistoryGridView.Location = new Point(564, 66);
            scopeClassesHistoryGridView.Name = "scopeClassesHistoryGridView";
            scopeClassesHistoryGridView.Size = new Size(427, 352);
            scopeClassesHistoryGridView.TabIndex = 1;
            // 
            // searchClassesDataGridView
            // 
            searchClassesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchClassesDataGridView.Location = new Point(24, 66);
            searchClassesDataGridView.Name = "searchClassesDataGridView";
            searchClassesDataGridView.Size = new Size(334, 352);
            searchClassesDataGridView.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 497);
            Controls.Add(tabControl1);
            Margin = new Padding(1);
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
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scopeClassesHistoryGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchClassesDataGridView).EndInit();
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
        private TabPage tabPage7;
        private Button button2;
        private Label Classes;
        private Label label19;
        private DataGridView scopeClassesHistoryGridView;
        private DataGridView searchClassesDataGridView;
        private Button GetMemberHistory;
        private Label label20;
        private Label label21;
        private DataGridView scopeMemberHistoryDataGrid;
        private DataGridView SearchAllMembersDataGrid;
    }
}
