using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHub._1._UserInterface
{
    public partial class FitHub_Login_UI : Form
    {
        public FitHub_Login_UI()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void FitHub_Login_UI_Load(object sender, EventArgs e)
        {

        }

        private void buttonCloseDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
