using Microsoft.Identity.Client;
using System;
using System.Drawing.Text;
using System.Collections.Generic;
using FitHub.C_DAL;
using FitHub.B_BLL.ENT_OBJ;
using FitHub._2._BusinessLogicLayer;

namespace FitHub.B_BLL
{
    public class BLL
    {
        private readonly DalMembers dal = new();
        public static void DeleteMemberBLL(int memberID)
        {
            DalMembers dal = new DalMembers();
            dal.DeleteMember(memberID);
        }



        //Mid call to DAL to get all members
        public List <Member> GetAllMembersBLL()
        {
            DalMembers dal = new DalMembers();
            return dal.GetAll();
        }

        public void AddMemberBLL(string firstName, string surName, string email, string telephone, int memberType, string active)
        {
            BLL_Error bll_error = new BLL_Error();
            DalMembers dal = new DalMembers();

            //Capitalize first letter of first name and surname only and lower cases rest
            firstName = char.ToUpperInvariant(firstName[0]) + firstName.Substring(1).ToLowerInvariant();
            surName = char.ToUpperInvariant(surName[0]) + surName.Substring(1).ToLowerInvariant();

            bool emailErrorProceed = bll_error.emailError(email);
            bool nameErrorProceed = bll_error.nameError(firstName, surName);
            bool telephoneErrorProceed = bll_error.telephoneError(telephone);

            if (emailErrorProceed == true && nameErrorProceed == true && telephoneErrorProceed == true)
            {
                dal.AddMember(firstName, surName, email, telephone, memberType, active);
            }


            
           
        }
    }
}