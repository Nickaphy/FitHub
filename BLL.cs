using Microsoft.Identity.Client;
using System;
using System.Drawing.Text;

namespace FitHub
{
    public class BLL
    {
        private readonly DAL dal = new();
        public static void DeleteMemberBLL(string memberID)
        {
            DAL dal = new DAL();
            dal.DeleteMember(memberID);
        }      
        
        public List <Member> GetAllMembersBLL()
        {
            DAL dal = new DAL();
            return dal.GetAll();
        }
    }
}