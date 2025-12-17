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

        public void ClassCapacityErrorMessage()
        {
            MessageBox.Show("Class capacity must be between 1 and 25, and must be a numeric value");
        }

        public void ClassTypeErrorMessage()
        {
            MessageBox.Show("Must choose a class type");
        }

        public void InstructorIDErrorMessage()
        {
            MessageBox.Show("Must choose an instructor");
        }

        public void ClassDateErrorMessage()
        {
            MessageBox.Show("Either you forgot to choose a date, or you chose a date from the past");
        }

        public void ClassTimeErrorMessage()
        {
            MessageBox.Show("You have to choose a time for the class");
        }

        public void ClassLocationErrorMessage()
        {
            MessageBox.Show("You have to enter a location for the class");
        }

        public void BookingFullErrorMessage()
        {
            MessageBox.Show("Class is full. Cannot book more members.");
        }

        public void DoubleBookingErrorMessage()
        {
            MessageBox.Show("Member already booked to this class.");
        }

    }
}
