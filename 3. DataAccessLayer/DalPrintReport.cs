using FitHub.B_BLL.ENT_OBJ;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHub._3._DataAccessLayer
{

    internal class DalPrintReport
    {
        internal List<Member> memberList;
        ConnectionString connectionstring = new ConnectionString();

        public List<Member> GetAllInactive()
        {
            List<Member> memberList = new List<Member>();
            using var con = new SqlConnection(connectionstring.conn);
            con.Open();
            using var cmd = new SqlCommand("SELECT * FROM Members WHERE ACTIVE = 'INACTIVE'", con);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //add new memebers to memberList (if DB=null, set to default value)
                //else read the vale from the DB.
                memberList.Add(new Member
                {
                    MemberID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    FirstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    SurName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Email = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Telephone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    Birthday = reader.IsDBNull(5) ? DateTime.UtcNow : reader.GetDateTime(5),
                    MemberType = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    Active = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                });
            }
            con.Close();
            return memberList;
        }
    }
}
