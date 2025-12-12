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
            pictureBox1 = new PictureBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(206, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 330);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.Red;
            flowLayoutPanel3.Location = new Point(-29, 53);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(968, 42);
            flowLayoutPanel3.TabIndex = 63;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Red;
            flowLayoutPanel2.Location = new Point(277, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(58, 499);
            flowLayoutPanel2.TabIndex = 60;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 26);
            panel1.TabIndex = 62;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Red;
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(885, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(26, 498);
            flowLayoutPanel1.TabIndex = 61;
            // 
            // formRaportsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 126, 150);
            ClientSize = new Size(911, 498);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRaportsTab";
            Text = "formRaportsTab";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}