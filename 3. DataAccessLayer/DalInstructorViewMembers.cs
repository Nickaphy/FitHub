using Microsoft.Data.SqlClient;

namespace FitHub
{
    public class DalInstructorViewMembers
    {
        ConnectionString connectionstring = new ConnectionString();

        public List<InstructorViewMembersDTO> GetInstructorViewMembers(int classID)
        {
            List<InstructorViewMembersDTO> viewMembers = new List<InstructorViewMembersDTO>();
            string sql = "SELECT * FROM Class_Overview WHERE ClassID = @ClassID";
            using (SqlConnection connection = new SqlConnection(connectionstring.conn))
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@ClassID", classID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    viewMembers.Add(new InstructorViewMembersDTO
                    {
                        MemberID = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                        MemberName = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                    });
                }
            }
            return viewMembers;
        }
    }
}
