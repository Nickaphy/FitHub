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
            tabPage1 = new TabPage();
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
            SuspendLayout();
            // 
            // MemberDeleteButton
            // 
            MemberDeleteButton.Location = new Point(379, 798);
            MemberDeleteButton.Margin = new Padding(2);
            MemberDeleteButton.Name = "MemberDeleteButton";
            MemberDeleteButton.Size = new Size(236, 47);
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
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2082, 1035);
            tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BookingButton);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(BookingClassGrid);
            tabPage3.Controls.Add(BookingMemberGrid);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(2066, 981);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Booking";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BookingButton
            // 
            BookingButton.Location = new Point(440, 429);
            BookingButton.Margin = new Padding(6);
            BookingButton.Name = "BookingButton";
            BookingButton.Size = new Size(180, 49);
            BookingButton.TabIndex = 7;
            BookingButton.Text = "Book member";
            BookingButton.UseVisualStyleBackColor = true;
            BookingButton.Click += BookingButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 32);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(115, 32);
            label13.TabIndex = 5;
            label13.Text = "Members";
            // 
            // BookingClassGrid
            // 
            BookingClassGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingClassGrid.Location = new Point(631, 6);
            BookingClassGrid.Margin = new Padding(6);
            BookingClassGrid.Name = "BookingClassGrid";
            BookingClassGrid.RowHeadersWidth = 82;
            BookingClassGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingClassGrid.Size = new Size(1320, 870);
            BookingClassGrid.TabIndex = 3;
            // 
            // BookingMemberGrid
            // 
            BookingMemberGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingMemberGrid.Location = new Point(15, 96);
            BookingMemberGrid.Margin = new Padding(6);
            BookingMemberGrid.Name = "BookingMemberGrid";
            BookingMemberGrid.RowHeadersWidth = 82;
            BookingMemberGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingMemberGrid.Size = new Size(414, 781);
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
            tabPage4.Location = new Point(8, 46);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(2066, 981);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Class Management";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 815);
            label11.Name = "label11";
            label11.Size = new Size(125, 32);
            label11.TabIndex = 14;
            label11.Text = "Instructors";
            // 
            // InstructorIDComboBox
            // 
            InstructorIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InstructorIDComboBox.FormattingEnabled = true;
            InstructorIDComboBox.Location = new Point(15, 850);
            InstructorIDComboBox.Name = "InstructorIDComboBox";
            InstructorIDComboBox.Size = new Size(242, 40);
            InstructorIDComboBox.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(405, 770);
            button5.Margin = new Padding(6);
            button5.Name = "button5";
            button5.Size = new Size(163, 47);
            button5.TabIndex = 12;
            button5.Text = "Make team";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 64);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(125, 32);
            label10.TabIndex = 10;
            label10.Text = "Class Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 209);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 32);
            label9.TabIndex = 9;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 354);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 32);
            label8.TabIndex = 8;
            label8.Text = "Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 514);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 32);
            label7.TabIndex = 7;
            label7.Text = "Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 685);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 32);
            label6.TabIndex = 6;
            label6.Text = "Location";
            // 
            // ClassLocationTextBox
            // 
            ClassLocationTextBox.Location = new Point(15, 723);
            ClassLocationTextBox.Margin = new Padding(6);
            ClassLocationTextBox.Name = "ClassLocationTextBox";
            ClassLocationTextBox.Size = new Size(221, 39);
            ClassLocationTextBox.TabIndex = 5;
            // 
            // ClassCapacityTextBox
            // 
            ClassCapacityTextBox.Location = new Point(15, 553);
            ClassCapacityTextBox.Margin = new Padding(6);
            ClassCapacityTextBox.Name = "ClassCapacityTextBox";
            ClassCapacityTextBox.Size = new Size(221, 39);
            ClassCapacityTextBox.TabIndex = 4;
            // 
            // ClassTimeComboBox
            // 
            ClassTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassTimeComboBox.FormattingEnabled = true;
            ClassTimeComboBox.Items.AddRange(new object[] { "10.00", "10.30", "11.00", "11.30", "12.00", "12.30", "13.00", "13.30", "14.00", "14.30", "15.00", "15.30", "16.00", "16.30", "17.00", "17.30", "18.00", "18.30", "19.00", "19.30", "20.00", "20.30" });
            ClassTimeComboBox.Location = new Point(15, 393);
            ClassTimeComboBox.Margin = new Padding(6);
            ClassTimeComboBox.Name = "ClassTimeComboBox";
            ClassTimeComboBox.Size = new Size(221, 40);
            ClassTimeComboBox.TabIndex = 3;
            // 
            // ClassCalender
            // 
            ClassCalender.Location = new Point(15, 247);
            ClassCalender.Margin = new Padding(6);
            ClassCalender.Name = "ClassCalender";
            ClassCalender.Size = new Size(368, 39);
            ClassCalender.TabIndex = 2;
            // 
            // ClassTypeComboBox
            // 
            ClassTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassTypeComboBox.FormattingEnabled = true;
            ClassTypeComboBox.Items.AddRange(new object[] { "Trail running", "Forrest Yoga" });
            ClassTypeComboBox.Location = new Point(15, 102);
            ClassTypeComboBox.Margin = new Padding(6);
            ClassTypeComboBox.Name = "ClassTypeComboBox";
            ClassTypeComboBox.Size = new Size(221, 40);
            ClassTypeComboBox.TabIndex = 1;
            // 
            // ClassManGrid
            // 
            ClassManGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassManGrid.Location = new Point(1033, 0);
            ClassManGrid.Margin = new Padding(2);
            ClassManGrid.Name = "ClassManGrid";
            ClassManGrid.RowHeadersWidth = 82;
            ClassManGrid.Size = new Size(1038, 989);
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
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(2066, 981);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Member Management";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(71, 352);
            label18.Margin = new Padding(6, 0, 6, 0);
            label18.Name = "label18";
            label18.Size = new Size(111, 32);
            label18.TabIndex = 19;
            label18.Text = "Birthdate";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(65, 384);
            dateTimePicker2.Margin = new Padding(6);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(368, 39);
            dateTimePicker2.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(379, 723);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(236, 47);
            button3.TabIndex = 17;
            button3.Text = "Active On/Off";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(639, 4);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1428, 866);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Basic", "Premium", "VIP" });
            comboBox1.Location = new Point(65, 474);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 40);
            comboBox1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 439);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 32);
            label5.TabIndex = 15;
            label5.Text = "Member Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 269);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 32);
            label4.TabIndex = 14;
            label4.Text = "Tlf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 196);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 12;
            label2.Text = "Sur Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 11;
            label1.Text = "First Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(65, 301);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 39);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 233);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 39);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 158);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 39);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 85);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 39);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(65, 546);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(149, 47);
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
            tabPage5.Location = new Point(8, 46);
            tabPage5.Margin = new Padding(2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(2066, 981);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Instructor Management";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // InstructorCert
            // 
            InstructorCert.DropDownStyle = ComboBoxStyle.DropDownList;
            InstructorCert.FormattingEnabled = true;
            InstructorCert.Items.AddRange(new object[] { "Trail Running", "Forrest Yoga" });
            InstructorCert.Location = new Point(59, 398);
            InstructorCert.Name = "InstructorCert";
            InstructorCert.Size = new Size(242, 40);
            InstructorCert.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(59, 363);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(143, 32);
            label12.TabIndex = 29;
            label12.Text = "Certification";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(65, 284);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(41, 32);
            label14.TabIndex = 28;
            label14.Text = "Tlf";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(59, 201);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(71, 32);
            label15.TabIndex = 27;
            label15.Text = "Email";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(59, 130);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(120, 32);
            label16.TabIndex = 26;
            label16.Text = "Sur Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(59, 53);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(129, 32);
            label17.TabIndex = 25;
            label17.Text = "First Name";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(59, 316);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(201, 39);
            textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(59, 237);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(201, 39);
            textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(59, 162);
            textBox9.Margin = new Padding(2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(201, 39);
            textBox9.TabIndex = 21;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(59, 90);
            textBox10.Margin = new Padding(2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(201, 39);
            textBox10.TabIndex = 20;
            // 
            // button9
            // 
            button9.Location = new Point(59, 469);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(149, 47);
            button9.TabIndex = 19;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(554, 704);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(236, 47);
            button10.TabIndex = 18;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // InstructorGridView
            // 
            InstructorGridView.AccessibleRole = AccessibleRole.Cursor;
            InstructorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InstructorGridView.Location = new Point(839, 6);
            InstructorGridView.Margin = new Padding(6);
            InstructorGridView.Name = "InstructorGridView";
            InstructorGridView.RowHeadersWidth = 82;
            InstructorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InstructorGridView.Size = new Size(1222, 969);
            InstructorGridView.TabIndex = 1;
            InstructorGridView.CellEndEdit += InstructorGridView_CellEndEdit;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(8, 46);
            tabPage6.Margin = new Padding(2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(2066, 981);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Member Overview";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(8, 46);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(2066, 981);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reports";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2502, 1118);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
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
            ResumeLayout(false);
        }

        #endregion

        private Button MemberDeleteButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
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
    }
}
