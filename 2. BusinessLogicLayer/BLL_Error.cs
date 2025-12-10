using FitHub._1._UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHub._2._BusinessLogicLayer
{
    internal class BLL_Error
    {
        ErrorMessages errormessages = new ErrorMessages();
        public bool emailError(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                errormessages.EmailErrorMessage();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(email)) { return false; }
            return true;
        }

        public bool nameError(string firstName, string surName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(surName)) { errormessages.NameErrorMessage(); return false; }
            else
            {
                if (!firstName.All(char.IsLetter) || !surName.All(char.IsLetter))
                {
                    errormessages.NameErrorMessage();
                    return false;
                }
                return true;
            }
        }

        public bool telephoneError(string telephone)
        {
            if (!telephone.All(char.IsDigit) || telephone.Length != 8)
            {
                errormessages.TelephoneErrorMessage();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(telephone))
            {
                return false;
            }
            return true;
        }
        
        public bool DropBoxTypeError(string memberType)
        {
                        
            if (string.IsNullOrWhiteSpace(memberType))
            {
                errormessages.DropBoxTypeErrorMessage();
                return false;
            }
            return true;
        }
    }
}