using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHub._2._BusinessLogicLayer
{
    internal class BLL_Error
    {
        public bool emailError(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Invalid email format. Email must contain '@' and '.' characters.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(email)) { return false; }
            return true;
        }

        public bool nameError(string firstName, string surName)
        {
            if (!firstName.All(char.IsLetter) || !surName.All(char.IsLetter))
            {
                MessageBox.Show("Names can only contain letters.");
                return false;
            }
            return true;
        }

        public bool telephoneError(string telephone)
        {
            if (!telephone.All(char.IsDigit) || telephone.Length != 8)
            {
                MessageBox.Show("A telephone number can only contain 8 digits");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(telephone))
            {
                return false;
            }
            return true;
        }

        public bool memberTypeError(int memberType)
        {
            if (memberType is int && memberType < 1 && memberType > 3)
            {
                return true;
            }
            return false;
        }
    }
}