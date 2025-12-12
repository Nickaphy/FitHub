namespace FitHub._1._UserInterface
{
    partial class FitHub_Login_UI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitHub_Login_UI));
            imageList1 = new ImageList(components);
            comboBoxLoginDropMenu = new ComboBox();
            buttonLogIn = new Button();
            pictureBox1 = new PictureBox();
            buttonCloseDown = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // comboBoxLoginDropMenu
            // 
            comboBoxLoginDropMenu.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            comboBoxLoginDropMenu.ForeColor = Color.FromArgb(73, 125, 201);
            comboBoxLoginDropMenu.FormattingEnabled = true;
            comboBoxLoginDropMenu.Items.AddRange(new object[] { "Admin", "Receptionist" });
            comboBoxLoginDropMenu.Location = new Point(511, 313);
            comboBoxLoginDropMenu.Name = "comboBoxLoginDropMenu";
            comboBoxLoginDropMenu.Size = new Size(167, 28);
            comboBoxLoginDropMenu.TabIndex = 1;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.FromArgb(31, 34, 56);
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonLogIn.ForeColor = Color.FromArgb(73, 125, 201);
            buttonLogIn.Location = new Point(511, 362);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(167, 29);
            buttonLogIn.TabIndex = 2;
            buttonLogIn.Text = "Login";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(46, 49, 84);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(361, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 216);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonCloseDown
            // 
            buttonCloseDown.BackColor = Color.FromArgb(46, 49, 84);
            buttonCloseDown.FlatAppearance.BorderColor = Color.FromArgb(31, 34, 56);
            buttonCloseDown.FlatStyle = FlatStyle.Flat;
            buttonCloseDown.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCloseDown.ForeColor = SystemColors.ButtonShadow;
            buttonCloseDown.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCloseDown.Location = new Point(1138, 12);
            buttonCloseDown.Name = "buttonCloseDown";
            buttonCloseDown.Size = new Size(34, 35);
            buttonCloseDown.TabIndex = 6;
            buttonCloseDown.Text = "X";
            buttonCloseDown.UseVisualStyleBackColor = false;
            buttonCloseDown.Click += buttonCloseDown_Click;
            // 
            // FitHub_Login_UI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 234);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 659);
            Controls.Add(buttonCloseDown);
            Controls.Add(buttonLogIn);
            Controls.Add(comboBoxLoginDropMenu);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FitHub_Login_UI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitHub_Login_UI";
            Load += FitHub_Login_UI_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private ComboBox comboBoxLoginDropMenu;
        private Button buttonLogIn;
        private PictureBox pictureBox1;
        private Button buttonCloseDown;
    }
}