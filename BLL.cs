using Microsoft.Identity.Client;
using System;
using System.Drawing.Text;

namespace FitHub
{
    public class BLL
    {
        /*private readonly DAL dal = new();
        static void DeleteMemberBLL()
            {
            DAL dal = new DAL();
            var MemberID 
            dal.DeleteMember();
        } */     
        
        public List <Member> GetAllMembersBLL()
        {
            DAL dal = new DAL();
            return dal.GetAll();
        }
    }
}