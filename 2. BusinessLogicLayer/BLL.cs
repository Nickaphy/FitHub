using FitHub._2._BusinessLogicLayer;
using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using FitHub._3._DataAccessLayer;
using FitHub.B_BLL.ENT_OBJ;
using FitHub.C_DAL;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        public List<Member> GetAllMembersBLL()
        {
            DalMembers dal = new DalMembers();
            return dal.GetAll();
        }

        public void AddMemberBLL(Member member)
        {
            BLL_Error bll_error = new BLL_Error();
            DalMembers dal = new DalMembers();

            //Capitalize first letter of first name and surname only and lower cases rest
            member.FirstName = char.ToUpperInvariant(member.FirstName[0]) + member.FirstName.Substring(1).ToLowerInvariant();
            member.SurName = char.ToUpperInvariant(member.SurName[0]) + member.SurName.Substring(1).ToLowerInvariant();

            bool emailErrorProceed = bll_error.emailError(member.Email);
            bool nameErrorProceed = bll_error.nameError(member.FirstName, member.SurName);
            bool telephoneErrorProceed = bll_error.telephoneError(member.Telephone);
            bool memberTypeErrorProceed = bll_error.memberTypeError(member.MemberType);
            

            if (emailErrorProceed == true && nameErrorProceed == true && telephoneErrorProceed == true && memberTypeErrorProceed == true)
            {
                dal.AddMember(member);
            }
        }

        public string ActivityStatus(int memberID, string activityStatus)
        {
            DalMembers dalmembers = new DalMembers();
            string newStatus;
            if (activityStatus == "Active")
            {
                newStatus = "Inactive";
            }
            else
            {
                newStatus = "Active";
            }
            dalmembers.ChangeActivity(newStatus, memberID);

            return newStatus;
        }



        public List<Instructor> GetAllInstructorsBLL()
        {
            DalInstructor dal = new DalInstructor();
            return dal.GetAllInstructors();
        }

        public void AddInstructorBLL(Instructor instructor)
        {
            BLL_Error bll_error = new BLL_Error();
            DalInstructor dal = new DalInstructor();

            //Capitalize first letter of first name and surname only and lower cases rest
            instructor.FirstName  = char.ToUpperInvariant(instructor.FirstName[0]) + instructor.FirstName.Substring(1).ToLowerInvariant();
            instructor.SurName = char.ToUpperInvariant(instructor.SurName[0]) + instructor.SurName.Substring(1).ToLowerInvariant();

            bool emailErrorProceed = bll_error.emailError(instructor.Email);
            bool nameErrorProceed = bll_error.nameError(instructor.FirstName, instructor.SurName);
            bool telephoneErrorProceed = bll_error.telephoneError(instructor.Telephone);


            if (emailErrorProceed == true && nameErrorProceed == true && telephoneErrorProceed == true)
            {
                dal.AddInstructor(instructor);
            }
        }
    }
}