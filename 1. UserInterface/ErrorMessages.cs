using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHub._1._UserInterface
{
    internal class ErrorMessages
    {
        public void NameErrorMessage()
        {
            MessageBox.Show("Names can only contain letters.");
        }

        public void EmailErrorMessage()
        {
            MessageBox.Show("Invalid email format. Email must contain '@' and '.' characters.");
        }

        public void TelephoneErrorMessage()
        {
            MessageBox.Show("A telephone number can only contain 8 digits");
        }

        public void DropBoxTypeErrorMessage()
        {
            MessageBox.Show("You have to make a selection");
        }
    }
}
