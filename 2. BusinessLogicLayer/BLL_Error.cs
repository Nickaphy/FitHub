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

        //Email error check, checks if email contains "@" and "." and not null or whitespace
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

        //Name error check, checks if first name and surname are not null or whitespace and only contain letters
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

        //Telephone error check, checks if telephone number is 8 digits long and only contains digits
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

        //Makes sure something is selected in the drop box
        public bool DropBoxTypeError(string memberType)
        {

            if (string.IsNullOrWhiteSpace(memberType))
            {
                errormessages.DropBoxTypeErrorMessage();
                return false;
            }
            return true;
        }

        //Makes sure class capacity is a number between 1 and 25
        public bool classCapacityError(string capacityString)
        {
            if (!int.TryParse(capacityString.ToString(), out int capacity))
            {
                errormessages.ClassCapacityErrorMessage();
                return false;
            }
            else if (capacity <= 0 && capacity < 26)
            {
                return true;
            }
            return true;

        }

        //Makes sure class type is not null or whitespace
        public bool classTypeError(string classType)
        {
            if (string.IsNullOrWhiteSpace(classType))
            {
                errormessages.ClassTypeErrorMessage();
                return false;
            }
            return true;
        }

        //Makes sure instructor ID is not null or whitespace
        public bool instructorIdError(string instructorID)
        {
            if (string.IsNullOrWhiteSpace(instructorID))
            {
                errormessages.InstructorIDErrorMessage();
                return false;
            }
            return true;
        }

        //Makes sure class date is not in the past or null
        public bool classDateError(DateTime classDate)
        {
            if (classDate < DateTime.Now.Date || classDate == null)
            {
                errormessages.ClassDateErrorMessage();
                return false;
            }
            return true;
        }

        //Makes sure class time is not null or whitespace
        public bool classTimeError(string classTime)
        {
            if (string.IsNullOrWhiteSpace(classTime))
            {
                errormessages.ClassTimeErrorMessage();
                return false;
            }
            return true;
        }

        //Makes sure class location is not null or whitespace
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