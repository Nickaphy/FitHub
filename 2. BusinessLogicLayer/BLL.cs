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
        private readonly DAL dal = new();
        public static void DeleteMemberBLL(int memberID)
        {
            DAL dal = new DAL();
            dal.DeleteMember(memberID);
        }



        //Mid call to DAL to get all members
        public List <Member> GetAllMembersBLL()
        {
            DAL dal = new DAL();
            return dal.GetAll();
        }
    }
}