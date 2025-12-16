using FitHub._2._BusinessLogicLayer.ENT_OBJ;
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
        ConnectionString connectionstring = new ConnectionString();

        public List<Member> GetAllInactive()
        {
            List<Member> member = new List<Member>();

            using var con = new SqlConnection(connectionstring.conn);
            con.Open();

            using var cmd = new SqlCommand(
                "SELECT * FROM Members WHERE Active = 'Inactive'", con);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                member.Add(new Member
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

            return member;
        }
        public List<Member> GetAllMembers()
        {
            List<Member> member = new List<Member>();

            using var con = new SqlConnection(connectionstring.conn);
            con.Open();

            using var cmd = new SqlCommand("SELECT * FROM Members", con);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                member.Add(new Member
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

            return member;
        }
        public List<Member> GetAllActive()
        {
            List<Member> member = new List<Member>();

            using var con = new SqlConnection(connectionstring.conn);
            con.Open();

            using var cmd = new SqlCommand(
                "SELECT * FROM Members WHERE Active = 'Active'", con);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                member.Add(new Member
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

            return member;
        }
        public List<Member> GetPopClassSum()

        {
           /* List<Member> member = new List<Member>();

            using var con = new SqlConnection(connectionstring.conn);
            con.Open();

            using var cmd = new SqlCommand(
                "SELECT ClassType, SUM(TotalMembers) AS TotalMembers\r\n" +
                "FROM PopClassSum_Overview\r\nWHERE ClassDate BETWEEN @PrintFromPicker AND " +
                "@PrintToPicker\r\nGROUP BY ClassType, ClassDate\r\nORDER BY TotalMembers DESC;", con);

            using var reader = cmd.ExecuteReader();*/


           List<Member> member = new List<Member>();
            string sql = "SELECT ClassType, SUM(TotalMembers) AS TotalMembers\r\n" +
                "FROM PopClassSum_Overview\r\nWHERE ClassDate BETWEEN @PrintFromPicker AND " +
                "@PrintToPicker\r\nGROUP BY ClassType, ClassDate\r\nORDER BY TotalMembers DESC;";
            using (SqlConnection connection = new SqlConnection(connectionstring.conn))
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
               connection.Open(); SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())

                {
                    member.Add(new Member
                    {
                        ClassType = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        ClassDate = reader.IsDBNull(1) ? DateTime.UtcNow : reader.GetDateTime(1),
                        TotalMembers = reader.IsDBNull(2) ? 0 : reader.GetInt32(2)
                    });
                }
            }
            return member;
        }
    }
}

