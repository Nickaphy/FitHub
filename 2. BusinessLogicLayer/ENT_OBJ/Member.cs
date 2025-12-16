using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHub.B_BLL.ENT_OBJ
{
    public class Member
    {
        public  int MemberID { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime Birthday { get; set; }
        public string MemberType { get; set; }
        public string Active { get; set; }
        public string ClassType { get; set; }
        public DateTime ClassDate { get; set; }
        public int ClassID { get; set; }
        public int TotalMembers { get; set; }

    }
}
