using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHub._3._DataAccessLayer
{
    public class DalClassHistory
    {
        ConnectionString connectionstring = new ConnectionString();

        public List<ClassHistoryDTO> GetClassHistory(int instructorID)
        {
            List<ClassHistoryDTO> history = new List<ClassHistoryDTO>();
            string sql = "SELECT * FROM Instructor_Overview WHERE InstructorID = @InstructorID";
            using (SqlConnection connection = new SqlConnection(connectionstring.conn))
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@InstructorID", instructorID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    history.Add(new ClassHistoryDTO
                    {
                        ClassID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        ClassDate = reader.IsDBNull(1) ? DateTime.UtcNow : reader.GetDateTime(1),
                        ClassTime = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        ClassLocation = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        ClassType = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        ClassCapacity = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        InstructorID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                        InstructorName = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                    });
                }
            }
            return history;
        }
    }


}
