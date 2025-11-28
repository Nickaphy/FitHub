using Microsoft.Identity.Client;
using System;
using System.Drawing.Text;
using System.Collections.Generic;
using FitHub.C_DAL;
using FitHub.B_BLL.ENT_OBJ;

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
            DalMembers dal = new DalMembers();
            dal.AddMember(firstName, surName, email, telephone, memberType, active);
        }
    }
}