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

        public bool DropBoxTypeError(string memberType)
        {

            if (string.IsNullOrWhiteSpace(memberType))
            {
                errormessages.DropBoxTypeErrorMessage();
                return false;
            }
            return true;
        }

        public bool classCapacityError(string capacityString)
        {
            if (!int.TryParse(capacityString.ToString(), out int capacity))
            {
                errormessages.ClassCapacityErrorMessage();
                return false;
            }
            else if (capacity <= 0 && capacity < 26)
            {
                errormessages.DropBoxTypeErrorMessage();
                return false;
            }
            return true;

        }

        public bool classTypeError(string classType)
        {
            if (string.IsNullOrWhiteSpace(classType))
            {
                errormessages.ClassTypeErrorMessage();
                return false;
            }
            return true;
        }

        public bool instructorIdError(string instructorID)
        {
            if (string.IsNullOrWhiteSpace(instructorID))
            {
                errormessages.InstructorIDErrorMessage();
                return false;
            }
            return true;
        }

        public bool classDateError(DateTime classDate)
        {
            if (classDate < DateTime.Now.Date || classDate == null)
            {
                errormessages.ClassDateErrorMessage();
                return false;
            }
            return true;
        }

        public bool classTimeError(string classTime)
        {
            if (string.IsNullOrWhiteSpace(classTime))
            {
                errormessages.ClassTimeErrorMessage();
                return false;
            }
            return true;
        }

        public bool classLocationError(string classLocation)
        {
            if (string.IsNullOrWhiteSpace(classLocation))
            {
                errormessages.ClassLocationErrorMessage();
                return false;
            }
            return true;
        }
    }
}