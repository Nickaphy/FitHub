using FitHub._2._BusinessLogicLayer;
using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using FitHub._3._DataAccessLayer;
using FitHub.B_BLL.ENT_OBJ;
using FitHub.C_DAL;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

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

        public bool AddClassBLL(Class classes)
        {
            BLL_Error bll_error = new BLL_Error();
            DalClasses dal = new DalClasses();

            bool classCapacityErrorProceed = bll_error.classCapacityError(classes.ClassCapacity);
            bool classTypeErrorProceed = bll_error.classTypeError(classes.ClassType);
            bool instructorIdErrorProceed = bll_error.instructorIdError(classes.InstructorID.ToString());
            bool classDateErrorProceed = bll_error.classDateError(classes.ClassDate);
            bool classTimeErrorProceed = bll_error.classTimeError(classes.ClassTime);
            bool classLocationErrorProceed = bll_error.classLocationError(classes.ClassLocation);

            if (classCapacityErrorProceed == true && classTypeErrorProceed == true && instructorIdErrorProceed == true && classDateErrorProceed == true && classTimeErrorProceed == true && classLocationErrorProceed == true)
            {
                dal.AddClassDAL(classes);
                return true;
            }
            return false;
        }

        public bool AddMemberBLL(Member member)
        {
            BLL_Error bll_error = new BLL_Error();
            DalMembers dal = new DalMembers();

            bool emailErrorProceed = bll_error.emailError(member.Email);
            bool nameErrorProceed = bll_error.nameError(member.FirstName, member.SurName);
            bool telephoneErrorProceed = bll_error.telephoneError(member.Telephone);
            bool DropBoxTypeErrorProceed = bll_error.DropBoxTypeError(member.MemberType);

            if (emailErrorProceed == true && nameErrorProceed == true && telephoneErrorProceed == true && DropBoxTypeErrorProceed == true)
            {
                //Capitalize first letter of first name and surname only and lower cases rest
                if (string.IsNullOrWhiteSpace(member.FirstName) == false)
                {
                    member.FirstName = char.ToUpperInvariant(member.FirstName[0]) + member.FirstName.Substring(1).ToLowerInvariant();
                }
                if (string.IsNullOrWhiteSpace(member.SurName) == false)
                {
                    member.SurName = char.ToUpperInvariant(member.SurName[0]) + member.SurName.Substring(1).ToLowerInvariant();
                }
                dal.AddMember(member);
                return true;
            }
            return false;
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

        public List<Class> GetAllClassesBLL()
        {
            DalClasses dal = new DalClasses();
            return dal.GetAllClassesDAL();
        }

        public bool AddInstructorBLL(Instructor instructor)
        {
            BLL_Error bll_error = new BLL_Error();
            DalInstructor dal = new DalInstructor();

            //Capitalize first letter of first name and surname only and lower cases rest
            if (string.IsNullOrWhiteSpace(instructor.FirstName) == false)
            {
                instructor.FirstName = char.ToUpperInvariant(instructor.FirstName[0]) + instructor.FirstName.Substring(1).ToLowerInvariant();
            }
            if (string.IsNullOrWhiteSpace(instructor.SurName) == false)
            {
                instructor.SurName = char.ToUpperInvariant(instructor.SurName[0]) + instructor.SurName.Substring(1).ToLowerInvariant();
            }

            bool emailErrorProceed = bll_error.emailError(instructor.Email);
            bool nameErrorProceed = bll_error.nameError(instructor.FirstName, instructor.SurName);
            bool telephoneErrorProceed = bll_error.telephoneError(instructor.Telephone);
            bool DropBoxTypeErrorProceed = bll_error.DropBoxTypeError(instructor.Certification);


            if (emailErrorProceed == true && nameErrorProceed == true && telephoneErrorProceed == true && DropBoxTypeErrorProceed == true)
            {
                dal.AddInstructor(instructor);
                return true;
            }
            return false;
        }

        public void BookingClass(int classID, int memberID)
        {
            DalBooking dal = new DalBooking();
            DalClasses dalClasses = new DalClasses();

            // get capacity for class
            var classes = dalClasses.GetAllClassesDAL();
            var cls = classes.FirstOrDefault(c => c.ClassID == classID);
            int capacity = 0;
            if (cls != null && int.TryParse(cls.ClassCapacity, out var parsed))
            {
                capacity = parsed;
            }

            // get current count
            int current = dal.GetBookingCountDAL(classID);

            if (capacity > 0 && current >= capacity)
            {
                MessageBox.Show("Class is full. Cannot book more members.");
                return;
            }

            dal.BookingClassDAL(classID, memberID);
        }


        public List<ClassHistoryDTO> GetClassHistory(int classID)
        {
            DalClassHistory dal = new DalClassHistory();
            return dal.GetClassHistory(classID);
        }



        DalMemberHistory dalHistory = new DalMemberHistory(); 
        public List<MemberHistoryDTO> GetMemberHistory(int memberID) 
        { 
            return dalHistory.GetMemberHistory(memberID);
        }



    }
}