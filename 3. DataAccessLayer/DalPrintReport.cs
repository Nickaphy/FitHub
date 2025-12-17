using FitHub.B_BLL.ENT_OBJ;
using Microsoft.Data.SqlClient;

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
                "SELECT * FROM Members WHERE Active = 'Inactive' ORDER BY FirstName", con);

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
            List<Member> memberReport = new List<Member>();

            using var con = new SqlConnection(connectionstring.conn);
            con.Open();

            using var cmd = new SqlCommand("SELECT * FROM Members ORDER BY FirstName", con);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                memberReport.Add(new Member
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

            return memberReport;
        }

        public List<Member> GetAllActive()
        {
            List<Member> member = new List<Member>();

            using var con = new SqlConnection(connectionstring.conn);
            con.Open();

            using var cmd = new SqlCommand(
                "SELECT * FROM Members WHERE Active = 'Active' ORDER BY FirstName", con);

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
            List<Member> member = new List<Member>();

            string sql =
                "SELECT ClassType, SUM(TotalMembers) AS TotalMembers " +
                "FROM PopClassSum_Overview " +
                "GROUP BY ClassType " +
                "ORDER BY TotalMembers DESC;";

            using var con = new SqlConnection(connectionstring.conn);
            using var cmd = new SqlCommand(sql, con);

            con.Open();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                member.Add(new Member
                {
                    ClassType = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                    TotalMembers = reader.IsDBNull(1) ? 0 : reader.GetInt32(1)
                });
            }

            return member;
        }

        // New: time-constrained popularity summary
        public List<Member> GetPopClassSum(DateTime startDate, DateTime endDate)
        {
            List<Member> member = new List<Member>();

            string sql =
                "SELECT ClassType, SUM(TotalMembers) AS TotalMembers " +
                "FROM PopClassSum_Overview " +
                "WHERE ClassDate >= @startDate AND ClassDate <= @endDate " +
                "GROUP BY ClassType " +
                "ORDER BY TotalMembers DESC;";

            using var con = new SqlConnection(connectionstring.conn);
            using var cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@startDate", startDate.Date);
            cmd.Parameters.AddWithValue("@endDate", endDate.Date);

            con.Open();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                member.Add(new Member
                {
                    ClassType = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                    TotalMembers = reader.IsDBNull(1) ? 0 : reader.GetInt32(1)
                });
            }

            return member;
        }
    }
}

