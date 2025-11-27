using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHub.B_BLL.ENT_OBJ;
using Microsoft.Data.SqlClient;

namespace FitHub.C_DAL
{
    public class DAL
    {
         string conn = "Server=NICKLAS;DataBase=FitHubDB;" +
            "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        //A method that deletes a member from the Members tale based on their MemberID.
        public void DeleteMember(int memberID)
        {
            using var con = new SqlConnection(conn);
            con.Open();
            using var delMemCmd = new SqlCommand("DELETE FROM Members WHERE MemberID = @MemberID", con);
            delMemCmd.Parameters.Add("@MemberID", System.Data.SqlDbType.Int).Value = memberID;
            delMemCmd.ExecuteNonQuery();
        }





        //Takes Members table and reads them into memberList.
        public List<Member> GetAll()
        {
            List<Member> memberList = new List<Member>();
            using var con = new SqlConnection(conn);   
            con.Open();
            using var cmd = new SqlCommand("SELECT * FROM Members", con);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //add new memebers to memberList (if DB=null, set to default value)
                //else read the vale from the DB.
                memberList.Add(new Member
                {
                    MemberID = reader.IsDBNull(0) ? 0: reader.GetInt32(0),
                    FirstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    SurName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Email = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Telephone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    MemberType = reader.IsDBNull(5) ? 0: reader.GetInt32(5),
                });  
            }
            con.Close();
            return memberList;
        }
    }
}