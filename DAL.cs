using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;               

namespace FitHub
{
    public class DAL
    {
         string conn = "Server=NICKLAS;DataBase=FitHubDB;" +
            "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

       /* public void DeleteMember()
        {
            using var con = new SqlConnection(conn);
            con.Open();
            using var delMemCmd = new SqlCommand("DELETE FROM Members WHERE MemberID = @MemberID", con);
            {
                delMemCmd.Parameters.AddWithValue("@MemberID",MemberID);
                delMemCmd.ExecuteNonQuery();
            }
        }*/
        
        public List<Member> GetAll()
        {
            List<Member> memberList = new List<Member>();
            using var con = new SqlConnection(conn);   
            con.Open();
            using var cmd = new SqlCommand("SELECT * FROM Members", con);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                memberList.Add(new Member
                {
                    MemberID = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    SurName = reader.GetString(2),
                    Email = reader.GetString(3),
                    Telephone = reader.GetString(4),
                    MemberType = reader.GetInt32(5),
                });  
            }
            con.Close();
            return memberList;
        }
    }
}
