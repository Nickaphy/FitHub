using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using Microsoft.Data.SqlClient;

namespace FitHub
{
    internal class DalMemberHistory
    {
        ConnectionString connectionstring = new ConnectionString();

        public List<MemberHistoryDTO> GetMemberHistory(int memberID)
        {
            List<MemberHistoryDTO> history = new List<MemberHistoryDTO>();
            string sql = "SELECT * FROM Member_Overview WHERE MemberID = @MemberID";
            using (SqlConnection connection = new SqlConnection(connectionstring.conn))
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@MemberID", memberID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    history.Add(new MemberHistoryDTO
                    {
                        ClassType = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        ClassDate = reader.IsDBNull(1) ? DateTime.UtcNow : reader.GetDateTime(1),
                        InstructorName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        ClassCapacity = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Birthday = reader.IsDBNull(4) ? DateTime.UtcNow : reader.GetDateTime(4),
                        ClassID = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                        InstructorID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                        MemberName = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        MemberID = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                    });
                }
            }
            return history;
        }
    }
}
