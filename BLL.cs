using Microsoft.Identity.Client;
using System;
using System.Drawing.Text;
using System.Collections.Generic;

namespace FitHub
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